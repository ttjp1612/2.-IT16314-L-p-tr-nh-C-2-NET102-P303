using System;

namespace BAI_2._6_NULLABLE_TYPED
{
    class Program
    {
        #region Định nghĩa
        /*
        * 1. Từ khóa null
        *    + null là một giá trị cố định nó biểu thị không có đối tượng nào cả, có nghĩa là biến có giá trị null không có tham chiếu (trỏ) đến đối tượng nào (không có gì).

             + null chỉ có thể gán được cho các biến kiểu tham chiếu (biến có kiểu dữ liệu là các lớp), không thể gán null cho những biến có kiểu dữ liệu dạng tham trị như int, float, bool ...
        */

        /*
         *2. Sử dụng nullable
         *    + Nếu bạn muốn sử dụng các kiểu dữ liệu nguyên tố như int, float, double ... như là một kiểu dữ liệu dạng tham chiếu, có thể gán giá trị null cho nó, có thể sử dụng như đối tượng ... thì khai báo nó có khả năng nullable, khi biến nullable có giá trị thì đọc giá trị bằng truy cập thành viên .Value, cách làm như sau:
         *    + Khi khai báo biến có khả năng nullable thì thêm vào ? sau kiểu dữ liệu      
         */
        #endregion

        class ClassA
        {
            public void method1()
            {
                Console.WriteLine("Method 1 Class A");
            }
        }
        static void Main(string[] args)
        {
            #region Phần 1 Null

            ClassA classA1, classA2;

            classA1 = new ClassA(); //ClassA1 được khởi tạo tham chiếu bằng một đối tượng
            classA2 = classA1; //ClassA2 được gán bởi ClassA1 tham chiếu đến cùng đối tượng ClassA1
            
            
            classA2.method1();

            //classA1 = null; //ClassA1 không trỏ đến đối tượng nào cả
            classA1.method1();//Vì không trỏ đến đối tượng nào nên khi truy cập đến thành viên sẽ bị lỗi

            string temp1 = null;
            int temp2 = 10;          //  int là kiểu tham trị, nó có thể gán giá trị cho biến temp1 (10)
            //int temp3 = null;      //  lỗi - kiểu tham  trị  không được gán null 
            #endregion

            #region Phần 2 NULLABLE TYPED
            /*2.  NULLABLE TYPED
                  + Cú pháp: 
                      - Nullable<T> tên biến;
                      - T? tên biến;
                  + Cần gán gia trị cho biến khi khai báo nếu không sẽ bị lỗi và nên kiểm tra giá tị trước khi dùng bằng HasValue
                  + Dùng phương thức GetValueOrDefault() để lấy giá mặc định của kiểu dữ liệu
                  + Dùng toán tử ?? thực hiện gán Nullable Type cho Non-Nullable Type
           */
            Nullable<long> temp3 = null;
            Nullable<long> temp4 = 9;
            byte? temp5 = 20;
            byte?[] arr = new byte?[5];

            if (temp4.HasValue)//Kiểm tra giá trị trước khi dùng
            {
                //Thực hiện 1 hành động nào đó còn nếu ngược lại là empty
            }
            //GetValueOrDefault() phương thức lấy giá trị mặc định của kiểu dữ liệu
            Console.WriteLine(temp3.GetValueOrDefault());//Giá trị mặc định = 0

            //Toán tử ?? thực hiện gán Nullable Type cho Non-Nullable type
            byte? temp6 = null;
            byte temp7 = temp6 ?? 0;// temp7 = temp6 nếu temp6 != null, temp7 = 0 nếu temp6 = null;

            #endregion
        }
    }
}
