using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
   public class Contacts
    {
        public string Tel { set; get; }
        public string address;
    }
    public class Student
    {
       public string firstName; // имя
       public string lastName; // фамилия 
       public byte age;
       public Contacts contacts;
       public int[] balls = new int[5];
       public double average;


    }
}
