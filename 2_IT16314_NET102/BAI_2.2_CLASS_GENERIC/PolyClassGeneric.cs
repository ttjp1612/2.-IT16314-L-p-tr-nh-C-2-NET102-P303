﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2._2_CLASS_GENERIC
{
    class PolyClassGeneric<T>
    {
        private T temp;

        public PolyClassGeneric()
        {
            
        }

        public PolyClassGeneric(T temp)
        {
            this.temp = temp;
        }

        public T Temp
        {
            get => temp;
            set => temp = value;
        }

        public T inRaManHinh()
        {
            Console.WriteLine(temp);
            return temp;
        }
    }
}
