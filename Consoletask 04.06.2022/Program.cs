using Consoletask_04._06._2022.Helpers;
using System;

namespace Consoletask_04._06._2022
{
    class Program
    {
        static void Main(string[] args)
        {

            Department dep = new Department();
            Helper.Printer("Department ad teyin edin : ", ConsoleColor.Blue);
                string depname = Console.ReadLine();
            dep.Name = depname;
            string res = "";
            Helper.Printer("Ishci sayini teyin edin : ", ConsoleColor.Blue);
        Iscount:
            string cou = Console.ReadLine();
        
            bool isCount = int.TryParse(cou, out int limit);
            if (!isCount)
            {
                Helper.Printer("Duzgun say daxil edin : ", ConsoleColor.Red);
                goto Iscount;
            }
            dep.EmployeeLimit = limit;
            Helper.Printer("Budceni teyin edin : ", ConsoleColor.Blue);
        Budge:
            string budg = Console.ReadLine();
            bool IsBud = int.TryParse(budg, out int budget);
            if (!IsBud)
            {
                Helper.Printer("Budceni duzgun daxil edin : ", ConsoleColor.Red);
                goto Budge;
            }
            dep.Budget = budget;
            Helper.Printer("Ischinin min tecrubesini daxil edin  :", ConsoleColor.Blue);
        Exper:
            string exp = Console.ReadLine();
            bool Isexp = int.TryParse(exp, out int experience);
            if (!Isexp)
            {
                Helper.Printer(" Duzgun daxil edin : ", ConsoleColor.Red);
                goto Exper;
            }
            dep.RequiredExperience = experience;

            Helper.Printer("Departmentin iscileri ucun ali tehsil vacibdir mi ?  yes or no : ", ConsoleColor.Blue);
        Cavab:
            string answer = Console.ReadLine();
            if (answer != "yes" && answer != "no")
            {
                Helper.Printer("Duzgun cavab daxil edin : ", ConsoleColor.Red);
                goto Cavab;
            }
            else if (answer == "yes")
            {
                dep.IsBachelorDegreeRequired = true;
            }
            else
            {
                dep.IsBachelorDegreeRequired = false;
            }

            do
                {
                Helper.Printer("Ishci elave etmek isteyirsiniz ? :", ConsoleColor.Yellow);
                 res = Console.ReadLine();

                //Helper.Printer("Ishci sayini teyin edin : ", ConsoleColor.Blue);
                //string cou = Console.ReadLine();
                //Iscount:
                //    bool isCount = int.TryParse(cou, out int limit);
                //    if (!isCount)
                //    {
                //        Helper.Printer("Duzgun say daxil edin : ", ConsoleColor.Red);
                //        goto Iscount;
                //    }
                //    dep.EmployeeLimit = limit;
                //    Helper.Printer("Budceni teyin edin : ", ConsoleColor.Blue);
                //Budge:
                //    string budg = Console.ReadLine();
                //    bool IsBud = int.TryParse(budg, out int budget);
                //    if (!IsBud)
                //    {
                //        Helper.Printer("Budceni duzgun daxil edin : ", ConsoleColor.Red);
                //        goto Budge;
                //    }
                //    dep.Budget = budget;
                //    Helper.Printer("Ischinin min tecrubesini daxil edin  :", ConsoleColor.Blue);
                //Exper:
                //    string exp = Console.ReadLine();
                //    bool Isexp = int.TryParse(exp, out int experience);
                //    if (!Isexp)
                //    {
                //        Helper.Printer(" Duzgun daxil edin : ", ConsoleColor.Red);
                //        goto Exper;
                //    }
                //    dep.RequiredExperience = experience;

                //    Helper.Printer("Departmentin iscileri ucun ali tehsil vacibdir mi ?  yes or no : ", ConsoleColor.Blue);
                //Cavab:
                //    string answer = Console.ReadLine();
                //    if (answer != "yes" && answer != "no")
                //    {
                //        Helper.Printer("Duzgun cavab daxil edin : ", ConsoleColor.Red);
                //        goto Cavab;
                //    }
                //    else if (answer == "yes")
                //    {
                //        dep.IsBachelorDegreeRequired = true;
                //    }
                //    else
                //    {
                //        dep.IsBachelorDegreeRequired = false;
                //    }

                    Employee emplo = new Employee();
                    Helper.Printer("Ishcinin adini daxil edin : ", ConsoleColor.Green);
                    string name = Console.ReadLine();
                    emplo.Name = name;
                    Helper.Printer("Ishcinin soyadini daxil edin : ", ConsoleColor.Green);
                    string surna = Console.ReadLine();
                    emplo.Surname = surna;
                    Helper.Printer("Ishcinin emek haqqisin daxil edin : ", ConsoleColor.Green);
                Salar:
                    string sal = Console.ReadLine();
                    bool Issal = int.TryParse(sal, out int salar);
                    if (!Issal)
                    {
                        Helper.Printer("Duzgun emek haqqi daxil edin :", ConsoleColor.Red);
                        goto Salar;
                    }
                    emplo.Salary = salar;
                    Helper.Printer("Ishcinin ish tecrubesini elave edin : ", ConsoleColor.Green);
                Experi:
                    string ex = Console.ReadLine();
                    bool Isxp = int.TryParse(ex, out int exper);
                    if (!Isxp)
                    {
                        Helper.Printer("Duzgun daxil edin : ", ConsoleColor.Red);
                        goto Experi;
                    }
                    emplo.Experience = exper;
                    Helper.Printer("ishcini ali tehsili var ?  yes or no ", ConsoleColor.Green);
                    string teh = Console.ReadLine();
                    if (teh == "yes")
                    {
                        emplo.HasBachelorDegree = true;
                    }
                    else if (teh == "no")
                    {
                        emplo.HasBachelorDegree = false;
                    }
                    else
                    {
                        Helper.Printer("Duzgun daxil edin :", ConsoleColor.Red);
                    }
                }
                while (res == "yes");
            
            dep.AvarageSalary();
          
        }
    }
}
