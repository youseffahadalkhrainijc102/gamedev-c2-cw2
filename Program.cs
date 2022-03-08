// See https://aka.ms/new-console-template for more information

namespace c2_cw2
{

    class Program
    {
        
            
        
        static void Main(string[] args)
        {

            string Herosname = "yoda";
            string enemy = "vader";
            int age = 1200;
            int enemyage = 1000;
            string superpower1 = "superjump";
            string superpower2 = "flight";



            ageDiffrence(age, enemyage);
            void ageDiffrence(int age , int enemyage) {

                if (age > enemyage)
                {

                    Console.WriteLine(Herosname + "is older than" + enemy);

                }
                else if (age < enemyage)
                {

                    Console.WriteLine(enemy + "is younger than" + Herosname);


                }
        }

        }

    }



}