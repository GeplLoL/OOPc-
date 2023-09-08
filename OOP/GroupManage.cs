using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using static Group;

public class GroupManager
{
    public static void ManageGroup()
    {
        Random rndArv = new Random();
        int mutu = rndArv.Next(2, 6);
        Console.WriteLine(mutu);
        Group group = new Group(mutu);
        string nameRL = "";
        string nameRnd = "";
        int age1 = 0;
        Group bookClub = new Group(mutu);
        Group AnimeClub = new Group(mutu);
        Group SportClub = new Group(mutu);
        string fullGroup = "";
        int j = 0;
        for (int i = 0; i < mutu; i++)
        {
            int Rnb = rndArv.Next(0, 3);
            int num = rndArv.Next(0, 5);
            switch (num)
            {
                case 0:
                    nameRnd = "Deniss";
                    break;
                case 1:
                    nameRnd = "Roma";
                    break;
                case 2:
                    nameRnd = "Kirill";
                    break;
                case 3:
                    nameRnd = "Aleksander";
                    break;
                case 4:
                    nameRnd = "Oleg";
                    break;
                case 5:
                    nameRnd = "Martin";
                    break;
            }
            int num1 = rndArv.Next(0, 5);
            switch (num1)
            {
                case 0:
                    nameRL = "Gorjunov";
                    break;
                case 1:
                    nameRL = "Kulo4enko";
                    break;
                case 2:
                    nameRL = "Obromovitch";
                    break;
                case 3:
                    nameRL = "Miteev";
                    break;
                case 4:
                    nameRL = "Kaluzkii";
                    break;
                case 5:
                    nameRL = "Orkestrov";
                    break;
            }
            age1 = rndArv.Next(5, 100);
            j = i;
            inimene man = new inimene(nameRnd, nameRL, age1);

            Console.WriteLine("Kui soovite täitmise lõpetada, vаjutage 'y' or no");
            string ans = Console.ReadLine();
            if (ans == "y")
            {
                char theKey = Console.ReadKey(true).KeyChar;
                if (theKey == 'y' || theKey == 'Y' || ans =="y" || ans =="Y")
                {
                    
                    Console.WriteLine(string.Join(", ", group.liiked));
                    break;
                }
            }
            if (group.AddMember(nameRnd, nameRL, age1) == true)
            {
                group.AddMember(nameRnd, nameRL, age1);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Andmed lisanud: " + nameRnd + " " + nameRL + " " + age1);
                Console.ForegroundColor = ConsoleColor.Gray;
                if (Rnb==1)
                {
                    bookClub.AddMember(nameRnd, nameRL, age1);
                }
                else if (Rnb==2)
                {
                    AnimeClub.AddMember(nameRnd, nameRL, age1);
                }
                else
                {
                    SportClub.AddMember(nameRnd, nameRL, age1);
                }
            }
            else if (group.AddMember(nameRnd, nameRL, age1) == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Andmed ei õige: " + nameRnd + " " + nameRL + " " + age1);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            if (i+1 == mutu)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(fullGroup = "GROUP FULL");
                Console.ForegroundColor = ConsoleColor.Gray;
                break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(fullGroup = "GROUP not FULL");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
        if (fullGroup == "GROUP not FULL")
        {
            Console.WriteLine("Kui palju te tahate lisamine: ");
            int ansi = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < mutu - j; i++)
            {
                int Rnb = rndArv.Next(0, 3);
                int num = rndArv.Next(0, 5);
                switch (num)
                {
                    case 0:
                        nameRnd = "Deniss";
                        break;
                    case 1:
                        nameRnd = "Roma";
                        break;
                    case 2:
                        nameRnd = "Kirill";
                        break;
                    case 3:
                        nameRnd = "Aleksander";
                        break;
                    case 4:
                        nameRnd = "Oleg";
                        break;
                    case 5:
                        nameRnd = "Martin";
                        break;
                }
                int num1 = rndArv.Next(0, 5);
                switch (num1)
                {
                    case 0:
                        nameRL = "Gorjunov";
                        break;
                    case 1:
                        nameRL = "Kulo4enko";
                        break;
                    case 2:
                        nameRL = "Obromovitch";
                        break;
                    case 3:
                        nameRL = "Miteev";
                        break;
                    case 4:
                        nameRL = "Kaluzkii";
                        break;
                    case 5:
                        nameRL = "Orkestrov";
                        break;
                }
                age1 = rndArv.Next(5, 100);
                inimene man = new inimene(nameRnd, nameRL, age1);
                if (group.AddMember(nameRnd, nameRL, age1) == true)
                {
                    group.AddMember(nameRnd, nameRL, age1);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Andmed lisanud: " + nameRnd + " " + nameRL + " " + age1);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    if (Rnb == 1)
                    {
                        bookClub.AddMember(nameRnd, nameRL, age1);
                    }
                    else if (Rnb == 2)
                    {
                        AnimeClub.AddMember(nameRnd, nameRL, age1);
                    }
                    else
                    {
                        SportClub.AddMember(nameRnd, nameRL, age1);
                    }
                }
                else if (group.AddMember(nameRnd, nameRL, age1) == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Andmed ei õige: " + nameRnd + " " + nameRL + " " + age1);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                if (mutu== i + j + 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("GROUP FULL");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(i == mutu - j);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("GROUP not FULL");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
        }
        else
        {
            Console.WriteLine("Andmed: ");
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("All: "+" "+ group.GetMembersCount());
        Console.WriteLine(string.Join(", ", group.liiked));
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(" ");
        Console.WriteLine("Book club");
        Console.WriteLine(string.Join(", ", bookClub.liiked));
        Console.WriteLine("Book club "+" "+ "arve: "+" "+bookClub.GetMembersCount());
        Console.WriteLine(" ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Sport club");
        Console.WriteLine(string.Join(", ", SportClub.liiked));
        Console.WriteLine("Sport club "+" "+"arve: "+" "+ SportClub.GetMembersCount());
        Console.WriteLine(" ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Anime club");
        Console.WriteLine(string.Join(", ", AnimeClub.liiked));
        Console.WriteLine("Anime club " + " "+"arve: "+" "+ AnimeClub.GetMembersCount());
    }
}
