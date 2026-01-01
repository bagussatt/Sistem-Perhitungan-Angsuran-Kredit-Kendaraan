# IMS Finance

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
