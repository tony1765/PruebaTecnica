﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaTecnicaFrontEnd.Models
{
    public class Auto
    {
        public int IdAuto { get; set; }
        public string Descripcion { get; set; }
        public int Sku { get; set; }
        public Marca Marca { get; set; }
        public int Cantidad { get; set; }

    }
}