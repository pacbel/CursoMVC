﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Categoria
    {
        public int id { get; set; }
        public string Descricao { get; set; }

        public List<Produto> produtos { get; set; }

    }
}
