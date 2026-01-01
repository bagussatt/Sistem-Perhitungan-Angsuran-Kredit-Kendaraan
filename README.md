# IMS Finance
<img width="785" height="353" alt="image" src="https://github.com/user-attachments/assets/14c04d0c-f579-4254-b215-5033bf714c1b" />
<img width="791" height="256" alt="image" src="https://github.com/user-attachments/assets/382e6d11-ae43-46a8-9013-b17bb661d3fc" />


Aplikasi manajemen keuangan berbasis web menggunakan Blazor Server dan MySQL.

## Tech Stack

- .NET 8.0 (Blazor Server)
- MySQL 8.0
- Docker

## Prerequisites

- Docker Desktop terinstall

## Cara Menjalankan

1. Clone repository ini
2. Jalankan perintah berikut di terminal:

```bash
docker-compose up --build
```

3. Akses aplikasi di http://localhost:5000

## Struktur Project

- `IMSApp/` - Aplikasi Blazor Server
- `data/init.sql` - Script inisialisasi database
- `docker-compose.yml` - Konfigurasi Docker containers

## Konfigurasi Database

Database MySQL akan otomatis dibuat saat container pertama kali dijalankan menggunakan:
- Database: ims_finance
- User: root
- Password: password123

## Ports

- Web Application: 5000
- MySQL: 3306
