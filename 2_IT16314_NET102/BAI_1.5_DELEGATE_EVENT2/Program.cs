using System;

namespace BAI_1._5_DELEGATE_EVENT2
{
    class Program
    {
        public delegate void SuKienNhapSo(int x, int y);

        class UserInput
        {
            public event SuKienNhapSo suKienNhapSo;

            public void getInputValue()
            {
                Console.WriteLine("Mời bạn nhập số nguyên 1: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mời bạn nhập số nguyên 2: ");
                int b = Convert.ToInt32(Console.ReadLine());
                //Tương tự hành động phát sự kiện
                suKienNhapSo.Invoke(a,b);
            }
        }

        class TinhTong//Nhận sự kiện
        {
            public void thiHanh(UserInput userInput)
            {
                //Không thực hiện phép gán mà phải thực hiện toán từ += hoặc -=
                userInput.suKienNhapSo += tinhTong;//Khi sự kiện nhập số xảy ra thì thi thành sự kiện tính tổng
            }

            private void tinhTong(int x, int y)
            {
                Console.WriteLine("Tổng 2 số: {0} + {1} = {2}", x, y, x + y);
            }
        }
        static void Main(string[] args)
        {
            //Phát đi sự kiện
            UserInput userInput = new UserInput();

            //Nhận sự kiện
            TinhTong tinhTong = new TinhTong();
            tinhTong.thiHanh(userInput);

            //Thực thi
            userInput.getInputValue();
        }
    }
}
