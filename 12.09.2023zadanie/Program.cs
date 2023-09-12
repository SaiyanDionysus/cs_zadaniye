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



