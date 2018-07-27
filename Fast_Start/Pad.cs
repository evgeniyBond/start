using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start
{
   public class Pad
    {
        // Параметры самой колодки
        public double lenght;  // длина колодки
        public double width;   // ширина колодки
        public int step;    // шаг деления
        public int distanse_for_start_line;  // расстояние от колодки до линии старта

        // Параметры опорных пластин
        public int hight;                // высота
        public int width_plastin;        // ширина пластины
        public int alfa1;                // угол наклона для первой колодки
        public int alfa2;                // угол наклона для второй колодки
        public bool rubber_pads;         // есть ли резиновые накладки
        public double distanse;          // расстояние между пластинами

        // Конструктор по умолчанию
        public Pad()
        {
            lenght = 12;
            width = 10;
            step = 5;
            distanse_for_start_line = 40;
            hight = 12;
            width_plastin = 12;
            alfa1 = 45;
            alfa2 = 60;
            rubber_pads = true;
            distanse = 70;
        }

        // Конструктор для колодки и опорных пластин колодки
        public Pad(double _lenght, double _width, int _step, int _distanse_for_start_line,
              int _hight, int _width_plastin, int _alfa1, int _alfa2, bool _rubber_pads, double _distanse)
        {
            lenght = _lenght;
            width = _width;
            step = _step;
            distanse_for_start_line = _distanse_for_start_line;
            hight = _hight;
            width_plastin = _width_plastin;
            alfa1 = _alfa1;
            alfa2 = _alfa2;
            rubber_pads = _rubber_pads;
            distanse = _distanse;
        }
    }
}
