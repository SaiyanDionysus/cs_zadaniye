using System;

class Phone
{
    private string number;
    private string model;
    private double weight;


    public Phone(string number, string model, double weight)
    {
        this.number = number;
        this.model = model;
        this.weight = weight;
    }

    public Phone(string number, string model)
    {
        this.number = number;
        this.model = model;
    }

    public Phone()
    {
        this.number = "Нет номера";
        this.model = "Нет модели";
        this.weight = 0;
    }

    public void receiveCall(string callerName)
    {
        Console.WriteLine($"Звонит {callerName}");

    }

    public string getNumber()
    {
        return number;
    }

    public void receiveCall(string callerName, string callerNumber)
    {
        Console.WriteLine($"Звонит {callerName}, номер телефона {callerNumber}");
    }

    public void sendMessage(params string[] phoneNumbers)
    {
        Console.WriteLine("Отправка сообщений на следующие номера: ");
        foreach(string number in phoneNumbers)
        {
            Console.WriteLine(number);
        }
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Модель: {model}");
        Console.WriteLine($"Номер: {number}");
        Console.WriteLine($"Модель: {weight}");
    }
}

class Program
{
    static void Main()
    {
        Phone phone1 = new Phone("123-456-789", "iPhone", 200);
        Phone phone2 = new Phone("987-654-321", "Xiaomi", 400);
        Phone phone3 = new Phone();

        Console.WriteLine("Информация о телефонах: ");
        Console.WriteLine("Телефон 1: ");
        phone1.DisplayInfo();
        Console.WriteLine("Телефон 2: ");
        phone2.DisplayInfo();
        Console.WriteLine("Телефон 2: ");
        phone3.DisplayInfo();

        Console.WriteLine("\nЗвонки:");
        phone1.receiveCall("Андрей");
        phone2.receiveCall("Евген");
        phone3.receiveCall("Дима");

        Console.WriteLine("\nНомер первого телефона: " + phone1.getNumber());

        phone1.receiveCall("Иван", "+123-456-789");
        phone2.receiveCall("Мария", "+987-654-321");

        Console.WriteLine("\nОтправка сообщений: ");
        phone1.sendMessage("+111-333-444", "+444-543-431");
        phone2.sendMessage("+934-343-423");
    }
}


