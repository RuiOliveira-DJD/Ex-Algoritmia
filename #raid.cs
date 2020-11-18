using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raid
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            String Warrior = "Warrior";
            String Mage = "Mage";
            String Healer = "Healer";
            String Beserker = "Beserker";
            String Assassin = "Assassin";
            String Archer = "Archer";
            int WarriorContagem = 0;
            int MageContagem = 0;
            int HealerContagem = 0;
            int BeserkerContagem = 0;
            int AssassinContagem = 0;
            int ArcherContagem = 0;


            String[] classes = new String[20];



            for (int i = 0; i < classes.Length; i++)
            {

                int Randomizar = r.Next(6);
                if (Randomizar == 0) { classes[i] = Warrior; WarriorContagem += 1; }
                if (Randomizar == 1) { classes[i] = Mage; MageContagem += 1; }
                if (Randomizar == 2) { classes[i] = Healer; HealerContagem += 1; }
                if (Randomizar == 3) { classes[i] = Beserker; BeserkerContagem += 1; }
                if (Randomizar == 4) { classes[i] = Assassin; AssassinContagem += 1; }
                if (Randomizar == 5) { classes[i] = Archer; ArcherContagem += 1; }

            }

            Console.WriteLine("There are  " + WarriorContagem + " Warriors    " + MageContagem + " Mages    " + HealerContagem + " Healers    " + BeserkerContagem + " Beserkers    " + AssassinContagem + " Assassins    " + ArcherContagem + " Archers    ");
        }
    }
}
