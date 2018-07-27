using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start
{
    public class Sportsmen
    {
        public string name { get; set; }            // имя
        public string surname { get; set; }         // фамилия
        public int height_man { get; set; }         // рост
        public int weight { get; set; }             // вес 
        public string supporting_leg { get; set; }  // опорная толчковая нога
        public float speed { get; set; }            // скорость        
        public float time { get; set; }            // лучшее время старта
        public int covered_distance { get; set; }  // пройденное расстояние
        public int pressure { get; set; }          // давление


        public Sportsmen() { }

        // Конструктор 
        public Sportsmen(string _name, string _surname, int _height_man, int _weight, string _supporting_leg,
                        float _speed, float _time, int _covered_distance, int _pressure)
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
