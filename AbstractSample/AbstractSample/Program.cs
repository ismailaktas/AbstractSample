using System;

namespace AbstractSample
{
    public abstract class Shoe
    {
        public double shoeNumber { get; set; }
        public string shoeMaterial { get; set; }
        public string shoeType { get; set; }

        public Shoe()
        {
            Console.WriteLine("Ben Abstract Shoe sınıfının yapıcı metoduyum");
        }

        public void setShoeType(string shoeTypeName)
        {
            this.shoeType = shoeTypeName;
        }

        public void setShoeMaterial(string shoeMaterialName)
        {
            this.shoeMaterial = shoeMaterialName;
        }

        public void setShoeNumber(double shoeNumber)
        {
            this.shoeNumber = shoeNumber;
        }

        public abstract void shoeResult();
    }

    public class SportShoe : Shoe
    {
        public override void shoeResult()
        {
            setShoeType("Spor");
            setShoeMaterial("Deri");
            setShoeNumber(42.5);

            Console.WriteLine( string.Concat(shoeNumber.ToString(), " numara ", shoeMaterial, " materyale sahip ", shoeType, " türünde ayakkabı") );
        }
    }

    public class OutdoorShoe : Shoe
    {
        public override void shoeResult()
        {
            setShoeType("Outdoor");
            setShoeMaterial("Gore-Text");
            setShoeNumber(43);

            Console.WriteLine(string.Concat(shoeNumber.ToString(), " numara ", shoeMaterial, " materyale sahip ", shoeType, " türünde ayakkabı"));
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            SportShoe spShoe = new SportShoe();
            spShoe.shoeResult();

            Console.WriteLine("--------------");

            OutdoorShoe ouShoe = new OutdoorShoe();
            ouShoe.shoeResult();
        }
    }
}
