﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
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
            //Tạo 3 đối tượng sinh viên ảo có sẵn và add vào danh sách ban đầu
            _student = new Student(0, "A1", "123", 0);
            _lstStudents.Add(_student);  
            _student = new Student(1, "A2", "123", 1);
            _lstStudents.Add(_student); 
            _student = new Student(2, "A3", "123", 0);
            _lstStudents.Add(_student);
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
                    _student.Id = _lstStudents.Count;//_lstStudents.Count = kích thước của List đối tượng và kích thước chính là vị trí tiếp theo dạng index
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
        public bool addStudentDungna()//Phương thức thêm sinh viên ở dạng nâng cao
        {
            do
            {
                _input = getInputValue("số lượng sinh viên: ");
                for (int i = 0; i < Convert.ToInt32(_input); i++)
                {
                    _student = new Student();//Phải khởi tạo mới đối tượng trước khi sử dụng
                    _student.Id = _lstStudents.Count;//_lstStudents.Count = kích thước của List đối tượng và kích thước chính là vị trí tiếp theo dạng index
                    _student.Name = getInputValue("tên: ");
                    _student.Phone = getInputValue("sdt: ");
                    _student.Sex = Convert.ToInt32(getInputValue("giới tính (1 = Nam | 0 Nữ): "));
                    _lstStudents.Add(_student);//Thêm 1 đối tượng vào List sau mỗi lần nhập thông tin
                }
                _input = getInputValue("tiếp hay không? Y/N: ");
            } while (!(_input.ToLower() == "n"));
            return true;
        }

        public void getListStudent()
        {
            foreach (var x in _lstStudents)
            {
                x.inRaManHinh();
            }
        }

        public void findStudent()
        {
            // //Cách 1: Thông thường
            // Console.WriteLine("Mời bạn nhập ID Student: ");
            // _input = Console.ReadLine();
            // // bool flag = true;
            // for (int i = 0; i < _lstStudents.Count; i++)
            // {
            //     if (_lstStudents[i].Id == Convert.ToInt32(_input))
            //     {
            //         _lstStudents[i].inRaManHinh();
            //         Console.WriteLine("========");
            //         return;
            //         // flag = false;
            //     }
            // }
            // Console.WriteLine("Mã sinh viên không tồn tại");
            // // if (flag)
            // // {
            // //     Console.WriteLine("Mã sinh viên không tồn tại");
            // // }

            //Cách 2: Nâng cao 1 dòng code
            //Cách 2.1 Dùng linq
            //_lstStudents.Where(c=>c.Id == Convert.ToInt32(getInputValue("mã sinh viên: "))).FirstOrDefault().inRaManHinh();

            //Cách 2.2: 
            int temp = getIndexStudent(getInputValue("mã sinh viên: "));
            if (temp == -1)
            {
                Console.WriteLine("Mã sinh viên không tồn tại");
                return;
            }
            _lstStudents[temp].inRaManHinh();
        }
        public void removeStudent()
        {
            // //Cách 1: Thông thường
            // Console.WriteLine("Mời bạn nhập ID Student: ");
            // _input = Console.ReadLine();
            // // bool flag = true;
            // for (int i = 0; i < _lstStudents.Count; i++)
            // {
            //     if (_lstStudents[i].Id == Convert.ToInt32(_input))
            //     {
            //         _lstStudents.RemoveAt(i);//Xóa theo index của đối tượng
            //         Console.WriteLine("====Chúc mừng bạn xóa thành công====");
            //         return;
            //         // flag = false;
            //     }
            // }
            // Console.WriteLine("Mã sinh viên không tồn tại");
            // // if (flag)
            // // {
            // //     Console.WriteLine("Mã sinh viên không tồn tại");
            // // }

            //Cách 2.2: 
            int temp = getIndexStudent(getInputValue("mã sinh viên: "));
            if (temp == -1)
            {
                Console.WriteLine("Mã sinh viên không tồn tại");
                return;
            }
            _lstStudents.RemoveAt(temp);
            Console.WriteLine("Bạn đã xóa thành công");
        }

        public void updateSinhVien()
        {
            //Cách 1: Thông thường
            Console.WriteLine("Mời bạn nhập ID Student: ");
            _input = Console.ReadLine();
            for (int i = 0; i < _lstStudents.Count; i++)
            {
                if (_lstStudents[i].Id == Convert.ToInt32(_input))
                {
                    Console.WriteLine("Các thông tin muốn sửa: ");
                    Console.WriteLine("1. Tên");
                    Console.WriteLine("2. sdt");
                    Console.WriteLine("3. Giới tính");
                    Console.WriteLine("Bạn muốn sửa thông tin gì? ");
                    string temp = Console.ReadLine();
                    switch (temp)
                    {
                        case "1":
                            Console.WriteLine("Mời bạn nhập tên cần sửa: ");
                            _lstStudents[i].Name = Console.ReadLine();
                            break;
                        case "2":
                            Console.WriteLine("Mời bạn nhập số điện thoại cần sửa: ");
                            _lstStudents[i].Phone = Console.ReadLine();
                            break;
                        case "3":
                            Console.WriteLine("Mời bạn nhập giới tính (1 = Nam | 0 Nữ) cần sửa: ");
                            _lstStudents[i].Sex = Convert.ToInt32(Console.ReadLine());
                            break;
                        default:
                            Console.WriteLine("Chức năng bạn chọn không tồn tại");
                            break;
                    }
                    Console.WriteLine("====Chúc mừng bạn sửa thành công====");
                    return;
                   
                }
            }
            Console.WriteLine("Mã sinh viên không tồn tại");
           
        }

        //Phương thức getInputValue là phương thức trả về giá trị của người dùng nhập vào
        private string getInputValue(string mess)
        {
            Console.WriteLine("Mời bạn nhập " + mess);
            return Console.ReadLine();
        }

        //Phương thức lấy ra index của đối tượng trong danh sách
        private int getIndexStudent(string idStudent)
        {
            for (int i = 0; i < _lstStudents.Count; i++)
            {
                if (_lstStudents[i].Id == Convert.ToInt32(idStudent))
                {
                    return i;//Khi tìm thấy thì sẽ trả về index của đối tượng
                }
            }
            return -1;//Khi không tìm thấy sẽ trả ra giá trị -1
        }
    }
}
