﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BarbershopTech
{
   public class Utilidades
    {
        public static int TOINT(string nombre)
        {
            int numero;
            int.TryParse(nombre, out numero);
            return numero;
        }
    }
}
