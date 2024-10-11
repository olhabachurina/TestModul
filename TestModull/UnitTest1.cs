namespace TestModull
{
    [TestClass]
    public class DateTimeInputTests
    {
        // ����� ��� ����
        [TestMethod]
        public void TestValidYear_WithinRange()//���������, ��� ����� ���������� ���������� �������� ����
        {
            DateTimeInput input = new DateTimeInput();
            int year = input.GetYear(2023);  // ���������� ��������
            Assert.AreEqual(2023, year);
        }

        [TestMethod]
        public void TestInvalidYear_OutOfRange()//���������, ��� ����� ����������� ����������, ���� ��� ������� �� ���������� �������� 
        {
            DateTimeInput input = new DateTimeInput();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => input.GetYear(10000));  // ������������ ��������
        }

        // ����� ��� ������
        [TestMethod]
        public void TestValidMonth_WithinRange()// ��������� ������������ ������ 
        {
            DateTimeInput input = new DateTimeInput();
            int month = input.GetMonth(2);  // ���������� ��������
            Assert.AreEqual(2, month);
        }

        [TestMethod]
        public void TestInvalidMonth_OutOfRange()// ��������� ������ ����������, ���� ������� ������������ �����
        {
            DateTimeInput input = new DateTimeInput();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => input.GetMonth(13));  // ������������ ��������
        }
        [TestMethod]
        public void TestInvalidMonth_NegativeValue() // ��������� ������ ���������� ��� ������������� �������� ������
        {
            DateTimeInput input = new DateTimeInput();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => input.GetMonth(-1));  // ������������� ��������
        }

        [TestMethod]
        public void TestInvalidMonth_ZeroValue() // ��������� ������ ���������� ��� ������� �������� ������
        {
            DateTimeInput input = new DateTimeInput();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => input.GetMonth(0));  // ������� ��������
        }
        // ����� ��� ���
        [TestMethod]
        public void TestValidDay_FebruaryLeapYear()//���������, ��� 29 ������� ��������� ��� ����������� ����
        {
            DateTimeInput input = new DateTimeInput();
            int day = input.GetDay(2024, 2, 29);  // ���������� ���
            Assert.AreEqual(29, day);
        }

        [TestMethod]
        public void TestInvalidDay_FebruaryNonLeapYear()//���������, ��� 29 ������� ����������� ���������� � ������������ ���
        {
            DateTimeInput input = new DateTimeInput();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => input.GetDay(2023, 2, 29));  // ������������ ���
        }

        [TestMethod]
        public void TestValidDay_MaximumInMonth()//���������, ��� 31 ������� ��������� ��� ������
        {
            DateTimeInput input = new DateTimeInput();
            int day = input.GetDay(2023, 12, 31);  // ��������� ���� ����
            Assert.AreEqual(31, day);
        }

        [TestMethod]
        public void TestInvalidDay_ExceedsMaxInMonth()//���������, ��� 31 ���� ����������� ����������,
        {
            DateTimeInput input = new DateTimeInput();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => input.GetDay(2023, 6, 31));  // 31 ���� �� ����������
        }
        [TestMethod]
        public void TestInvalidDay_NegativeValue() // ��������� ������ ���������� ��� ������������� �������� ���
        {
            DateTimeInput input = new DateTimeInput();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => input.GetDay(2023, 1, -1));  // ������������� ��������
        }

        [TestMethod]
        public void TestInvalidDay_ZeroValue() // ��������� ������ ���������� ��� ������� �������� ���
        {
            DateTimeInput input = new DateTimeInput();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => input.GetDay(2023, 1, 0));  // ������� ��������
        }
        // ����� ��� �����
        [TestMethod]
        public void TestValidHour_WithinRange()//��������� ������������ �����
        {
            DateTimeInput input = new DateTimeInput();
            int hour = input.GetHour(15);  // ���������� ��������
            Assert.AreEqual(15, hour);
        }

        [TestMethod]
        public void TestInvalidHour_OutOfRange()//��������� ������ ���������� ��� �����, ��������� �� ������� ��������� 
        {
            DateTimeInput input = new DateTimeInput();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => input.GetHour(24));  // ������������ ��������
        }
        [TestMethod]
        public void TestValidHour_ZeroValue() // ���������, ��� ������� ��� ���������
        {
            DateTimeInput input = new DateTimeInput();
            int hour = input.GetHour(0);  // ������� ��������
            Assert.AreEqual(0, hour);
        }

        [TestMethod]
        public void TestInvalidHour_NegativeValue() // ��������� ������ ���������� ��� ������������� �������� ����
        {
            DateTimeInput input = new DateTimeInput();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => input.GetHour(-1));  // ������������� ��������
        }
        // ����� ��� �����
        [TestMethod]
        public void TestValidMinute_WithinRange()//��������� ������������ �����
        {
            DateTimeInput input = new DateTimeInput();
            int minute = input.GetMinute(45);  // ���������� ��������
            Assert.AreEqual(45, minute);
        }

        [TestMethod]
        public void TestInvalidMinute_OutOfRange()//��������� ������ ���������� ��� ������������ �����
        {
            DateTimeInput input = new DateTimeInput();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => input.GetMinute(60));  // ������������ ��������
        }
        [TestMethod]
        public void TestValidMinute_ZeroValue() // ���������, ��� ������� ������ ���������
        {
            DateTimeInput input = new DateTimeInput();
            int minute = input.GetMinute(0);  // ������� ��������
            Assert.AreEqual(0, minute);
        }

        [TestMethod]
        public void TestInvalidMinute_NegativeValue() // ��������� ������ ���������� ��� ������������� �������� �����
        {
            DateTimeInput input = new DateTimeInput();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => input.GetMinute(-1));  // ������������� ��������
        }
        // ����� ��� ������
        [TestMethod]
        public void TestValidSecond_WithinRange()//��������� ������������ ������ 
        {
            DateTimeInput input = new DateTimeInput();
            int second = input.GetSecond(30);  // ���������� ��������
            Assert.AreEqual(30, second);
        }

        [TestMethod]
        public void TestInvalidSecond_OutOfRange()//��������� ������ ���������� ��� ������������ ������
        {
            DateTimeInput input = new DateTimeInput();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => input.GetSecond(60));  // ������������ ��������
        }
        [TestMethod]
        public void TestValidSecond_ZeroValue() // ���������, ��� ������� ������� ���������
        {
            DateTimeInput input = new DateTimeInput();
            int second = input.GetSecond(0);  // ������� ��������
            Assert.AreEqual(0, second);
        }

        [TestMethod]
        public void TestInvalidSecond_NegativeValue() // ��������� ������ ���������� ��� ������������� �������� ������
        {
            DateTimeInput input = new DateTimeInput();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => input.GetSecond(-1));  // ������������� ��������
        }
    }
}
