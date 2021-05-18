using System;

namespace BAI_1._1_ONTAP_CSHARP1_CRUD_NANGCAO
{
    class Program
    {
        static void Main(string[] args)
        {
            IServiceStudent iServiceStudent = new ServiceStudent();
            iServiceStudent.addStudent();
            iServiceStudent.removeStudent();
        }
    }
}
