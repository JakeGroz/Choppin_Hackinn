using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", @"C:\Users\Jake\Desktop\ACCENTURE\Choppin_Hackin\ConsoleApp1\ConsoleApp1\qrcodejs\testpage.html");



            //System.Diagnostics.Process.Start(@"C:\Users\Jake\Desktop\ACCENTURE\Choppin_Hackin\qrcodejs\testpage.html");
        }


        public void foo_OnClick()
        {
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", @"C:\Users\Jake\Desktop\ACCENTURE\Choppin_Hackin\ConsoleApp1\ConsoleApp1\qrcodejs\testpage - Copy.html");

        }
    }
}
