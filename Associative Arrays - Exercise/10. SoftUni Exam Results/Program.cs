using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsPoints = new Dictionary<string,int>();
            var submissions = new Dictionary<string,int>();
            string input = string.Empty;
            while ((input=Console.ReadLine())!="exam finished")
            {
                string[] command = input.Split("-").ToArray();
                string name = command[0];
                if(command.Length==2)
                {
                    if(studentsPoints.ContainsKey(name))
                    {
                        studentsPoints.Remove(name);
                    }
                }
                else if(command.Length==3)
                {
                    string lang = command[1];
                    int points =int.Parse(command[2]);
                    if (!studentsPoints.ContainsKey(name))
                    {
                        studentsPoints[name] = points;
                        if(!submissions.ContainsKey(lang))
                        { submissions[lang] = 0;  }
                        submissions[lang]++;
                    }
                    else
                    {
                        if(studentsPoints[name]<points)
                        { studentsPoints[name] = points; }

                        if (!submissions.ContainsKey(lang))
                        { submissions[lang] = 0; }
                        submissions[lang]++;
                    }

                }
                
            }
            Console.WriteLine("Results:");

            foreach (var points in studentsPoints.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{points.Key} | {points.Value}");
            }

            Console.WriteLine("Submissions:");

            foreach (var sub in submissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key)) 
            {
                Console.WriteLine($"{sub.Key} - {sub.Value}");
            }
          
        }
    }
}
