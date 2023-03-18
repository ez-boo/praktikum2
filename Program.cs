static void Main(string [] args){}

            Console.Title = "calculator application";

            int a = 10; //deklarasi variable
            int b = 6;

            Console.WriteLine("hasil penambahan " + a + " + " + b + " = " + penambahan (a,b));
            Console.WriteLine("hasil pengurangan {0} - {1} = {2}", a, b, pengurangan (a, b));
            Console.WriteLine("hasil perkalian {0} * {1} = {2}", a, b, perkalian(a, b));
            Console.WriteLine("hasil pembagian {0} / {1} = {2}", a, b, perkalian(a, b));

            Console.WriteLine("\n Tekan sembarang key untuk keluar");
            Console.ReadKey();
        
        static int penambahan (int a, int b){
            return a + b;
        }
         static int pengurangan (int a, int b){
            return a - b; 
        }
         static int perkalian (int a, int b){
            return a * b; 
        }
         static int pembagian (int a, int b){
            return a / b; 
        }
    

