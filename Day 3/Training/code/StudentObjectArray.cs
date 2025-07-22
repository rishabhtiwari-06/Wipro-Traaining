// using System;
// using StudentProgram;
// class StudentObject
// {
//     static void Main()
//     {
//         int student_count = 3;
//         Student[] students = new Student[student_count];
//         for (int i = 0; i < student_count; i++)
//         {
//             students[i] = new Student();
//             Console.WriteLine("Enter student details: ");
//             students[i].Name = Console.ReadLine();
//             students[i].Age = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine("Enter Number of subjects: ");
//             int sub_number = Convert.ToInt32(Console.ReadLine());
//             students[i].SubjectMarks = new int[sub_number];

//             for (int j = 0; j < sub_number; j++)
//             {
//                 Console.Write($"Enter marks for subject {j + 1}: ");
//                 students[i].SubjectMarks[j] = Convert.ToInt32(Console.ReadLine());
//             }
//         }
//         Console.WriteLine("\n--- Student Details ---");
//         for (int i = 0; i < student_count; i++)
//         {
//             Console.WriteLine($"\nStudent {i + 1}:");
//             Console.WriteLine($"Name: {students[i].Name}");
//             Console.WriteLine($"Age: {students[i].Age}");
//             Console.WriteLine("Subject Marks:");
//             for (int j = 0; j < students[i].SubjectMarks.Length; j++)
//             {
//                 Console.WriteLine($"  Subject {j + 1}: {students[i].SubjectMarks[j]}");
//             }
//         }
        
//     }
// }