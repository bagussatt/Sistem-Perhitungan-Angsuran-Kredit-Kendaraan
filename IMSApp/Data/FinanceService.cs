using MySql.Data.MySqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;

namespace IMSApp.Data
{
    public class FinanceService 
    {
        private readonly string _connString;
        public FinanceService(IConfiguration config) => _connString = config.GetConnectionString("DefaultConnection") ?? "";

        public async Task<DataTable> GetDendaData() 
        {
            using var conn = new MySqlConnection(_connString);
            string sql = @"
                SELECT KONTRAK_NO, 'SUGUS' as CLIENT_NAME, ANGSURAN_KE,
                DATEDIFF('2024-08-14', TANGGAL_JATUH_TEMPO) as HARI,
                (ANGSURAN_PER_BULAN * 0.001 * DATEDIFF('2024-08-14', TANGGAL_JATUH_TEMPO)) as TOTAL_DENDA
                FROM JADWAL_ANGSURAN 
                WHERE TANGGAL_JATUH_TEMPO < '2024-08-14' AND ANGSURAN_KE >= 6";
            
            var dt = new DataTable();
            await conn.OpenAsync();
            using var cmd = new MySqlCommand(sql, conn);
            using var reader = await cmd.ExecuteReaderAsync();
            dt.Load(reader);
            return dt;
        }
    }
}