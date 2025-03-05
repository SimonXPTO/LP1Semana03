using System;

namespace HeroPerk
{
    [Flags]
    enum Perks
    {
        None = 0,
        WarpShift = 1 << 0,
        Stealth = 1 << 1,
        AutoHeal = 1 << 2,
        DoubleJump = 1 << 3
    }
    public class Perk
    {
        private static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("!No perks at all!");
                return;
            }
            string arg=args[0];
            int W = 0, D= 0, S= 0, A= 0;
            Perks perk = Perks.None;

            foreach (char c in arg)
            {
                switch (c)
                {
                    case 'w': W++; break;
                    case 'a': A++; break;
                    case 's': S++; break;
                    case 'd': D++; break;
                    default:
                        Console.WriteLine("!Unknown perk!");
                        return;
                }

                
            }
            if (W % 2 == 1 ) perk |= Perks.WarpShift;
            if (A % 2 == 1 ) perk |= Perks.AutoHeal;
            if (S % 2 == 1 ) perk |= Perks.Stealth;
            if (D % 2 == 1 ) perk |= Perks.DoubleJump;
            
            if (perk == Perks.None)
            {
                Console.WriteLine("!No perks at all!");
                return;
            }

            if (perk != Perks.None)
            {
                Console.WriteLine($"{perk}");
            }

            if (perk.HasFlag(Perks.Stealth) && perk.HasFlag(Perks.DoubleJump))
            {
                Console.WriteLine("!Silent jumper!");
            }
            
            if (!perk.HasFlag(Perks.AutoHeal))
            {
                Console.WriteLine("!Not gonna make it!");
            }

        }
    }
}
