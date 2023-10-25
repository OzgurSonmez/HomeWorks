﻿
IWorker[] workers = new IWorker[3]
    {
        new Manager(),
        new Worker(),
        new Robot()
    };
foreach (var worker in workers)
{
    worker.Work();
}

IEat[] eats = new IEat[2]
    {
        new Manager(),
        new Worker()
    };
foreach(var eat in eats)
{
    eat.Eat();
}


interface IWorker
{
    void Work();
}

interface IEat
{
    void Eat();
}

interface ISalary
{
    void GetSalary();
}

class Manager : IWorker, IEat, ISalary
{
    public void Eat()
    {
        Console.WriteLine("Manager Eating...");
    }

    public void GetSalary()
    {
        Console.WriteLine("Manager GetSalary...");
    }

    public void Work()
    {
        Console.WriteLine("Manager Working...");
    }
}

class Worker : IWorker, IEat, ISalary
{
    public void Eat()
    {
        Console.WriteLine("Worker Eating...");
    }

    public void GetSalary()
    {
        Console.WriteLine("Worker Getsalary...");
    }

    public void Work()
    {
        Console.WriteLine("Worker Working...");
    }
}

class Robot : IWorker
{
    public void Work()
    {
        Console.WriteLine("Robot Working...");
    }
}