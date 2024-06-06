using System;

public class AgeOutOfRangeException : Exception
{
    public AgeOutOfRangeException(string message) : base(message)
    {
    }
}

class Ex1
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Nhập tuổi của học sinh: ");
            int age = int.Parse(Console.ReadLine());
            CheckEligibility(age);
            Console.WriteLine("Học sinh đủ điều kiện nhập học.");
        }
        catch (AgeOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
        }
    }

    static void CheckEligibility(int age)
    {
        if (age < 18 || age > 25)
        {
            throw new AgeOutOfRangeException($"Tuổi của học sinh ({age}) không nằm trong khoảng từ 18 đến 25.");
        }
    }
}
