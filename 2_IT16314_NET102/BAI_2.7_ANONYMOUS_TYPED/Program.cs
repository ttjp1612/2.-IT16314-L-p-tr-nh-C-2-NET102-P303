using System;
using System.Text;

namespace BAI_2._7_ANONYMOUS_TYPED
{
    class Program
    {
        #region ANONYMOUS TYPED
        /*
         * Phần 1:  Định nghĩa:
             * ❑Kiểu ẩn danh (Anonymous Type) cung cấp một cách thuận tiện để đóng gói (encapsulate) một tập các thuộc tính chỉ đọc (read-only properties) vào một đối tượng mà không cần phải xác định rõ ràng loại (type) của nó ngay lúc viết code
             * ❑Cho phép tạo type mới (user-defined) mà không cần xác định tên của nó
               ❑Tạo các type ẩn danh này bằng cách sử dụng toán tử new

           Phần 2: ANONYMOUS METHOD
            ❑Phương thức vô danh (anonymous method) là một phương thức:
               ❖Không cần khai báo tên phương thức khi định nghĩa phương thức
               ❖Có thể khai báo trực tiếp ở chỗ cần dùng, không cần định nghĩa trước
               ❖Đươc dùng như tham số của deleg

            ❑Một số giới hạn Anonymous methods
                ❖Không khái báo được các lệnh goto, break or continue bên trong phương thức
                ❖Không truy cập được các tham số ref hoặc out bên ngoài
                ❖Phải được dùng kết hợp với delegate
         */

        //Khai báo phương thức delegate
        public delegate void Method1(int temp);

        #endregion
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            /*
             * Phần 1: Khai báo Anonymous và Anonymous lồng nhau
             */
            var svUDPM = new
            {
                Id = "PH15",
                Name = "NAM",
                TrangThai = true
            };
            Console.WriteLine($"{svUDPM.Id} + {svUDPM.Name} + {svUDPM.TrangThai}");
            var svUDPM1 = new
            {
                Id = "PH15",
                Name = "NAM",
                TrangThai = true,
                DiaChi = new
                {
                    SoNha = "So 1",
                    Duong ="Trịnh văn bô"
                }
            };
            Console.WriteLine($"{svUDPM1.Id} + {svUDPM1.Name} + {svUDPM1.TrangThai} + {svUDPM1.DiaChi.SoNha}");

            /*
           * Phần 2: Phương thức nặc danh

           */
            Method1 method1 = delegate(int temp)
            {
                //Có thể gọi các biến cục bộ ngoài phương thức như bình thường.
                Console.WriteLine("Đây là phương thức nặc danh. Giá trị = " + temp);
            };
            method1(2021);
        }
    }
}
