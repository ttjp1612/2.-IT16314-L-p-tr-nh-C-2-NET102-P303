using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1._0_ONTAP_CSHARP1_CRUD
{
    class ServiceStudent
    {
        private List<Student> _lstStudents;
        private Student _student;
        private string _input; 
        public ServiceStudent()
        {
            _lstStudents = new List<Student>();//Khởi tạo List khi Class ServiceStudent được khởi tạo
        }

        public bool addStudent()
        {
            do
            {
                Console.WriteLine("Bạn muốn thêm vào bao nhiêu sinh viên: ");
                _input = Console.ReadLine();
                for (int i = 0; i < Convert.ToInt32(_input); i++)
                {
                    _student = new Student();//Phải khởi tạo mới đối tượng trước khi sử dụng
                    _student.Id = i;
                    Console.WriteLine("Mời bạn nhập tên: ");
                    _student.Name = Console.ReadLine();
                    Console.WriteLine("Mời bạn nhập số điện thoại: ");
                    _student.Phone = Console.ReadLine();
                    Console.WriteLine("Mời bạn nhập giới tính (1 = Nam | 0 Nữ): ");
                    _student.Sex = Convert.ToInt32(Console.ReadLine());
                    _lstStudents.Add(_student);//Thêm 1 đối tượng vào List sau mỗi lần nhập thông tin
                }
                Console.WriteLine("Bạn có muốn nhập tiếp hay không? Y/N: ");
                _input = Console.ReadLine();
            } while (!(_input.ToLower()=="n"));
            return true;
        }

        public void getListStudent()
        {
            foreach (var x in _lstStudents)
            {
                x.inRaManHinh();
            }
        }
    }
}
