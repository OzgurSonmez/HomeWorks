// See https://aka.ms/new-console-template for more information
/*
 * https://www.youtube.com/watch?v=MU_YQtgdkKA&list=PLqG356ExoxZVN7rC0KmMo0lvECK97VRZg&index=5
 * Yazılım Geliştirici Yetiştirme Kampı 5. Gün
 */

using _12_07_YGYK_OOP_2;

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.CustomerNo = "12345";
customer1.FirstName = "Özgür";
customer1.LastName = "Sönmez";
customer1.TcNo = "12345678910";

CoorporateCustomer customer2 = new CoorporateCustomer();
customer2.Id = 2;
customer2.CustomerNo = "54321";
customer2.CompanyName = "Kodlama.io";
customer2.TaxNo = "12345543210";

Customer customer3 = new IndividualCustomer();
Customer customer4 = new CoorporateCustomer();

CustomerManager customerManager = new CustomerManager();
customerManager.Add(customer3);
customerManager.Add(customer4);