﻿using System;

namespace BAI_2._5_IMPLICITLY_VA_DYNAMIC_TYPE
{
    class Program
    {
        /*
        * Phần 1: Implicitly,Dynamic
        *          1.1 Implicitly (KIỀU NGẦM ĐỊNH):
        *             ❑Khai báo biến kiểu ngầm định (khai báo không tường minh) là biến được khai báo mà không cần phải chỉ ra kiểu dữ liệu
                      ❑Kiểu dữ liệu của biến sẽ được xác định bởi trình biên dịch dựa vào biểu thức được gán khi khai báo biến
                      ❑Sử dụng từ khóa “var” khi khai báo và cần khởi tạo giá trị
                   1.2 Công thức:
                       var varialble_name = value;
                   1.3 Hạn chế:
                      + Không thể sử dụng từ khóa var bên ngoài phạm vi của một method
                      + Không thể khởi tạo giá trị là null.
                      + Biến phải được khởi tạo giá trị khi nó được khai báo 
                      + Nếu biến được gán giá trị, thì kiểu dữ liệu phải giống        nhau
                      + Giá trị khởi tạo phải là một biểu thức. Giá trị khởi tạo     không được là một đối tượng hay tập hợp các giá trị. Nhưng nó có thể sử dụng toán tử new bởi một đối tượng hoặc tập hợp các giá trị.

                   2.1 Dynamic
                       Kiểu động - ngầm định - khai báo với từ khóa dynamic, thì kiểu thực sự của biến đó được xác định bằng đối tượng gán vào ở thời điểm chạy (khác với kiểu ngầm định var kiểu xác định ngay        thời điểm biên dịch)
        */
        static void Main(string[] args)
        {
            #region Phần 1: Implicitly 

            //1. Khai báo
            var a = 50;// Implicitly Typed
            int b = 50;// Explicitly Typed
            var c = true;//Ngoài ra nó có thể nhận đc rất nhiều kiểu dữ liệu khác.

            //2. Hạn chế khi khai báo và xảy ra lỗi

            //2.0 Không thể khởi tạo giá trị null
            //var temp1 = null;

            //2.1 Phải khởi tạo giá trị cho nó ngay khi khai báo
            //var temp1;

            //2.2 Nếu biến được gán giá trị, thì kiểu dữ liệu phải giống nhau
            // var temp1 = 5;
            // temp1 = "1";

            //2.3 Giá trị khởi tạo phải là 1 biểu thức. Giá trị khởi tạo không được là một đối tượng hay tập giá trị. Nhưng nó có thể sự dụng toán tử new bởi một đối tượng hoặc tập giá các giá trị.
            //var arrNumber = {10, 5, 8};
            var arrNumber = new int[] {10, 5, 8};

            //2.4 Không thể khai báo bên ngoài phương thức và không thể dùng nó làm tham số truyền vào của 1 phương thức
            #endregion

            #region Phần 2:  Dynamic
            //1. Khai báo các kiểu dữ liệu giống như var
            dynamic x1;
            dynamic x2 = 50;
            dynamic x3 = 9.6;

            //Khai báo kiểu nặc danh
            var student = new
            {
                id = "PH00532",
                name = "Nam",
                nganhHoc = "UDPM .net"
            };

            //Gọi phương thức sửa dụng tham số dynamic
            method2(student, student.name);
            #endregion
        }

        private dynamic a;
        static void method2(dynamic temp1,dynamic temp2)
        {
            Console.WriteLine(temp1.id + " " + temp2);
        }




        //Implicitly không thể khai báo kiểu var làm tham số truyền vào
        // static void method1(var x, var b)
        // {
        //
        // }

    }
}
