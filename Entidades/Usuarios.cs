﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Nombres { get; set; }
        public string Email { get; set; }
        public string Tipo { get; set; }
        public string Contrasena { get; set; }
        public string Confirmar { get; set; }
    }
}
