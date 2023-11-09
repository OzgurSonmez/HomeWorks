// See https://aka.ms/new-console-template for more information

/*
 *  https://www.youtube.com/watch?v=1j68gb1-qOw&list=PLqG356ExoxZVN7rC0KmMo0lvECK97VRZg&index=3 
 *  Yazılım Geliştirici Yetiştirme Kampı 3. Gün C# Temelleri 2
 */

//int, decimal, float, double, bool => Value Type
//array, class, interface => Reference Type

int number1 = 10;
int number2 = 30;
number1 = number2;  
number2 = 65;
Console.WriteLine(number1);

int[] numbers1 = new int[] { 10, 20, 30 };
int[] numbers2 = new int[] { 100, 200, 300 };
numbers1 = numbers2;
numbers2[0] = 999;
Console.WriteLine(numbers1[0]);
