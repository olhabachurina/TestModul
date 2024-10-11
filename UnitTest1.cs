namespace TestModull
{
    [TestClass]
    public class DateTimeInputTests
    {
        // Тесты для года
        [TestMethod]
        public void TestValidYear_WithinRange()//Проверяет, что метод возвращает корректное значение года
        {
            DateTimeInput input = new DateTimeInput();
            int year = input.GetYear(2023);  // Корректное значение
            Assert.AreEqual(2023, year);
        }

        [TestMethod]
        public void TestInvalidYear_OutOfRange()//Проверяет, что метод выбрасывает исключение, если год выходит за допустимый диапазон 
        {
            DateTimeInput input = new DateTimeInput();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => input.GetYear(10000));  // Некорректное значение
        }

        // Тесты для месяца
        [TestMethod]
        public void TestValidMonth_WithinRange()// Проверяет корректность месяца 
        {
            DateTimeInput input = new DateTimeInput();
            int month = input.GetMonth(2);  // Корректное значение
            Assert.AreEqual(2, month);
        }

        [TestMethod]
        public void TestInvalidMonth_OutOfRange()// Проверяет выброс исключения, если передан некорректный месяц
        {
            DateTimeInput input = new DateTimeInput();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => input.GetMonth(13));  // Некорректное значение
        }
        [TestMethod]
        public void TestInvalidMonth_NegativeValue() // Проверяет выброс исключения при отрицательном значении месяца
        {
            DateTimeInput input = new DateTimeInput();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => input.GetMonth(-1));  // Отрицательное значение
        }

        [TestMethod]
        public void TestInvalidMonth_ZeroValue() // Проверяет выброс исключения при нулевом значении месяца
        {
            DateTimeInput input = new DateTimeInput();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => input.GetMonth(0));  // Нулевое значение
        }
        // Тесты для дня
        [TestMethod]
        public void TestValidDay_FebruaryLeapYear()//Проверяет, что 29 февраля корректен для високосного года
        {
            DateTimeInput input = new DateTimeInput();
            int day = input.GetDay(2024, 2, 29);  // Високосный год
            Assert.AreEqual(29, day);
        }

        [TestMethod]
        public void TestInvalidDay_FebruaryNonLeapYear()//Проверяет, что 29 февраля выбрасывает исключение в невисокосный год
        {
            DateTimeInput input = new DateTimeInput();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => input.GetDay(2023, 2, 29));  // Невисокосный год
        }

        [TestMethod]
        public void TestValidDay_MaximumInMonth()//Проверяет, что 31 декабря корректен для месяца
        {
            DateTimeInput input = new DateTimeInput();
            int day = input.GetDay(2023, 12, 31);  // Последний день года
            Assert.AreEqual(31, day);
        }

        [TestMethod]
        public void TestInvalidDay_ExceedsMaxInMonth()//Проверяет, что 31 июня выбрасывает исключение,
        {
            DateTimeInput input = new DateTimeInput();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => input.GetDay(2023, 6, 31));  // 31 июня не существует
        }
        [TestMethod]
        public void TestInvalidDay_NegativeValue() // Проверяет выброс исключения при отрицательном значении дня
        {
            DateTimeInput input = new DateTimeInput();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => input.GetDay(2023, 1, -1));  // Отрицательное значение
        }

        [TestMethod]
        public void TestInvalidDay_ZeroValue() // Проверяет выброс исключения при нулевом значении дня
        {
            DateTimeInput input = new DateTimeInput();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => input.GetDay(2023, 1, 0));  // Нулевое значение
        }
        // Тесты для часов
        [TestMethod]
        public void TestValidHour_WithinRange()//Проверяет корректность часов
        {
            DateTimeInput input = new DateTimeInput();
            int hour = input.GetHour(15);  // Корректное значение
            Assert.AreEqual(15, hour);
        }

        [TestMethod]
        public void TestInvalidHour_OutOfRange()//Проверяет выброс исключения для часов, выходящих за пределы диапазона 
        {
            DateTimeInput input = new DateTimeInput();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => input.GetHour(24));  // Некорректное значение
        }
        [TestMethod]
        public void TestValidHour_ZeroValue() // Проверяет, что нулевой час корректен
        {
            DateTimeInput input = new DateTimeInput();
            int hour = input.GetHour(0);  // Нулевое значение
            Assert.AreEqual(0, hour);
        }

        [TestMethod]
        public void TestInvalidHour_NegativeValue() // Проверяет выброс исключения при отрицательном значении часа
        {
            DateTimeInput input = new DateTimeInput();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => input.GetHour(-1));  // Отрицательное значение
        }
        // Тесты для минут
        [TestMethod]
        public void TestValidMinute_WithinRange()//Проверяет корректность минут
        {
            DateTimeInput input = new DateTimeInput();
            int minute = input.GetMinute(45);  // Корректное значение
            Assert.AreEqual(45, minute);
        }

        [TestMethod]
        public void TestInvalidMinute_OutOfRange()//Проверяет выброс исключения для некорректных минут
        {
            DateTimeInput input = new DateTimeInput();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => input.GetMinute(60));  // Некорректное значение
        }
        [TestMethod]
        public void TestValidMinute_ZeroValue() // Проверяет, что нулевые минуты корректны
        {
            DateTimeInput input = new DateTimeInput();
            int minute = input.GetMinute(0);  // Нулевое значение
            Assert.AreEqual(0, minute);
        }

        [TestMethod]
        public void TestInvalidMinute_NegativeValue() // Проверяет выброс исключения при отрицательном значении минут
        {
            DateTimeInput input = new DateTimeInput();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => input.GetMinute(-1));  // Отрицательное значение
        }
        // Тесты для секунд
        [TestMethod]
        public void TestValidSecond_WithinRange()//Проверяет корректность секунд 
        {
            DateTimeInput input = new DateTimeInput();
            int second = input.GetSecond(30);  // Корректное значение
            Assert.AreEqual(30, second);
        }

        [TestMethod]
        public void TestInvalidSecond_OutOfRange()//Проверяет выброс исключения для некорректных секунд
        {
            DateTimeInput input = new DateTimeInput();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => input.GetSecond(60));  // Некорректное значение
        }
        [TestMethod]
        public void TestValidSecond_ZeroValue() // Проверяет, что нулевые секунды корректны
        {
            DateTimeInput input = new DateTimeInput();
            int second = input.GetSecond(0);  // Нулевое значение
            Assert.AreEqual(0, second);
        }

        [TestMethod]
        public void TestInvalidSecond_NegativeValue() // Проверяет выброс исключения при отрицательном значении секунд
        {
            DateTimeInput input = new DateTimeInput();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => input.GetSecond(-1));  // Отрицательное значение
        }
    }
}
