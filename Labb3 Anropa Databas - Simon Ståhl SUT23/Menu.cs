using Labb3_Anropa_Databas___Simon_Ståhl_SUT23.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3_Anropa_Databas___Simon_Ståhl_SUT23
{

    internal class Menu
    {

        public static void MenuStart()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("DBSchool Menu");
                Console.WriteLine("1. Show all students");
                Console.WriteLine("2. Show specific Class");
                Console.WriteLine("3. Add Personel");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("You selected Option 1");
                        Menu.ShowAllStudents();
                        break;

                    case "2":
                        Console.WriteLine("You selected Option 2");
                        Menu.ShowSpecificClass();
                        break;

                    case "3":
                        Console.WriteLine("You selected Option 3");
                        Menu.AddPersonel();
                        break;

                    case "4":
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }

                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }

        public static void ShowAllStudents()
        {
            using DBSchoolDbContext context = new DBSchoolDbContext();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose how to order the Students");
                Console.WriteLine("1. First name decending");
                Console.WriteLine("2. First name acending");
                Console.WriteLine("3. Last name decending");
                Console.WriteLine("4. Last name acending");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        {
                            Console.Clear();
                            var Students = context.TblStudents.OrderByDescending(s => s.Fname).ToList();
                            Console.WriteLine("First name Decending:");
                            foreach (TblStudent s in Students)
                            {
                                Console.WriteLine($"Student ID: {s.StudentId}");
                                Console.WriteLine($"First Name: {s.Fname}");
                                Console.WriteLine($"Last Name: {s.Lname}");
                                Console.WriteLine($"Class: {s.Class}");
                                Console.WriteLine(new string('-', 20));
                            }
                        }
                        break;

                    case "2":
                        {
                            Console.Clear();
                            var Students = context.TblStudents.OrderBy(s => s.Fname).ToList();
                            Console.WriteLine("First name Acending:");
                            foreach (TblStudent s in Students)
                            {
                                Console.WriteLine($"Student ID: {s.StudentId}");
                                Console.WriteLine($"First Name: {s.Fname}");
                                Console.WriteLine($"Last Name: {s.Lname}");
                                Console.WriteLine($"Class: {s.Class}");
                                Console.WriteLine(new string('-', 20));
                            }
                        }
                        break;

                    case "3":
                        {
                            Console.Clear();
                            var Students = context.TblStudents.OrderByDescending(s => s.Lname).ToList();
                            Console.WriteLine("Last name Decending:");
                            foreach (TblStudent s in Students)
                            {
                                Console.WriteLine($"Student ID: {s.StudentId}");
                                Console.WriteLine($"First Name: {s.Fname}");
                                Console.WriteLine($"Last Name: {s.Lname}");
                                Console.WriteLine($"Class: {s.Class}");
                                Console.WriteLine(new string('-', 20));
                            }
                        }

                        break;

                    case "4":
                        {
                            Console.Clear();
                            var Students = context.TblStudents.OrderBy(s => s.Lname).ToList();
                            Console.WriteLine("Last name Acending:");
                            foreach (TblStudent s in Students)
                            {
                                Console.WriteLine($"Student ID: {s.StudentId}");
                                Console.WriteLine($"First Name: {s.Fname}");
                                Console.WriteLine($"Last Name: {s.Lname}");
                                Console.WriteLine($"Class: {s.Class}");
                                Console.WriteLine(new string('-', 20));
                            }
                        }
                        break;
                    case "5":
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }

                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();

            }



        }

        public static void ShowSpecificClass()
        {
            Console.Clear();
            using DBSchoolDbContext context = new DBSchoolDbContext();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Class List:");
                var classes = context.TblStudents.Select(s => s.Class).Distinct().ToList();
                foreach (string className in classes)
                {
                    Console.WriteLine($"Class: {className}");
                }
                Console.WriteLine(new string('*', 25));
                Console.WriteLine("Choose Students in a Class");
                Console.WriteLine("1. ITP22");
                Console.WriteLine("2. MEDS17");
                Console.WriteLine("3. SUT23");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        {
                            Console.Clear();
                            var Students = context.TblStudents.Where(s => s.Class == "ITP22");
                            Console.WriteLine("Students in ITP22");
                            foreach (TblStudent s in Students)
                            {
                                Console.WriteLine($"Student ID: {s.StudentId}");
                                Console.WriteLine($"First Name: {s.Fname}");
                                Console.WriteLine($"Last Name: {s.Lname}");
                                Console.WriteLine(new string('-', 20));
                            }
                        }
                        break;

                    case "2":
                        {
                            Console.Clear();
                            var Students = context.TblStudents.Where(s => s.Class == "MEDS17");
                            Console.WriteLine("Students in MEDS17");
                            foreach (TblStudent s in Students)
                            {
                                Console.WriteLine($"Student ID: {s.StudentId}");
                                Console.WriteLine($"First Name: {s.Fname}");
                                Console.WriteLine($"Last Name: {s.Lname}");
                                Console.WriteLine(new string('-', 20));
                            }
                        }
                        break;

                    case "3":
                        {
                            Console.Clear();
                            var Students = context.TblStudents.Where(s => s.Class == "SUT23");
                            Console.WriteLine("Students in SUT23");
                            foreach (TblStudent s in Students)
                            {
                                Console.WriteLine($"Student ID: {s.StudentId}");
                                Console.WriteLine($"First Name: {s.Fname}");
                                Console.WriteLine($"Last Name: {s.Lname}");
                                Console.WriteLine(new string('-', 20));
                            }
                        }

                        break;

                    case "4":
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }

                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();

            }
        }

        public static void AddPersonel()
        {
            Console.Clear();
            using (DBSchoolDbContext context = new DBSchoolDbContext())
            {
                Console.WriteLine("To add new Personnel, Please insert:");
                Console.WriteLine("PersonalID: ");
                int PersonalID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("First Name:");
                string FnamePersonel = Console.ReadLine();
                Console.WriteLine("Last Name:");
                string LnamePersonel = Console.ReadLine();
                Console.WriteLine("Occupation:");
                string OccupationPersonel = Console.ReadLine();

                TblPersonal personnel = new TblPersonal()
                {   PersonalId = PersonalID,
                    Fname = FnamePersonel,
                    Lname = LnamePersonel,
                    Occupation = OccupationPersonel
                };

                context.TblPersonals.Add(personnel);
                context.SaveChanges();
            }
        }
    }
}
