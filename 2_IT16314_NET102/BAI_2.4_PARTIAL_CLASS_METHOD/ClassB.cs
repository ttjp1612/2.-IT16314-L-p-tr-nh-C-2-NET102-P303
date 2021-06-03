using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2._4_PARTIAL_CLASS_METHOD
{
    partial class ClassA //ClassA nằm trong file ClassB.cs
    {
        public string variableC { get; set; }
        public int variableD { get; set; }

        public void method2()
        {
            Console.WriteLine("Đây là method 2");
        }
        public partial void method3()//Triển khai phương thức partial đã khao báo bên ClassA file ClassA.cs
        {
            Console.WriteLine("Đây là method 3");
        }
    }
}
