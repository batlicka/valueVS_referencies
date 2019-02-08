using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace valueVSreferencies
{
    public class Student
    {
        public string name;
        public Student(string stu)
        {
            name = stu;
        }

    }
    class Program
    {
        enum dny { Pondeli=1, Utery, Streda, Ctvrtek, Patek, Sobota, Nedele};


        static void ChangeValue(Student st)
        {
            st.name="amadeus";            
        }

        static void Main(string[] args)
        {
            dny dnes = dny.Nedele;
            Console.WriteLine("dnes je {0}", dnes);
            Console.WriteLine("a to je {0}-ty den", (int)dnes);


            Student std1 = new Student("Jan");
            Student std2 = new Student("Peter");
            Console.WriteLine(std1.name);
            Console.WriteLine("before change"+std2.name);
            std2 = std1;//std2 bude ukazovat na std1, =>ztratí referenci na svou pùvodní instanci

            Console.WriteLine("after change:"+std2.name);
            ChangeValue(std1);
            Console.WriteLine(std1.name);
        }
    }
}
