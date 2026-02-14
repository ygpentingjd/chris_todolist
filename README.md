# Todo List API (.NET 8)
Repository ini berisi solusi untuk **Backend Intern Technical Test**. Project ini adalah RESTful API sederhana untuk mengelola *Todo List* yang dibangun menggunakan **ASP.NET Core Web API** dan database **SQLite**.

## Fitur
API ini mendukung operasi CRUD dan status penyelesaian tugas:
- **Create Todo**: Menambahkan tugas baru.
- **Get Todos**: Melihat semua daftar tugas.
- **Get Todo Detail**: Melihat detail tugas berdasarkan ID.
- **Complete Todo**: Menandai tugas sebagai selesai (`IsCompleted = true`).
- **Delete Todo**: Menghapus tugas.

## 1. Persyaratan yang dibutuhkan
Pastikan sudah menginstall:
- .Net SDK 8
- Git.

## 2. Clone Repository 

## 3. Install Dependencies
Pastikan semua library sudah terinstall dan sesuai dengan versi .NET yang digunakan.
```bash
# Install Entity Framework Core untuk Sqlite
dotnet add package Microsift.EntityFrameworkCore.Sqlite

# Install Tools untuk Migrasi Database
dotnet add package.Microsoft.EntityFrameworkCore.Design
dotnet add package.Microsoft.EntityFrameworkCore.Tools
```
Atau jalankan perintah restore untuk mengunduh semua dependency yang tercatat di file .csproj:
```bash
dotnet restore
```

## 4. Setup Database (Migrasi)
Lakukan migrasi agar tabel database Sqlite terbentuk.
```bash
# Mmebuat file database app.db
dotnet ef database update
```
catatan: jika perintah dotnet ef tidak dikenali, install global toolnya terlebih dahulu:
```bash
dotnet tool install --global dotnet-ef
```

## 5. Menjalankan Aplikasi
```bash
dotnet run
```

## 6. Testing
Testing dapat dilakukan dengan cara, mengakses host dengan port yang diberikan pada saat menjalankan aplikasi, seperti contoh:
<pre>
  info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:5219
</pre>
tekan ctrl dan klik localhost yang diberikan lalu tambahkan "/swagger/index.html"
<pre>
  http://localhost:5219/swagger/index.html
</pre>
