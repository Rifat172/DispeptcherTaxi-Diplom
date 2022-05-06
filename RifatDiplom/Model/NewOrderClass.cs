using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RifatDiplom.Model
{
    public class NewOrderClass
    {
        private string _PointA;
        private string _PointB;
        private int _Price;
        private int _IdDrivers;

        public string PointA { get => _PointA;
            set 
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    _PointA = value;
                }
            }
        }

        public string PointB
        {
            get => _PointB;
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    _PointB = value;
                }
            }
        }

        public int Price { get => _Price; set => _Price = value; }
        public int IdDrivers { get => _IdDrivers; set => _IdDrivers = value; }
    }
}
