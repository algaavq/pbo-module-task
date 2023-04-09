using System;
using System.Reflection;

namespace Tugas
{
    public class Laptop
    {
        public string Merk;
        public string Tipe;
        public Vga Vga;
        public Processor Processor;

        public Laptop(string merk, string tipe, Vga vga, Processor processor)
        {
            Merk = merk;
            Tipe = tipe;
            Vga = vga;
            Processor = processor;
        }

        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {Merk} {Tipe} menyala");
        }

        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {Merk} {Tipe} mati");
        }

    }

    public class Lenovo : Laptop
    {
        public Lenovo(string tipe, Vga vga, Processor processor) : base("Lenovo", tipe, vga, processor)
        {
            Merk = "Lenovo";
        }
    }

    public class Ideapad : Lenovo
    {
        public Ideapad(Vga vga, Processor processor) : base("Ideapad", vga, processor)
        {
            Tipe = "Ideapad";
        }
    }

    public class Legion : Lenovo
    {
        public Legion(Vga vga, Processor processor) : base("Legion", vga, processor)
        {
            Tipe = "Legion";
        }
    }

    public class ACER : Laptop
    {
        public ACER(string tipe, Vga vga, Processor processor) : base("ACER", tipe, vga, processor)
        {

        }
    }

    public class Swift : ACER
    {
        public Swift(Vga vga, Processor processor) : base("Swift", vga, processor)
        {

        }
    }

    public class Predator : ACER
    {
        public Predator(Vga vga, Processor processor) : base("Predator", vga, processor)
        {

        }

        public void BermainGame()
        {
            Console.WriteLine("Laptop " + Merk + " " + Tipe + " sedang bermain game");
        }
    }


    public class ASUS : Laptop
    {
        public ASUS(string tipe, Vga vga, Processor processor) : base("ASUS", tipe, vga, processor)
        {
        }
    }

    public class ROG : ASUS
    {
        public ROG(Vga vga, Processor processor) : base("ROG", vga, processor)
        {

        }
    }

    public class VivoBook : ASUS
    {
        public VivoBook(Vga vga, Processor processor) : base("VivoBook", vga, processor)
        {

        }

        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }

    public class Vga
    {
        public string Merk;

        // Constructor
        public Vga(string merk)
        {
            Merk = merk;
        }
    }

    public class Nvidia : Vga
    {
        // Constructor
        public Nvidia() : base("Nvidia")
        {
        }
    }

    public class VgaAMD : Vga
    {
        // Constructor
        public VgaAMD() : base("AMD")
        {
        }
    }

    public abstract class Processor
    {
        public string Merk;
        public string Tipe;

        public Processor(string merk, string tipe)
        {
            Merk = merk;
            Tipe = tipe;
        }
    }

    public class AMD : Processor
    {
        public AMD(string tipe) : base("AMD", tipe)
        {
        }
    }

    public class Ryzen : AMD
    {
        public Ryzen() : base("Ryzen")
        {
        }
    }

    public class Athlon : AMD
    {
        public Athlon() : base("Athlon")
        {
        }
    }

    public class Intel : Processor
    {
        public Intel(string tipe) : base("Intel", tipe)
        {
        }

    }
    public class CoreI3 : Intel
    {
        public CoreI3() : base("CoreI3")
        {
        } 
    }

    public class CoreI5 : Intel
    {
        public CoreI5() : base("CoreI5")
        {
        }
    }

    public class CoreI7 : Intel
    {
        public CoreI7() : base("CoreI7")
        {
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            // 1.
            Laptop laptop2 = new Laptop("Lenovo", "Ideapad", new VgaAMD(), new Ryzen());
            laptop2.LaptopDinyalakan();
            laptop2.LaptopDimatikan();
            Console.WriteLine("");
            //2. 
            Laptop laptop1 = new Laptop();
            laptop1.vga = new Nvidia();
            laptop1.processor = new CoreI5();
            laptop1.Ngoding();  
            //3.
            Console.WriteLine("");
            Laptop laptop1 = new Laptop("ASUS", "VivoBook", new Nvidia(), new CoreI7());
            Console.WriteLine($"Merk VGA: {laptop1.Vga.Merk}");
            Console.WriteLine($"Merk Processor: {laptop1.Processor.Merk}");
            Console.WriteLine($"Tipe Processor: {laptop1.Processor.Tipe}");
            //4. 
            Console.WriteLine("");
            Predator predator = new Predator
            predator.Vga = new Nvidia();
            predator.processor = new Ryzen();

            predator.BermainGame();
            //5.
            Console.WriteLine("");
            ACER acer = new Predator();
            acer.BermainGame();

            
        }
    }
}

