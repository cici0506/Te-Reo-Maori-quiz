using System;

public class Program
{
    public static void Main()
    {

        int score = 0;
        string answer1 = "";
        string answer2 = "";
        string answer3 = "";
        string answer4 = "";
        string answer5 = "";
        string answer6 = "";
        string answer7 = "";
        string answer8 = "";
        string answer9 = "";
        string answer10 = "";

        Console.Clear();
        Console.WriteLine("Welcome to my quiz user!(please type your answers in lower case letters)\nWhat is your name?\n");
        string name = Console.ReadLine();
        /* INTRODUCTION */
        Console.WriteLine("Welcome, this program is a 15 question Teo Reo Maori quiz.\n\n");

        Console.WriteLine("There are three levels, please type which level you want to do\n1. Basic\n2. Intermediate\n3. Advanced");
        string userLevel = Console.ReadLine();
        Console.WriteLine(userLevel);
        Console.Clear();
        if (userLevel == "1")
        {
            Console.WriteLine("Question 1\nWhat is song " + name + "?\na.kaiwaiata\nb.orooro\nc.waiata\n");
            answer1 = Console.ReadLine();
            Console.Clear();
            if (answer1 == "c")
            {
                score = score + 1;
                Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
            }
            else
            {
                Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");
            }
            Console.WriteLine("Question 2\nWhat is hello " + name + "?\na.kia ora\nb.ka pai\nc.morena\n");
            answer2 = Console.ReadLine();
            Console.Clear();
            if (answer2 == "a")
            {
                score = score + 1;
                Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
            }
            else
            {
                Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");
            }
        }
        Console.WriteLine("Question 3\nWhat is New Zealand " + name + "?\na.kiwi\nb.aotearoa\nc.maunga\n");
        answer3 = Console.ReadLine();
        Console.Clear();
        if (answer3 == "b")
        {
            score = score + 1;
            Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
        }
        else
        {
            Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");
        }
        Console.WriteLine("Question 4\nWhat is sea " + name + "?\na.moana\nb.wai\nc.kirikiri\n");
        answer4 = Console.ReadLine();
        Console.Clear();
        if (answer4 == "a")
        {
            score = score + 1;
            Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
        }
        else
        {
            Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");

        }
        Console.WriteLine("Question 5\nWhat is family " + name + "?\na.tuahine\nb.whanau\nc.teina\n");
        answer5 = Console.ReadLine();
        Console.Clear();
        if (answer5 == "b")
        {
            score = score + 1;
            Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
        }
        else
        {
            Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");
        }

        if (userLevel == "2")
        {
            Console.WriteLine("Question 1\nWhat is chief " + name + "?\na.tumuaki\nb.rangatira\nc.kapene\n");
            answer6 = Console.ReadLine();
            Console.Clear();
            if (answer6 == "b")
            {
                score = score + 1;
                Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
            }
            else
            {
                Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");
            }
            Console.WriteLine("Question 2\nWhat is sacred " + name + "?\na.manaakitia\nb.tapu\nc.arohaina\n");
            answer7 = Console.ReadLine();
            Console.Clear();
            if (answer7 == "a")
            {
                score = score + 1;
                Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
            }
            else
            {
                Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");
            }
        }
        Console.WriteLine("Question 3\nWhat is land " + name + "?\na.rohe\nb.whenua\nc.eka\n");
        answer8 = Console.ReadLine();
        Console.Clear();
        if (answer8 == "b")
        {
            score = score + 1;
            Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
        }
        else
        {
            Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");
        }
        Console.WriteLine("Question 4\nWhat is greenstone " + name + "?\na.kakariki\nb.kohatu\nc.pounamu\n");
        answer9 = Console.ReadLine();
        Console.Clear();
        if (answer9 == "c")
        {
            score = score + 1;
            Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
        }
        else
        {
            Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");

        }
        Console.WriteLine("Question 5\nWhat is ancestor " + name + "?\na.tupuna\nb.kaiwhakarewa\nc.kaihanga\n");
        answer10 = Console.ReadLine();
        Console.Clear();
        if (answer10 == "a")
        {
            score = score + 1;
            Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
        }
        else
        {
            Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");
        }
    }
}
