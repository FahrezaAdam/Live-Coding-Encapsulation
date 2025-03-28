using System;

class Perpustakaan
{
    private List<string> judulBuku;
    private const string KATA_SANDI_PERPUSTAKAAN = "admin123"; 

    public Perpustakaan()
    {
        judulBuku = new List<string>
        {
            "Pengenalan C#",
            "Algoritma Pemrograman",
            "Teori Graf",
            "Sistem Basis Data"
        };
    }

    public void LihatBuku()
    {
        Console.WriteLine("\nDaftar Buku yang Tersedia di Perpustakaan:");
        foreach (var judul in judulBuku)
        {
            Console.WriteLine("- " + judul);
        }
    }

    public void TambahBuku(string judul)
    {
        judulBuku.Add(judul);
        Console.WriteLine($"\nBuku '{judul}' berhasil ditambahkan oleh pihak perpustakaan.");
    }

    public void HapusBuku(string judul)
    {
        if (judulBuku.Remove(judul))
        {
            Console.WriteLine($"\nBuku '{judul}' berhasil dihapus oleh pihak perpustakaan.");
        }
        else
        {
            Console.WriteLine($"\nBuku '{judul}' tidak ditemukan di perpustakaan.");
        }
    }

    public void UbahJudulBuku(string judulLama, string judulBaru)
    {
        int indeks = judulBuku.IndexOf(judulLama);
        if (indeks != -1)
        {
            judulBuku[indeks] = judulBaru;
            Console.WriteLine($"\nJudul buku '{judulLama}' berhasil diubah menjadi '{judulBaru}' oleh pihak perpustakaan.");
        }
        else
        {
            Console.WriteLine($"\nBuku '{judulLama}' tidak ditemukan di perpustakaan.");
        }
    }

    public bool VerifikasiKataSandi()
    {
        Console.Write("\nMasukkan kata sandi: ");
        string inputKataSandi = Console.ReadLine();

        if (inputKataSandi == KATA_SANDI_PERPUSTAKAAN)
        {
            return true;
        }
        else
        {
            Console.WriteLine("Kata sandi salah! Akses ditolak.");
            return false;
        }
    }
}