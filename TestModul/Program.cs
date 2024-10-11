using System;

public class DateTimeInput
{
    // Метод для проверки года, принимает аргумент year
    public int GetYear(int year)
    {
        if (year < 1 || year > 9999)
        {
            throw new ArgumentOutOfRangeException(nameof(year), "Год должен быть в диапазоне от 1 до 9999.");
        }
        return year;
    }

    // Метод для проверки месяца, принимает аргумент month
    public int GetMonth(int month)
    {
        if (month < 1 || month > 12)
        {
            throw new ArgumentOutOfRangeException(nameof(month), "Месяц должен быть в диапазоне от 1 до 12.");
        }
        return month;
    }

    // Метод для проверки дня, принимает аргументы year, month и day
    public int GetDay(int year, int month, int day)
    {
        int daysInMonth = DateTime.DaysInMonth(year, month);
        if (day < 1 || day > daysInMonth)
        {
            throw new ArgumentOutOfRangeException(nameof(day), $"День должен быть в диапазоне от 1 до {daysInMonth} для указанного месяца.");
        }
        return day;
    }

    // Метод для проверки часов, принимает аргумент hour
    public int GetHour(int hour)
    {
        if (hour < 0 || hour > 23)
        {
            throw new ArgumentOutOfRangeException(nameof(hour), "Часы должны быть в диапазоне от 0 до 23.");
        }
        return hour;
    }

    // Метод для проверки минут, принимает аргумент minute
    public int GetMinute(int minute)
    {
        if (minute < 0 || minute > 59)
        {
            throw new ArgumentOutOfRangeException(nameof(minute), "Минуты должны быть в диапазоне от 0 до 59.");
        }
        return minute;
    }

    // Метод для проверки секунд, принимает аргумент second
    public int GetSecond(int second)
    {
        if (second < 0 || second > 59)
        {
            throw new ArgumentOutOfRangeException(nameof(second), "Секунды должны быть в диапазоне от 0 до 59.");
        }
        return second;
    }

    // Метод для создания полного объекта DateTime через переданные параметры
    public DateTime GetFullDateTime(int year, int month, int day, int hour, int minute, int second)
    {
        return new DateTime(
            GetYear(year),
            GetMonth(month),
            GetDay(year, month, day),
            GetHour(hour),
            GetMinute(minute),
            GetSecond(second)
        );
    }
}

class Program
{
    static void Main(string[] args)
    {
        DateTimeInput input = new DateTimeInput();

        // Ввод данных через консоль с обработкой некорректного ввода
        int year = PromptForInt("Введите год (1-9999): ", 1, 9999);
        int month = PromptForInt("Введите месяц (1-12): ", 1, 12);
        int day = PromptForDay("Введите день: ", year, month);
        int hour = PromptForInt("Введите часы (0-23): ", 0, 23);
        int minute = PromptForInt("Введите минуты (0-59): ", 0, 59);
        int second = PromptForInt("Введите секунды (0-59): ", 0, 59);

        try
        {
            DateTime dateTime = input.GetFullDateTime(year, month, day, hour, minute, second);
            Console.WriteLine($"Введенная дата и время: {dateTime}");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            // Обработка исключений, если ввод не прошел проверку
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }

    // Метод для запроса целого числа через консоль с проверкой диапазона и повторным запросом при ошибке
    static int PromptForInt(string message, int minValue, int maxValue)
    {
        int result;
        bool isValid;
        do
        {
            Console.Write(message);
            string input = Console.ReadLine();
            isValid = int.TryParse(input, out result);

            if (!isValid)
            {
                Console.WriteLine("Ошибка: Введите числовое значение.");
                continue;
            }

            if (result < minValue || result > maxValue)
            {
                Console.WriteLine($"Ошибка: Значение должно быть в диапазоне от {minValue} до {maxValue}.");
                isValid = false;
            }

        } while (!isValid);

        return result;
    }

    // Метод для запроса дня с учетом количества дней в месяце и повторным запросом при ошибке
    static int PromptForDay(string message, int year, int month)
    {
        int result;
        bool isValid;
        int daysInMonth = DateTime.DaysInMonth(year, month);

        do
        {
            Console.Write(message);
            string input = Console.ReadLine();
            isValid = int.TryParse(input, out result);

            if (!isValid)
            {
                Console.WriteLine("Ошибка: Введите числовое значение.");
                continue;
            }

            if (result < 1 || result > daysInMonth)
            {
                Console.WriteLine($"Ошибка: День должен быть в диапазоне от 1 до {daysInMonth} для указанного месяца.");
                isValid = false;
            }

        } while (!isValid);

        return result;
    }
}