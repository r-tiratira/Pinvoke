using System;
using System.Runtime.InteropServices;

namespace ConsoleApplication
{
    internal class Program
    {
        [DllImport("NativeLibrary.dll")]
        public static extern void HelloWorld();
        
        [DllImport("NativeLibrary.dll", EntryPoint = "Add")]
        public static extern int AddNumbers(int num1, int num2);
        
        [DllImport("NativeLibrary.dll")]
        public static extern bool IsLengthGreaterThan5(string value);
        
        [DllImport("NativeLibrary.dll")]
        [return: MarshalAs(UnmanagedType.BStr)]
        public static extern string GetName();
        
        [DllImport("NativeLibrary.dll")]
        public static extern void CreateShoe(out Shoe newShoe, double shoeSize);
        
        [DllImport("NativeLibrary.dll")]
        public static extern void BuyShoe(Shoe shoe);
        
        
        public static void Main(string[] args)
        {
            Shoe shoe = new Shoe()
            {
                id = 1,
                brand = "Nike",
                color = "Red",
                size = 11,    
            };

            Shoe newShoe;
            CreateShoe(out newShoe, 11);

            BuyShoe(newShoe);
            Console.ReadLine();
        }
    }
}