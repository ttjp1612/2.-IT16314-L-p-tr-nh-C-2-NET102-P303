using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2._9_DocGhiDoiTuong
{
    [Serializable]
    class Student
    {
        private int id;
        private string msv;
        private string name;

        public Student()
        {
            
        }

        public Student(int id, string msv, string name)
        {
            this.id = id;
            this.msv = msv;
            this.name = name;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Msv
        {
            get => msv;
            set => msv = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public void InRaMnaHinh()
        {
            Console.WriteLine($"{Id} + {Name} + {Msv}");
        }
    }
}
