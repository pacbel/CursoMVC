using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Produto
    {
        public int id { get; set; }

        [Display(Name = "Descrição")]
        public string descricao { get; set; }
        [Range(0,100, ErrorMessage ="Valor fora da faixa.")]
        public int quantidade { get; set; }
        public int categoriaId { get; set; }
        public Categoria categoria { get; set; }

    }
}
