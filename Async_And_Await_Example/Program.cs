using System;

class program
{
    static void Main()
    {
        asyncAwaitdemo demo = new asyncAwaitdemo();
        demo.Dostuff();
        for(int i = 0; i < 100; i++)
        {
            Console.WriteLine("Working on the Main Thread....");
        }

    }
}
public class asyncAwaitdemo
{

    public async Task Dostuff()
    {
        //await Task.Run(() => 
        //{
        CountToFifty();

        //});

        //This will not execute until countTofifty has Completed

        Console.WriteLine("counting to 50 is completed ...");
    }
    public async Task<string> CountToFifty()
    {
        int counter;
        for(counter = 0; counter < 51; counter++)
        {
            Console.WriteLine("BG thread "+counter);
        }
    }
}