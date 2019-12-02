using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalCar.Dominio.Entidade
{
    public class Funcionario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome Obrigatorio")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "CPF Obrigatorio")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Rg Obrigatorio")]
        public string Rg { get; set; }

        [Required(ErrorMessage = "Data de Nascimento Obrigatorio")]
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Rua { get; set; } 
        public string Turno { get; set; }
        public string Funcao { get; set; }
        public string Status { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public string UF { get; set; }
    }
}
