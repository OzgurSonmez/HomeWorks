// See https://aka.ms/new-console-template for more information
/*
 * https://www.youtube.com/watch?v=G0sOB_-WkyI&list=PLqG356ExoxZVN7rC0KmMo0lvECK97VRZg&index=4
 * Yazılım Geliştirici Yetiştirme Kampı 4. Gün
 */

using System.Collections.Generic;

//string[] names = new string[] { "Engin", "Murat", "Kerem", "Halil" };
//Console.WriteLine(names[0]);
//Console.WriteLine(names[1]);
//Console.WriteLine(names[2]);
//Console.WriteLine(names[3]);

//names = new string[5];
//names[4] = "Özgür";
//Console.WriteLine(names[4]);
//Console.WriteLine(names[0]);

List<string> names2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
Console.WriteLine(names2[0]);
Console.WriteLine(names2[1]);
Console.WriteLine(names2[2]);
Console.WriteLine(names2[3]);
names2.Add("Özgür");
Console.WriteLine(names2[4]);
Console.WriteLine(names2[0]);