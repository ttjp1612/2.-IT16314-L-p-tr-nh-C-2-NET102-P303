using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1._1_ONTAP_CSHARP1_CRUD_NANGCAO
{
    //Lớp con khi kế thừa chỉ cần khai báo các thuộc tính đặng trưng riêng của đối tượng
    //Khi kế thừa 1 lớp abstract class thì sẽ phải kế thừa đủ các phương thức abstract có bên lớp cha
    //Trong lập trình C# chỉ có đơn kế thừa
    class Student :Person
    {
        private string msv;
        private string gpa;

        public Student()
        {
            
        }

        public Student(int id, string name, string phone, int sex, string msv, string gpa) : base(id, name, phone, sex)
        {
            this.msv = msv;
            this.gpa = gpa;
        }

        public string Msv
        {
            get => msv;
            set => msv = value;
        }

        public string Gpa
        {
            get => gpa;
            set => gpa = value;
        }


        public override void inRaManHinh2()
        {
            throw new NotImplementedException();
        }

        public override void inRaManHinh3()
        {
            throw new NotImplementedException();
        }

        public override void inRaManHinh4(string year, string school)
        {
            throw new NotImplementedException();
        }
    }
}
