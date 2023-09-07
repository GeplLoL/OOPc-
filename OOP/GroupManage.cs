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
        Random rndage = new Random();
        int t = 1 * rndage.Next(0, 100);
        Console.WriteLine("Kui palju inimesed group: ");
        int mutu = Convert.ToInt32(Console.ReadLine());
        Group group = new Group(mutu);
        string nameRL = "";
        string nameRnd = "";
        int age1 = 0;
        Random rndB = new Random();
        Group bookClub = new Group(mutu);
        Group AnimeClub = new Group(mutu);
        Group SportClub = new Group(mutu);
        for (int i = 0; i < mutu; i++)
        {
            int Rnb = rndB.Next(0, 3);
            Random rndPN = new Random();
            int num = rndPN.Next(0, 5);
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
            Random rndPL = new Random();
            int num1 = rndPL.Next(0, 5);
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
            Random rndPA = new Random();
            age1 = rndPL.Next(5, 100);

            chel man = new chel(nameRnd, nameRL, age1);

            Console.WriteLine("Kui soovite täitmise lõpetada, vаjutage 'y' or no");
            string ans = Console.ReadLine();
            if (ans == "y")
            {
                char theKey = Console.ReadKey(true).KeyChar;
                if (theKey == 'y' || theKey == 'Y' || ans =="y" || ans =="Y")
                {
                    i = mutu;
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
        }
        Console.WriteLine("All");
        Console.WriteLine(string.Join(", ", group.liiked));
        Console.WriteLine(group.GetMembersCount());
        Console.WriteLine("Book club");
        Console.WriteLine(string.Join(", ", bookClub.liiked));
        Console.WriteLine("arve: ");
        Console.WriteLine(bookClub.GetMembersCount());
        Console.WriteLine("Sport club");
        Console.WriteLine(string.Join(", ", SportClub.liiked));
        Console.WriteLine("arve: ");
        Console.WriteLine(SportClub.GetMembersCount());
        Console.WriteLine("Anime club");
        Console.WriteLine(string.Join(", ", AnimeClub.liiked));
        Console.WriteLine("arve: ");
        Console.WriteLine(AnimeClub.GetMembersCount());

    }
}