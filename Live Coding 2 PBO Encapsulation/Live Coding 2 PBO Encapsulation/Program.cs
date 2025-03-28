class Program
{
    static void Main()
    {
        Biodata mhs1 = new Biodata("Reza", "Teknologi Informasi");
        mhs1.TampilData();

        Console.WriteLine("\nCoba set NIM 3057:");
        mhs1.SetNim("3057");
        mhs1.TampilData();

        Console.WriteLine("\nCoba set NIM 2057:");
        mhs1.SetNim("2057");
        mhs1.TampilData();
    }
}