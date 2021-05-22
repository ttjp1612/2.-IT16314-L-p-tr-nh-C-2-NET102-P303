using System;

namespace BAI_1._6_DELEGATE_EVENT3
{
    class Program
    {
        /*
     * Ngoài ra trong C# có sẵn chuẩn tạo ra sẵn sự kiện Delegate
     */
        class UserInput
        {
            public event EventHandler suKienNhapSo;// Tương đương delegate void ten(object sender, EventArgs args)

            public void getInputValue()
            {
                Console.WriteLine("Mời bạn nhập số nguyên 1: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mời bạn nhập số nguyên 2: ");
                int b = Convert.ToInt32(Console.ReadLine());
                //Tương tự hành động phát sự kiện
                suKienNhapSo.Invoke(this, new UserInput1(a,b));
            }
        }
        
        class UserInput1: EventArgs
        {
            public int a { get; set; }
            public int b { get; set; }

            public UserInput1(int a, int b)
            {
                this.a = a;
                this.b = b;
            }
        }

        class TinhTong//Nhận sự kiện
        {
            public void thiHanh(UserInput userInput)
            {
                //Không thực hiện phép gán mà phải thực hiện toán từ += hoặc -=
                userInput.suKienNhapSo += tinhTong;//Khi sự kiện nhập số xảy ra thì thi thành sự kiện tính tổng
            }

            // Tương đương delegate void ten(object sender, EventArgs e)
            private void tinhTong(object s, EventArgs e)
            {
                UserInput1 userInput1 = (UserInput1) e;
                Console.WriteLine("Tổng 2 số: {0} + {1} = {2}", userInput1.a, userInput1.b, userInput1.a + userInput1.b);
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
