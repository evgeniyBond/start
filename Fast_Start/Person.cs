using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Start
{
    //Данные для базы и вывода статистики
    class Person
    {
        public string name { get; set; }          // имя
        public string surname { get; set; }        // фамилия
        public double height_man { get; set; }     // рост
        public double weight { get; set; }      // вес 
        public string supporting_leg { get; set; }// опорная толчковая нога
        public double speed { get; set; }            // скорость        
        public double time { get; set; }    // лучшее время старта
        public double covered_distance { get; set; }
        public double pressure { get; set; }


        public Person() { }

        // Конструктор 
        public Person(string _name, string _surname, double _height_man, double _weight, string _supporting_leg, double _speed, double _time, double _covered_distance, double _pressure)
        {
            name = _name;
            surname = _surname;
            height_man = _height_man;
            weight = _weight;
            supporting_leg = _supporting_leg;
            speed = _speed;
            time = _time;
            covered_distance = _covered_distance;
            pressure = _pressure;
        }


    }
}
