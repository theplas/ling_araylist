using System;
using System.Collections;
using System.Linq;

namespace Linq_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList nhanvien = new ArrayList()
            {
                new Staff { ID = 1, Name = "Nam", Age = 24 },
                new Staff{ ID = 2, Name = "Kien", Age = 21 },
                new Staff{ ID = 3, Name = "Viet", Age = 21 },
                new Staff{ ID = 4, Name = "Hang", Age = 23 },
                new Staff{ ID = 5, Name = "Tien", Age = 24 }
            };


          
            var newArrayList = nhanvien.OfType<Staff>(); 
            var Search = from name in newArrayList
                         where (name.Age < 24)
                         select name;
            var sapxep = from name in newArrayList
                         orderby name.Name
                         select name;
            Console.WriteLine("Danh sach nguoi co tuoi nho hon 24:");
            foreach (var item in Search)
            {
                Console.WriteLine("ID :" + item.ID + " Name : " + item.Name + " Age : " + item.Age);
            }
            Console.WriteLine("Sap xep theo ten :");
            foreach (var item in sapxep)
            {
                Console.WriteLine("ID :" + item.ID + " Name : " + item.Name + " Age : " + item.Age);
            }
        }
    }
}