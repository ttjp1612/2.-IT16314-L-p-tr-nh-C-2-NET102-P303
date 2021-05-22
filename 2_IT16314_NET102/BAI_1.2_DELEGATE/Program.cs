using System;
using System.Text;

namespace BAI_1._2_DELEGATE
{
    //Delegate có thể khai báo bên trong hoặc bên ngoài class
    public delegate void ShowMessage(string mess);
    class Program
    {
        #region Bài về Delegate
        /*
        * Định nghĩa:
            * ❑Delegate là một biến chứa tham chiếu đến phương thức cần thực thi.
              ❑Một delegate có thể trỏ tới một hoặc nhiều phương thức
              ❑Delegate có thể gọi bất kỳ phương thức nào nó trỏ tới tại thời điểm thực thi
              ❑
        * + Có thể khai báo trong namespace hoặc khai báo trong class
        * + Khi khai báo giống như khai báo một phương thức
        * + Công thức:
        *      <phạm vi truy cập> delegate <kiểu phương thức> <tên>(<Tham số>); 
        */

        static void Info1(string s)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Info1 = " + s);
            Console.ResetColor();
        }
        static void Info2(string s)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Info2 = " + s);
            Console.ResetColor();
        }


        #endregion
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");

            #region Phần 1: Khởi tạo delegate null
            Console.WriteLine("========Phần 1: Khởi tạo delegate null========");
            ShowMessage showMessage = null;//Khởi tạo delegate = null
            showMessage = Info1;//Gán phương thức mà delegate sẽ trỏ đến phương thức đó
            //showMessage("Chào các bạn học Delegate");
            showMessage?.Invoke("Chào các bạn học Delegate");//?Kiểm tra xem delegate có null hay không và nếu không null thì sẽ thực thi
            #endregion

            #region Phần 2: Khởi tạo delegate
            Console.WriteLine("========Phần 2: Khởi tạo delegate========");
            ShowMessage showMessage2 = new ShowMessage(Info1);
            showMessage2("Chào các bạn POLY học DELEGATE 2");
            #endregion

            #region Phần 3: C# Multicast Delegates
            /*
               ❖Có thể tham chiếu đến nhiều phương thức tại cùng một thời điểm
               ❖Kiểu tra về của multicast delegate phải là kiểu void
               ❖Dùng toán tử “+” để thêm phương thức vào delegate
            */
            Console.WriteLine("========Phần 3: C# Multicast Delegates========");
            ShowMessage showMessage3 = new ShowMessage(Info1);
            ShowMessage showMessage4 = new ShowMessage(Info2);
            ShowMessage multicastMessage = showMessage3 + showMessage4;
            multicastMessage += showMessage3;
            multicastMessage += showMessage4;
            multicastMessage("Đây là Multicast Delegates");

            Console.WriteLine("========Trừ trong Delegates========");
            multicastMessage = multicastMessage - showMessage4;
            multicastMessage("Trừ Multicast Delegate");
            #endregion

            #region Phần 4: Delegate Callback
            Console.WriteLine("========Phần 4: Delegate Callback========");
            DelegateCallback delegateCallback = new DelegateCallback(showMess);
            CallBack(delegateCallback);
            #endregion
        }
        #region Phần 4: Delegate Callback
        public delegate void DelegateCallback(string mess);
        public static void showMess(string mess)
        {
            Console.WriteLine("Thông báo: " + mess);
        }
        public static void CallBack(DelegateCallback delegateCallback)
        {
            Console.WriteLine("Mời bạn nhập thông báo: ");
            var temp = Console.ReadLine();
            delegateCallback(temp);
            //showMess(temp);
        }

        #endregion
    }
}
