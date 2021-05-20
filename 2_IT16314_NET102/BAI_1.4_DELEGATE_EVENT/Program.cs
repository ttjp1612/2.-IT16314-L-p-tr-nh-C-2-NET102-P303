using System;
using System.Text;

namespace BAI_1._4_DELEGATE_EVENT
{
    class Program
    {
        /*
       * ❑Sự kiện (Event) là các hành động, ví dụ như nhấn phím, click, di chuyển chuột...
         ❑Trong C#, Event là một đối tượng đặc biệt của  Delegate, nó là nơi chứa các phương thức, các phương thức này sẽ được thực thi khi sự kiện xảy ra
         ❑Đặc điểm của event:
             ❖Được khai báo trong các lớp hoặc interface
             ❖Được khai báo là abstract hoặc sealed, virtual
             ❖Được thực thi thông qua delegate
         ❑Tạo và sử dụng event
             ❖Đinh nghĩa delegate cho event
             ❖Tạo event thông qua delegate
             ❖Đăng ký để lắng nghe và xử lý event
             ❖Kích hoạt event
       */
        //Bước 1: Tạo 1 Delegate
        delegate void UpdateNameHandler(string studentID);
        //Bước 2: Tạo 1 class
        class Student
        {
            public event UpdateNameHandler StudentIDChanged;
            private string studentID;
            public string StudentID//prop + tab
            {
                get => studentID;
                set
                {
                    studentID = value;
                    //Kiểm tra để gọi ra sự kiện mong muốn mỗi khi tác động vào thuộc tính
                    if (StudentIDChanged != null)
                    {
                        StudentIDChanged(studentID);
                    }
                }
            }
            static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
                Student st = new Student();
                st.StudentIDChanged += St_StudentIDChanged;//Khi gõ += và tab sẽ có tia chớp chính là 1 sự kiện và nó sẽ zen cho 1 phương thức của sự kiện ra
                st.StudentID = "PH001111";
                Console.WriteLine("Mã sinh viên: " + st.StudentID);
                st.StudentID = "PH001122";
                Console.WriteLine("Mã sinh viên: " + st.StudentID);
            }

            private static void St_StudentIDChanged(string studentID)
            {
                Console.WriteLine("Thông báo Mã SV mới: " + studentID);
            }
        }
    }
}
