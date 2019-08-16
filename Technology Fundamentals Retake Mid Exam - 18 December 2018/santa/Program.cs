using System;
using System.Collections.Generic;
using System.Linq;

namespace santa
{
    class Program
    {
        static void Main(string[] args)
        {
            List <string> noisyKids = Console.ReadLine().Split('&').ToList();
            string command = Console.ReadLine();
            while(command!="Finished!")
            {
                string [] comKid=command.Split().ToArray();
                if(comKid.Length==3)
                {
                    if(noisyKids.Contains(comKid[1]))
                    {
                        int index = noisyKids.IndexOf(comKid[1]);
                        noisyKids[index] = comKid[2];
                    }
                }
                    else if(comKid.Length==2)
                {
                    if(comKid[0]=="Bad")
                    { if (!noisyKids.Contains(comKid[1])) noisyKids.Insert(0, comKid[1]);       }
                    else if(comKid[0]=="Good")
                    { if (noisyKids.Contains(comKid[1])) noisyKids.Remove(comKid[1]); }
                    else if(comKid[0]=="Rearrange")
                    { if (noisyKids.Contains(comKid[1]))
                        { noisyKids.Remove(comKid[1]); noisyKids.Add(comKid[1]); }
                    }        
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",noisyKids));
        }
    }
}
