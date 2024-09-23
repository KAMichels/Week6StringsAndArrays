

using System;

string userName = "Kirsten";

Console.WriteLine(userName.Length);
Console.WriteLine($"The first letter in your name is {userName[userName.Length-1]}");

//Console.WriteLine(userName[0]);
//Console.WriteLine(userName[1]);
//Console.WriteLine(userName[2]); 
//Console.WriteLine(userName[3]);
//Console.WriteLine(userName[4]);
//Console.WriteLine(userName[5]);
//Console.WriteLine(userName[6]);

//n-counter

//int counter = 0;

//for (int i = 0; i < userName.Length; i++)
//{
//    if(userName[i] == 'n')
//    {
//        counter++; //counter = counter + 1
//    }
//}

//Console.WriteLine($"Your name has {counter} n-letter.");

//replace
//n - 4

string updatedUserName = userName.Replace('n', '6').Replace('i','2');
Console.WriteLine(updatedUserName);