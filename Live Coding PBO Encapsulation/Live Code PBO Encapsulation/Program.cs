class Program
{
    static void Main(string[] args)
    {
        Perpustakaan perpustakaan = new Perpustakaan();
        bool keluar = false;

        while (!keluar)
        {
            Console.WriteLine("\nMenu Perpustakaan:");
            Console.WriteLine("1. Lihat Daftar Buku");
            Console.WriteLine("2. Tambah Buku (Hanya Pihak Perpustakaan)");
            Console.WriteLine("3. Hapus Buku (Hanya Pihak Perpustakaan)");
            Console.WriteLine("4. Ubah Judul Buku (Hanya Pihak Perpustakaan)");
            Console.WriteLine("5. Keluar");
            Console.Write("Pilih opsi (1-5): ");

            string pilihan = Console.ReadLine();
            switch (pilihan)
            {
                case "1":
                    perpustakaan.LihatBuku();
                    break;

                case "2":
                    if (perpustakaan.VerifikasiKataSandi())  
                    {
                        Console.Write("\nMasukkan judul buku baru: ");
                        string judulBaru = Console.ReadLine();
                        perpustakaan.TambahBuku(judulBaru);
                    }
                    break;

                case "3":
                    if (perpustakaan.VerifikasiKataSandi())  
                    {
                        Console.Write("\nMasukkan judul buku yang ingin dihapus: ");
                        string judulHapus = Console.ReadLine();
                        perpustakaan.HapusBuku(judulHapus);
                    }
                    break;

                case "4":
                    if (perpustakaan.VerifikasiKataSandi())  
                    {
                        Console.Write("\nMasukkan judul buku yang ingin diubah: ");
                        string judulLama = Console.ReadLine();
                        Console.Write("Masukkan judul buku baru: ");
                        string judulUbah = Console.ReadLine();
                        perpustakaan.UbahJudulBuku(judulLama, judulUbah);
                    }
                    break;

                case "5":
                    keluar = true;
                    Console.WriteLine("Keluar dari program.");
                    break;

                default:
                    Console.WriteLine("Pilihan tidak valid. Silakan pilih antara 1-5.");
                    break;
            }
        }
    }
}
