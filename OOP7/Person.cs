using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOP7
{
    //abstract class tanımı
    public abstract class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Departmant { get; set; }
        public string Job { get; set; }
        //abstract method tanımı
        public abstract void Duty();
        public void DisplayInfo()
        {
            Console.WriteLine($"Ad : {Name} Soyad : {Surname} Departman: {Departmant} ");
        }
    }
    //Person dan kalıtım alıyor
    public class Developer : Person
    {
        

        public Developer(string name,string surname,string departmant,string job) 
        { 
            Name = name;
            Surname = surname;
            Departmant = departmant;
            Job = job;
        }
        
        public override void Duty()
        {
            
            Console.WriteLine($"{Job} olarak Çalışıyorum");
        }
    }
}
