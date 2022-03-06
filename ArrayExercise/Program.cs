/*Simple Application to store student details in class
 * Which can perform View delete and insert operations
 */

namespace ArrayExercise
{
    class ArrayExercice
    {
        public static void Main(String[] args)
        {
            List<student> students = new List<student>();
            students.Add(new student { Student_id=1,Student_Name="Shreesh",Student_Description="10CGPA"});
            students.Add(new student { Student_id = 2, Student_Name = "Keshi", Student_Description = "09CGPA" });
            students.Add(new student { Student_id = 3, Student_Name = "Parthiv", Student_Description = "08CGPA" });

            bool cond = true;

            while (cond)
            {
                Console.WriteLine("Enter what you would like to do from the below options" +
                    "\nCreate\nView\nDelete\nQuit");
                string UserInput = Console.ReadLine().ToLower();
                if (UserInput.Equals("view"))
                {
                    int i = 1;
                    foreach (student student in students)
                    {
                        Console.WriteLine($"{i})Name of the Student is {student.Student_Name}\n Id of the student is {student.Student_id}" +
                            $"\n Description of the student is {student.Student_Description}");
                        i++;
                    }
                }
                else if (UserInput.Equals("quit")) { cond = false; }
                else if (UserInput.Equals("")) 
                {
                    Console.WriteLine("Did not recive any input so quiting the App");
                    cond = false; 
                }
                else if (UserInput.Equals("create"))
                {
                    Console.WriteLine("Enter the new student ID");
                    string id_temp = Console.ReadLine();
                    int id = Convert.ToInt32(id_temp);
                    Console.WriteLine("Enter the new student Name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter new description for student");
                    string des = Console.ReadLine();
                    Console.WriteLine($"Adding the Student {name} to database");
                    AddStudent(id, name, des, students);
                }
                else if (UserInput.Equals("delete"))
                {
                    Console.WriteLine("Enter the Student Id you want to delete");
                    string id_store = Console.ReadLine();
                    int id=Convert.ToInt32(id_store);
                    id++;
                    Console.WriteLine($"removing {id}");
                    students.RemoveAt(id);
                }
            }

            Console.ReadLine();
        }

        static void AddStudent(int studentId, string studentName, string studentDescription,List<student> lists)
        {
            lists.Add(new student { Student_id = studentId, Student_Name = studentName, Student_Description = studentDescription });
        }
    }
}