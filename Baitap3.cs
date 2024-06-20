using System;
using System.Collections;

class Product
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
}

class Baitap3
{
    static ArrayList products = new ArrayList();

    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("1. Them san pham moi");
            Console.WriteLine("2. Hien thi danh sach san pham");
            Console.WriteLine("3. Tim kiem san pham");
            Console.WriteLine("4. Thoat");

            Console.Write("Chon chuc nang: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddProduct();
                    break;
                case 2:
                    DisplayProducts();
                    break;
                case 3:
                    SearchProduct();
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

    static void AddProduct()
    {
        Product newProduct = new Product();

        Console.Write("Nhap ten san pham: ");
        newProduct.Name = Console.ReadLine();

        Console.Write("Nhap mo ta san pham: ");
        newProduct.Description = Console.ReadLine();

        Console.Write("Nhap gia san pham: ");
        newProduct.Price = decimal.Parse(Console.ReadLine());

        products.Add(newProduct);
        Console.WriteLine("Da them san pham moi vao danh sach.");
    }

    static void DisplayProducts()
    {
        if (products.Count == 0)
        {
            Console.WriteLine("Danh sach san pham rong.");
            return;
        }

        Console.WriteLine("Danh sach san pham:");
        foreach (Product product in products)
        {
            Console.WriteLine($"Ten: {product.Name}, Mo ta: {product.Description}, Gia: {product.Price:C}");
        }
    }

    static void SearchProduct()
    {
        Console.Write("Nhap ten san pham can tim: ");
        string searchName = Console.ReadLine();

        bool found = false;
        foreach (Product product in products)
        {
            if (product.Name.ToLower().Contains(searchName.ToLower()))
            {
                Console.WriteLine($"Ten: {product.Name}, Mo ta: {product.Description}, Gia: {product.Price:C}");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Khong tim thay san pham.");
        }
    }
}