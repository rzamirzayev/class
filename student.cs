using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace class_task
{
    internal class student
    {
        public string name;
        public string surname;
        public string group;
        public bool isgraduated;
        public int point;
        public void Person()
        {
            Console.WriteLine("Ad:" + this.name + "Soyad:" + this.surname);
        }
        public void Gostericiler()
        {
            Console.WriteLine("Ad:" + this.name + " Soyad" + this.surname + " Qrup" + this.group +" Bal:" + this.point);
            if (this.isgraduated == true)
                Console.WriteLine("Mezun olub");
            else
                Console.WriteLine("Kesilib");

        }
        public void Exam()
        {
            if (this.point > 80)
                Console.WriteLine("ikinci imtahana daxil ola bilersiz");
            else
                Console.WriteLine("imtahana daxil ola bilmersiz");
        }
        public student(string name, string surname, int point, string group)
        {
            this.point = point;
            this.name = name;
            this.surname = surname;
            this.group = group;

            if (point > 50)
            {
                this.isgraduated = true;
            }
            else
            {
                this.isgraduated = false;
            }
         
        }
    }
    

        
}
