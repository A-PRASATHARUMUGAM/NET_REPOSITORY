using Practice_Program.Async_and_await;

namespace Practice_Program
{
    public class Program
    {

                            //Asynchronous programming in C#
        public static void Main(string[] args)
        {
            AsyncAwait asyncAwait = new AsyncAwait();

            Program program = new Program();

            asyncAwait.Display();


            
            //async await 1 second  during the program execution 
            program.asyncpg2();

            //using delay 5 second 
            program.asyncpg();

        }

        public void asyncpg()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);

                Task.Delay(2000).Wait();
            }
        }

        public async Task asyncpg2()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("async", i);

                    Task.Delay(1000).Wait();
                }
            });
        }
    }
}