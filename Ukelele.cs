using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._1
{
    class Ukelele
    {
        private string color;
        private string tipo;

        public string Color
        {
            get
            {
                return Color;
            }
            set
            {
                Color = value;
            }
        }

        public string Tipo
        {
            get
            {
                return Tipo;
            }
            set
            {
                Tipo = value;
            }
        }
        public Ukelele()
        {
            color = "";
            tipo = "";
        }
        public Ukelele(string color, string tipo)
        {
            this.color = color;
            this.tipo = tipo;
        }
        public override string ToString()
        {
            return base.ToString() + "color:" + color + "tipo[" + tipo.ToString() + "]";
        }
    }

    }

    
