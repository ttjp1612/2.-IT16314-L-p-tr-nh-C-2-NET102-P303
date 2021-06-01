using System;
using System.Text;

namespace BAI_2._2_CLASS_GENERIC
{
    class Program
    {
        /*
         *  Lớp Generic         *
         *  - Trước thì chúng ta làm việc với các kiểu dữ liệu tường minh nay khi học được Generic chúng ta chỉ quan tâm T cũng là 1 dạng kiểu dữ liệu nhưng do người sử dụng định nghĩa sẽ giúp tái sử dụng hơn rất nhiều.
         *  - Khi truyền kiểu dữ liệu cho T thì nó sẽ thay thế toàn bộ các chỗ gọi đến T thành các kiểu dữ liệu......
         *  - Giúp định nghĩa một thao tác dữ liệu với kiểu dữ liệu chung nhất nhìn hạn chế viết code và tái sử dụng.          
           
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
        }
    }
}
