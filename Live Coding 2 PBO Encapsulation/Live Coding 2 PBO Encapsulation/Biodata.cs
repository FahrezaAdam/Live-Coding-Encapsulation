class Biodata
{
    public string Nama { get; set; }
    public string Prodi { get; set; }
    public string Nim { get; private set; }

    public Biodata(string nama, string prodi)
    {
        Nama = nama;
        Prodi = prodi;
        Nim = "Belum diisi";
    }

    public void SetNim(string nim)
    {
        if (nim.Length != 4)
        {
            Console.WriteLine("Error: NIM harus 4 digit!");
            return;
        }

        bool isValid = false;

        if (Prodi == "Sistem Informasi" && nim[0] == '1')
            isValid = true;
        else if (Prodi == "Teknologi Informasi" && nim[0] == '2')
            isValid = true;
        else if (Prodi == "Informatika" && nim[0] == '3')
            isValid = true;

        if (isValid)
        {
            Nim = nim;
            Console.WriteLine("NIM berhasil disimpan!");
        }
        else
        {
            Console.WriteLine("Error: NIM tidak sesuai prodi!");
        }
    }

    public void TampilData()
    {
        Console.WriteLine("\n=== Biodata Mahasiswa ===");
        Console.WriteLine($"Nama : {Nama}");
        Console.WriteLine($"Prodi: {Prodi}");
        Console.WriteLine($"NIM  : {Nim}");
    }
}
