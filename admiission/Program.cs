namespace admiission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter physics marks");
            int physics;
            physics = int.Parse(Console.ReadLine());
             
            if (physics >= 55)
            {
                Console.WriteLine("enter maths marks");
                int maths;
                maths = int.Parse(Console.ReadLine());
                if (maths >= 68)
                {
                    Console.WriteLine("enter chemistry marks");
                    int chemistry;
                    chemistry = int.Parse(Console.ReadLine());

                    if (chemistry >= 50)
                    {
                        int total;
                        total = maths + chemistry + physics;
                        if (total >= 180)
                        {
                            Console.WriteLine("You have qualified for the course , you ccan now apply through our website");
                        }
                    }
                    else
                    {
                        Console.WriteLine("chemistry kept you out sorry ...");
                    }

                }
                else
                {
                    Console.WriteLine("maths kept you out...oops");
                }

            }
            else
            {
                Console.WriteLine("Physics kept you out ...sorry");
            }
        
        }
    }
}
