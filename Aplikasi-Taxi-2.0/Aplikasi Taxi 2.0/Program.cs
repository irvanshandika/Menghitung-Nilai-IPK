namespace AplikasiTaxi
{
    public class Taxi
    {
        public string Nama { get; set; }
        public string Lokasiawal { get; set; }
        public string Tujuan { get; set; }
        public void Registrasi()
        {
            Console.WriteLine("Nama : {0}", Nama);

            Console.WriteLine("Lokasi Anda Sekarang : {0}", Lokasiawal);

            Console.WriteLine("Tujuan Anda : {0}", Tujuan);
        }
    }
    class Program
    {


        static void Main(string[] args)
        {
            Taxi myObj = new Taxi();
            Console.Write("Masukkan Nama : ");
            myObj.Nama = Console.ReadLine();

            Console.Write("Lokasi Anda Sekarang : ");
            myObj.Lokasiawal = Console.ReadLine();

            Console.Write("Tujuan Anda : ");
            myObj.Tujuan = Console.ReadLine();

            //Output panggil method registrasi
            myObj.Registrasi();
        }
    }
}