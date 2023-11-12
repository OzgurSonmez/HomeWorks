
using _07_Classes;

CustomerManager customerManager = new CustomerManager();
customerManager.Add();
customerManager.Update();

ProductManager productManager = new ProductManager();
productManager.Add();
productManager.Update();

Customer customer = new Customer();
customer.City = "Sinop";
customer.Id = 1;
customer.FirstName = "Özgür";
customer.LastName = "Sönmez";

Customer customer2 = new Customer
{
    City = "İstanbul",
    Id = 2,
    FirstName = "Burak",
    LastName = "Pehlivan"
};

Console.WriteLine(customer.FirstName);


