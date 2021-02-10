using System;
using System.Collections.Generic;
using System.Text;

namespace LyambdaHomeWork
{
    public delegate void RunAnyPara(object obj);

    public class Button
    {
        public event Action<object> ButtonAction;

        public int Length { get; set; }
        public int Height { get; set; }
        public string Text { get; set; }

        public RunAnyPara Exec { get; set; }

        public void PrintButton()
        {
            if (Length < Text.Length)
            {
                Length = Text.Length + 2;
            }
            bool IsWrite = false;
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    if ((j == 0 || j == Length - 1) && i != 0)
                    {
                        Console.Write("|");
                    }
                    else if (i == 0 || i == Height - 1)
                    {
                        Console.Write("_");
                    }
                    else if (i == Height / 2 && IsWrite == false && j == ((Length - Text.Length) / 2))
                    {
                        Console.Write(Text);
                        IsWrite = true;
                        j = ((Length - Text.Length) / 2) + Text.Length - 1;
                    }
                    else
                    {
                        if (i != Height / 2)
                        {
                            Console.Write(" ");
                        }
                        else if (i == Height / 2 && j != ((Length - Text.Length) / 2))
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.Write("\n");
            }
        }

        public void Run()
        {
            ButtonAction?.Invoke($"Object complete");
        }
    }
}
