using System;
using System.Collections.Generic;
using System.Linq;

namespace lab_11._1
{
    class Program
    {
        static void Main(string[] args)
        {

            AddStudent("Star Wars: A New Hope", "Sci-Fi", "   ", "   ");
            AddStudent("Star Wars: The Empire Strikes Back", "Sci Fi", "   ", "   ");
            AddStudent("Star Wars: Return of the Jedi", "Sci Fi", "    ", "   ");
            AddStudent("Star Wars: The Force Awakens", "Sci Fi", "   ", "   ");
            AddStudent("Star Wars: The Last Jedi", "Sci Fi", "   ", "   ");
            AddStudent("The Good, the Bad, and the Ugly", "Western", "    ", "   ");
            AddStudent("High Noon", "Western", "   ", "    ");
            AddStudent("Rio Bravo ", "Western", "     ", "    ");
            AddStudent("True Grit ", "Western", "    ", "    ");
            AddStudent("The Wild Bunch", "Western", "    ", "    ");
            AddStudent("CHANCES ARE", "Rom-Com", "   ", "   ");
            AddStudent("CHOCOLAT", "Rom-Com", "   ", "   ");
            AddStudent("UNDER THE TUSCAN SUN ", "Rom-Com", "    ", "   ");
            AddStudent("PRETTY WOMAN ", "Rom-Com", "   ", "   ");
            AddStudent("10 THINGS I HATE ABOUT YOU", "Rom-Com", "   ", "   ");
            AddStudent("The Bride of Frankenstein", "Horror", "    ", "   ");
            AddStudent("King Kong ", "Horror", "   ", "    ");
            AddStudent("Psycho ", "Horror", "     ", "    ");
            AddStudent("Frankenstein", "Horror", "    ", "    ");
            AddStudent("Rosemary's Baby", "Horror", "    ", "    ");
            AddStudent("The Adventures of Robin Hood ", "Action", "    ", "   ");
            AddStudent("Seven Samurai (Shichinin no Samurai)", "Action", "   ", "    ");
            AddStudent("Lawrence of Arabia", "Action", "     ", "    ");
            AddStudent("The Treasure of the Sierra Madre ", "Action", "    ", "    ");
            AddStudent("Apocalypse Now ", "Action", "    ", "    ");
            //AddStudent("Manik", "Cox's Bazaar", "Beef Curry", "Indigo");
            //AddStudent("Moise", "Grand Rapids", "Lasagna", "Violet");
            //AddStudent("Liz", "Earth", "Salmon", "Red");
            //AddStudent("Jason", "Holland", "Burgers", "Orange");
            //AddStudent("Bob", "Metro Detroit", "Burgers", "Maize and Blue");
            //AddStudentAlphabetically();
            string studentInfo = GetInput();
            Console.WriteLine(studentInfo);
            Console.ReadKey();
        }
        public static List<Student> students = new List<Student>();


        public static void AddStudent(string name, string hometown, string favfood, string favcolor)
        {
            students.Add(new Student(name, hometown, favfood, favcolor));
        }
        public static void AddStudentAlphabetically()
        {
            students = students.OrderBy(x => x.Name).ToList();
        }
        public static string GetStudent(int index)
        {
            try
            {
                return ($"Movie: {students[index].Name},  Genre: {students[index].HomeTown};"); 
                    //+
                    //$"Favorite Food: {students[index].FavoriteFood}, " +
                    //$"Favorite Color: {students[index].FavoriteColor}");
            }
            catch (IndexOutOfRangeException)
            {
                return ("Student not found, try another index");
            }
        }
        public static void StudentList()
        {
            for (int i = 0; i < students.Count; i++)
            {
                string name = students[i].Name;
                //string name1 = hometown[i].Name1;
                if (name != "")
                {
                    Console.WriteLine(i + 1 + ") " + students[i].Name);
                }
            }
        }
        public static string GetInput()
        {
            StudentList();
            Console.WriteLine("Please select index of the Movie you want to learn about.");
            string input = Console.ReadLine();
            try
            {
                int index = int.Parse(input);
                if (students[index - 1].Name == "")
                {
                    Console.WriteLine("Student not found, try another index.");
                    return GetInput();
                }
                else
                {
                    return GetStudent(index - 1);
                }
            }
            catch (FormatException)
            {
                return GetInput();
            }
        }
    }
}

