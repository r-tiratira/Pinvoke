using System;
using System.Runtime.InteropServices;

namespace ConsoleApplication
{
    internal class Program
    {
        
        //import all NativeLibrary functions
        [DllImport("NativeLibrary.dll")] public static extern void HelloWorld();
        
        [DllImport("NativeLibrary.dll", EntryPoint = "Add")] public static extern int AddNumbers(int num1, int num2);
        
        [DllImport("NativeLibrary.dll")] public static extern bool IsLengthGreaterThan5(string value);
        
        [DllImport("NativeLibrary.dll")] [return: MarshalAs(UnmanagedType.BStr)] public static extern string GetName();
        
        [DllImport("NativeLibrary.dll")] public static extern void CreateShoe(out Shoe newShoe, double shoeSize);
        
        [DllImport("NativeLibrary.dll")] public static extern void BuyShoe(Shoe shoe);
        
        public static void Main(string[] args)
        {
            //use all NativeLibrary functions
            HelloWorld();
            
            Console.WriteLine(AddNumbers(10, 10));
            
            Console.WriteLine(IsLengthGreaterThan5("Five"));
            
            Console.WriteLine(GetName());

            Shoe newShoe;
            CreateShoe(out newShoe, 11);

            BuyShoe(newShoe);
            Console.ReadLine();
        }
    }
}
