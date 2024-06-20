using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public string Class { get; set; }
    private double _score;
    public double Score
    {
        get { return _score; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Diem so khong the la so am. Diem so sẽ duoc dat thanh 0.");
                _score = 0;
            }
            else if (value > 10)
            {
                Console.WriteLine("Diem so khong the lon hon 10. Diem so se duoc dat thanh 0.");
                _score = 10;
            }
            else
            {
                _score = value;
            }
        }
    }
}

class Baitap1
{
    static List<Student> students = new List<Student>();

    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("1. Them sinh vien moi");
            Console.WriteLine("2. Hien thi danh sach sinh vien");
            Console.WriteLine("3. Tinh tong diem");
            Console.WriteLine("4. Thoat");

            Console.Write("Chon chuc nang: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddStudent();
                    break;
                case 2:
                    DisplayStudents();
                    break;
                case 3:
                    CalculateTotalScore();
                    break;
                case 4:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le. Vui long thu lai.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void AddStudent()
    {
        Student student = new Student();
        Console.Write("Nhap ten sinh vien: ");
        student.Name = Console.ReadLine();
        Console.Write("Nhap lop: ");
        student.Class = Console.ReadLine();
        Console.Write("Nhap diem: ");
        double score = double.Parse(Console.ReadLine());
        student.Score = score;
        students.Add(student);
        Console.WriteLine("Da them sinh vien moi.");
    }

    static void DisplayStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("Danh sach sinh vien trong.");
        }
        else
        {
            Console.WriteLine("Danh sach sinh vien:");
            foreach (var student in students)
            {
                Console.WriteLine($"Ten: {student.Name}, Lop: {student.Class}, Diem: {student.Score}");
            }
        }
    }

    static void CalculateTotalScore()
    {
        double totalScore = 0;
        foreach (var student in students)
        {
            totalScore += student.Score;
        }
        Console.WriteLine($"Tong diem cua tat ca sinh vien: {totalScore}");
    }
}