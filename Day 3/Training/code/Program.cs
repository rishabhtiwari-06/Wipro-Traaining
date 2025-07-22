// using System;
// class Start
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter number of coupon redeemed: ");
//         int coupon_number = Convert.ToInt32(Console.ReadLine());
//         int[] arr = new int[coupon_number];
//         int total_val = 0;
//         int highest_val = int.MinValue;
//         int highest_pos = -1;

//         int small = 0;
//         int medium = 0;
//         int high = 0;



//         Console.WriteLine("Enter Prices of coupon redeemed: ");
//         for (int i = 0; i < coupon_number; i++)
//         {
//             Console.Write($"Element {i + 1}: ");
//             arr[i] = Convert.ToInt32(Console.ReadLine());

//             total_val += arr[i];

//             if (arr[i] > highest_val)
//             {
//                 highest_val = arr[i];
//                 highest_pos = i + 1;
//             }

//             if (arr[i] <= 20)
//             {
//                 small++;
//             }
//             else if (arr[i] <= 50)
//             {
//                 medium++;
//             }
//             else
//             {
//                 high++;
//             }
//         }

//         Console.WriteLine("\n--- Coupon Summary ---");
//         Console.WriteLine($"Total coupons redeemed: {coupon_number}");
//         Console.WriteLine($"Total rupee value: ₹{total_val}");
//         Console.WriteLine($"Highest value coupon: ₹{highest_val} (Position: {highest_pos})");
//         Console.WriteLine("\n--- Category Report ---");
//         Console.WriteLine($"Small (≤ 20): {small}");
//         Console.WriteLine($"Medium (20 - 50): {medium}");
//         Console.WriteLine($"Large (> 50): {high}");
//     }
// }