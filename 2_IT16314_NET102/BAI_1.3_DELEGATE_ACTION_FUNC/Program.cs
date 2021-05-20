using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace BAI_1._3_DELEGATE_ACTION_FUNC
{
    class Program
    {
        #region  Bài Action, Predicate, Func: Delegate - Generic(Sử dụng sẵn tham số Generic để khai báo)

        #region Định nghĩa
        /*
         Thay vì chúng ta phải khai báo định nghĩa trước delegate thì chúng ta sẽ sử dụng 3 kiểu dưới đây khai báo cho nhanh.
          Action, Predicate, Func (Viết tắt là APF là cho nhanh) trong C#
            + Action: Action<T in1, T in2, …>. Action tương đương 1 delegate với kiểu trả về là void, với in1, in2 là các params nhận vào.

            + Predicate: Predicate<T in>. Predicate tương đương 1 delegate với kiểu trả về là bool, với in là các param nhận vào. Predicate chỉ có thể nhận vào 1 param duy nhất.

            + Func: Func<T in1, T in2, … , T result>. Function tương đương 1 delegate với kiểu trả về do ta khai báo (result), in1, in2 là các params nhận vào. Func bắt buộc phải trả ra giá trị, không thể trả void.


            Bảng so sánh cách khai báo bằng delegate cùng với cách khai báo tương ứng bằng Action, Predicate, Func:

            delegate void VoidDelegate(int input1, bool input2)	- Action<int, bool>	
            
            delegate bool BoolDelegate(int input1)	-  Predicate<int>	|| Func<int, bool>

            delegate int intDelegate(bool input2)	- Func<bool, int>
            
            delegate void HelloWorldDelegate()	- Action

            delegate bool HelloWorldBoolDelegate()	- Predicate -  Func<bool>

        */


        #endregion

        static void Info1(string s)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(s);
            Console.ResetColor();
        }
        static void Info2(string s)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(s);
            Console.ResetColor();
        }
        static void Info3(string s,int a)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(s);
            Console.ResetColor();
        }

        static int tinhTong(int a, int b)
        {
            return a + b;
        }

        static bool isUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }

        #endregion
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");

            #region Phần 1: Action khai báo với phương thức void
            Action action;                  // tương đương như delegate void TenDelegate();
            Action<string, int> action1;    // tương đương như delegate void TenDelegate(string a, int b);
            Action<string> action2;         // tương đương như delegate void TenDelegate(string a);
            action2 = Info2;
            action2("Đây là phương thức Info2");
            action2?.Invoke("Đây là phương thức Info2");
            #endregion

            #region Phần 2: Func khai báo với phương thức có kiểu trả về
            Console.WriteLine("==== Phần 2: Func khai báo với phương thức có kiểu trả về ====");
            //Tham số cuối cùng chính là kiểu trả về của phương thức
            Func<int, int, int> func; // tương đương như delegate int TenDelegate(int a,int b);
            func = tinhTong;
            Console.WriteLine("Tổng là: " + func.Invoke(6,84));

            Func<string, double, string> func1;// tương đương như delegate string TenDelegate(string a,double b);
            #endregion

            #region Phần 3: Predicate khai báo với phương thức có kiểu trả về true false
            Console.WriteLine("==== Phần 3: Predicate khai báo với phương thức có kiểu trả về true false ====");
            Predicate<string> predicate;// tương đương như delegate bool TenDelegate(string a);
            predicate = isUpperCase;
            Console.WriteLine("String sau có viết hoa hay không = " + predicate.Invoke("FPT"));

            #endregion
        }
    }
}
