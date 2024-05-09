using System;
using System.Security.Cryptography.X509Certificates;

// add a menu and user can choice the scripture that he want to memorize


class Program
{
    static void Main(string[] args)
    {
        string text = "";
        string _reference = "";
        string book = "";
        int chapter = 0;
        int verse = 0;
    
        Console.WriteLine("Choise one scripture to Memorize:\n [1] 1 Nephi 3:7\n [2] Moroni 10:3-4]\n [3] Jacob 3:2");
        string input = Console.ReadLine();

        if(input == "1")
        {
            book = "Nephi";
            chapter = 3;
            verse = 7;
            text = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no bcommandments unto the children of men, save he shall cprepare a way for them that they may accomplish the thing which he commandeth them.";


        }
        else if(input == "2")
        {

            book = "Moroni";
            chapter = 10;
            verse = 3;
            text = "Behold, I would exhort you that when ye shall read these things, if it be wisdom in God that ye should read them, that ye would remember how amerciful the Lord hath been unto the children of men, from the creation of Adam even down until the time that ye shall receive these things, and bponder it in your chearts.";

        }
        
        else if(input == "3")
        {
            book = "Jacob";
            chapter = 3;
            verse = 2;
            text = "O all ye that are pure in heart, lift up your heads and receive the pleasing word of God, and feast upon his alove; for ye may, if your bminds are cfirm, forever.";

        }
    
        
        Reference r = new Reference(book, chapter, verse);
         _reference = r.GetDisplayText();
        
        Scripture scripture = new Scripture(r, text);


        Console.WriteLine(_reference);
        Console.WriteLine(scripture.HideGetDisplayText());

        Console.WriteLine("\nPressione 'Enter' para continuar ou digite 'quit' para sair:");
        input = Console.ReadLine();
        Console.Clear();

        while (input.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            Random random = new Random();

            scripture.HideRandomWords(random.Next(7));
            Console.WriteLine(_reference);

            Console.WriteLine(scripture.HideGetDisplayText());
            input = Console.ReadLine();
            
            Console.WriteLine("\nPressione 'Enter' para continuar ou digite 'quit' para sair:");
            Console.Clear();

        }

        if (scripture.IsCompletelyHidden())
        {
            Console.WriteLine("Parabéns! Você completou o jogo de memorização.");
        }
    }
}