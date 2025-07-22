// using System;

// class Program
// {
//     static void Main()
//     {
//         string[][] students = new string[3][]; // Jagged array for 5 students

//         for (int i = 0; i < students.Length; i++)
//         {
//             Console.Write($"Enter number of subjects for Student {i + 1}: ");
//             int subjectCount = Convert.ToInt32(Console.ReadLine());

//             students[i] = new string[subjectCount];

//             for (int j = 0; j < subjectCount; j++)
//             {
//                 Console.Write($"Enter subject {j + 1} for Student {i + 1}: ");
//                 string? subjectInput;
//                 do
//                 {
//                     subjectInput = Console.ReadLine();
//                     if (string.IsNullOrWhiteSpace(subjectInput))
//                     {
//                         Console.WriteLine("Subject cannot be empty. Please re-enter:");
//                     }
//                 } while (string.IsNullOrWhiteSpace(subjectInput));

//                 students[i][j] = subjectInput;
//             }
//         }

//         // Display the data
//         Console.WriteLine("\n--- Students and Their Subjects ---");
//         for (int i = 0; i < students.Length; i++)
//         {
//             Console.WriteLine($"Student {i + 1} Subjects:");
//             foreach (string subject in students[i])
//             {
//                 Console.WriteLine($" - {subject}");
//             }
//         }
//     }
// }

// // using System;
// // using System.Globalization;

// // class Start
// // {
// //     static void Main()
// //     {
        
// //         //Multidimensional Array
// //         string[][] students = new string[5][];

// //         Console.WriteLine("Enter the names of 5 students:");

// //         for (int i = 0; i < students.Length; i++)
// //         {
            
// //             Console.Write($"No of subs student {i + 1} like : ");
// //             int sub_counter = Convert.ToInt32(Console.ReadLine());
// //             students[i] = new string[sub_counter];

// //             for (int j = 0; j < sub_counter; j++)
// //             {
// //                 Console.Write($"Enter {j + 1} subject for student {i + 1}");
// //             }
// //         }

// //         Console.WriteLine("\n--- Students and Their Subjects ---");
// //         for (int i = 0; i < students.Length; i++)
// //         {
// //             Console.WriteLine($"Student {i + 1} Subjects:");
// //             foreach (string subject in students[i])
// //             {
// //                 Console.WriteLine($" - {subject}");
// //             }
// //         }


// //         // //Multidimensional Array
// //         // string[,] students = new string[5, 2];

// //         // Console.WriteLine("Enter the names of 5 students:");

// //         // for (int i = 0; i < 5; i++)
// //         // {
// //         //     Console.Write($"Student {i + 1}: ");
// //         //     students[i, 0] = Console.ReadLine();
// //         //     Console.Write($"Student Age: ");
// //         //     students[i, 1] = Console.ReadLine();
// //         // }

// //         // for (int i = 0; i < 5; i++)
// //         // {
// //         //     Console.WriteLine($"Name of student{i}: " + students[i, 0]);
// //         //     Console.WriteLine($"Age of Student{i}: " + students[i, 1]);
// //         // }


// //         //Singleeee Arrayyyyy
// //         // string[] students = new string[5];

// //         // Console.WriteLine("Enter the names of 5 students:");

// //         // for (int i = 0; i < students.Length; i++)
// //         // {
// //         //     Console.Write($"Student {i + 1}: ");
// //         //     students[i] = Console.ReadLine();
// //         // }

// //         // // Display the entered names
// //         // Console.WriteLine("\nThe entered student names are:");
// //         // foreach (string name in students)
// //         // {
// //         //     Console.WriteLine(name);
// //         // }
// //     }
// // }