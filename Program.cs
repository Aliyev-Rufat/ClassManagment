using ConsoleApp3;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User(13, "Rufat", "111");


            while (true)
            {
                Console.WriteLine("1.Show info");
                Console.WriteLine("2.Create new group");


                switch (Console.ReadLine())
                {
                    case "1":
                        user.ShowInfo();
                        break;

                    case "2":
                        Student student = new Student();
                        break;
                }
            }


        }



    }
}
