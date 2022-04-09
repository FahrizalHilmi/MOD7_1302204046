using System;

namespace modul7_1302204046
{
    public class Program
    {

        static void Main(string[] args)
        {
            try
            {
                BankTransferConfig runtime = new BankTransferConfig();
                runtime.konfigurasi();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}