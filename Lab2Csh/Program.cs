using System;

class OprDate
{
    enum Dayofweek
    {
        Понедельник = 1,
        Вторник,
        Среда,
        Четверг,
        Пятница,
        Суббота,
        Воскресенье
    }

    enum TimeofDay
    {
        Ночь,
        Утро,
        День,
        Вечер
    }

    static void Main()
    {
        int day;
        int time;

        while (true)
        {
            Console.Write("Введите день недели(1 - 7): ");
            if (int.TryParse(Console.ReadLine(), out day) && day >= 1 && day <= 7)
                break;
            Console.Write("Некорректный ввод. Введите число от 1 до 7.");
        }

        while (true)
        {
            Console.Write("Введите время (от 0 до 23): ");
            if (int.TryParse(Console.ReadLine(), out time) && time >= 0 && time <= 23)
                break;
            Console.Write("Некорректный ввод. Введите число от 0 до 23.");
        }
    

    TimeofDay timeofday;
        if (time >= 7 && time <= 12)
        {
            timeofday = TimeofDay.Утро;
        }
        else if (time >= 13 && time <= 18)
        {
            timeofday = TimeofDay.День;
        }
        else if (time >= 19 && time <= 23)
        {
            timeofday = TimeofDay.Вечер;
        }
        else
        {
            timeofday = TimeofDay.Ночь;
        }
        Console.WriteLine("____________________________________________________");
        Console.WriteLine($"Сейчас {Enum.GetName(typeof(Dayofweek),day)}, {time} час(а/ов), время суток: {timeofday}");
        Console.WriteLine("____________________________________________________");
    }
}