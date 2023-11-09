// See https://aka.ms/new-console-template for more information
/*
 * https://www.youtube.com/watch?v=G0sOB_-WkyI&list=PLqG356ExoxZVN7rC0KmMo0lvECK97VRZg&index=4
 * Yazılım Geliştirici Yetiştirme Kampı 4. Gün
 */

using _12_06_YGYK_Generics_Intro;

MyList<string> names = new MyList<string>();
names.Add("Özgür");
names.Add("Engin");
names.Add("Burak");
names.Add("Çağrı");
names.Add("Tufan");

foreach (var name in names.Items)
{
    Console.WriteLine(name);
}

