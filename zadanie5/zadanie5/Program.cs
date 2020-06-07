using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace zadanie5
{
    class Student
    {
        private int Id;
        private string FIO;
        private int Group;
        private string Data;
        private int i = 0;
        public int id
        {
            get { return Id; }
            set { if (value >= 0) i++; Id = value; }
        }
        public int gr
        {
            get { return Group; }
            set { if (value >= 0) Group = value; }
        }
        public string fio
        {
            get { return FIO; }
            set { if (value != "" || value != " ") FIO = value; }
        }
        public string dt
        {
            get { return Data; }
            set { if (value != "" || value != " ") Data = value; }
        }
        public void Info()
        {
            Console.WriteLine($"\nID: 0{id} \nФИО: {FIO} \nГруппа: {Group}\nДата рождения: {Data}");
        }
        public void add()
        {
            Student s = new Student();
            string nm, d;
            Console.Write("Введите ФИО студента: ");
            nm = Convert.ToString(Console.ReadLine());
            Console.Write("Введите номер группы: ");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите дату рождения: ");
            d = Convert.ToString(Console.ReadLine());
            i++;
            s.id = i;
            s.fio = nm;
            s.gr = g;
            s.dt = d;
            s.Info();
        }
        public void red()
        {
            string nm, d;
            Student ak = new Student();
            Console.Write("Введите ФИО студента: ");
            nm = Convert.ToString(Console.ReadLine());
            Console.Write("Введите номер группы: ");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите дату рождения: ");
            d = Convert.ToString(Console.ReadLine());
            i++;
            ak.id = i;
            ak.fio = nm;
            ak.gr = g;
            ak.dt = d;
            ak.Info();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student ns = new Student();
            ns.fio = "Иванов Иван Иванович";
            ns.dt = "01.01.2001";
            ns.gr = 1;
            ns.id = 1;
            Console.WriteLine("Какое действие нужно выполнить?\n1.Добавить студента;\n2.Изменить данные студента;\n3.Удалить студента.");
            int vy = Convert.ToInt32(Console.ReadLine());
            switch (vy)
            {
                case 1:
                    {
                        ns.Info();
                        ns.add();
                        break;
                    }
                case 2:
                    { 
                        ns.Info();
                        ns.red();
                        break;
                    }
                case 3:
                    { 
                        ns = null; 
                        break; 
                    }
            }
        }
    }
}