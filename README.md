Laboratori 1: Instalimi i ambientit te zhvillimit
Leksionet: L1
Teknologjite: .NET 10 SDK, Visual Studio, SQL Server, SSMS, Git

Objektivi
Pergatitja e ambientit qe do te perdoret ne laboratoret ne vijim dhe verifikimi qe cdo pjese funksionon.

Zhvillimi
U ndertua nje aplikacion Console ne .NET 10 me qellim shfaqjen e versionit te runtime-it nepermjet Environment.Version i cili u lidh me databazen StudentDB ne SQL Server Express nepermjet Microsoft.Data.SqlClient. Pas ekzekutimit te ketij aplikacioni rezultati qe shfaqet eshte nr i rreshtave te tabeles Studente.

Databaza
Databaza StudentDB dhe tabela me 3 rreshta testimi Studentet janë krijuar në SSMS:
CREATE DATABASE StudentDB;
GO
USE StudentDB;
GO

CREATE TABLE Studentet (
    Id      INT IDENTITY PRIMARY KEY,
    Emri    NVARCHAR(50) NOT NULL,
    Mbiemri NVARCHAR(50) NOT NULL
);
GO

INSERT INTO Studentet (Emri, Mbiemri) VALUES
    (N'Altea',  N'Kenuti'),
    (N'Bela',   N'Bina'),
    (N'Aurora', N'Aki');
GO

Hapat per ekzekutim
Kontrollojme nese SQL Server Express eshte aktiv.
2. Hapim SSMS, lidhemi me .\SQLEXPRESS dhe ekzekutojme skriptin SQL mesiper.
Për SQL Express perdorem serverin .\SQLEXPRESS, databazen StudentDB dhe TrustServerCertificate=True
3. Ekzekutojme dhe rezultati qe shfaqet eshte:
Versioni i runtime: 10.0.15
Nr. i studenteve: 3
