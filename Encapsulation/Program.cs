using System;
namespace EncapsulationP
{
     class Program
    {
        public static void Main(string[] args) {
            var stuInfo = new Student();
            //stuName.SetStudentInfo("S001", 23, "s001pp@gmail.com");
            //Console.WriteLine(stuName);
            stuInfo.SetStuName(" ");
            stuInfo.SetRollNo("se-11");
            stuInfo.SetEmail("hmone@gmail.com");
            stuInfo.SetAge(23);
            Console.WriteLine(stuInfo);
            
                }
    }
}
