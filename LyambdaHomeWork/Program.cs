using System;

namespace LyambdaHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            var button = new Button
            {
                Length = 15,
                Height = 6,
                Text = "Welcome",
                
            };

            button.PrintButton();

            button.ButtonAction += Console.WriteLine;

            button.ButtonAction += data => Console.WriteLine(data);

            button.Exec(2);
            button.Exec("Name");
            button.Exec(2.2);
        }
    }
}
