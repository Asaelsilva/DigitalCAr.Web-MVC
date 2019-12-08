using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalCar.Dominio.Entidade
{
    public class Funcionario
    {
        public int Id { get; set; }
        [DisplayName ("Nome")]
        [Required(ErrorMessage = "Nome Obrigatorio")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "CPF obrigatorio")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "Exemplo: 000.000.000-00")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Rg obrigatorio")]
        [RegularExpression(@"^\d{2}\.\d{3}\.\d{3}-\d{1}$", ErrorMessage = "Exemplo: 00.000.000-0")]
        public string Rg { get; set; }

        [DisplayName("DataNascimento")]
        [Required(ErrorMessage = "Data de Nascimento Obrigatorio")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Email obrigatorio")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "E-mail invalido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefone obrigatorio")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Formato invalido! Digite apenas numeros!!!")]
        //[RegularExpression(@"^(\([0-9]{2}\))\s([9]{1})?([0-9]{4})-([0-9]{4})$", ErrorMessage = "Formato Invalido!")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Celular obrigatorio")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Formato invalido! Digite apenas numeros!!!")]
        //[RegularExpression(@"^(\([0-9]{2}\))\s([9]{1})?([0-9]{4})-([0-9]{4})$", ErrorMessage = "Formato invalido!")]
        public string Celular { get; set; }

        [DisplayName("Rua")]
        [Required(ErrorMessage = "Obrigatorio O endereço")]
        public string Rua { get; set; }

        [DisplayName("Turno")]
        [Required(ErrorMessage = "Turno Obrigatorio")]
        public string Turno { get; set; }

        [DisplayName("Funcao")]
        [Required(ErrorMessage = "Função Obrigatorio")]
        public string Funcao { get; set; }

        [DisplayName("Status")]
        [Required(ErrorMessage = "Status Obrigatorio")]
        public string Status { get; set; }

        [Required(ErrorMessage = "Obrigatorio")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Não existe endereço com numero negativo")]
        public int Numero { get; set; }

        [DisplayName("Bairro")]
        [Required(ErrorMessage = "Obrigatorio O Bairro")]
        public string Bairro { get; set; }

        [DisplayName("Cidade")]
        [Required(ErrorMessage = "Obrigatorio a Cidade")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "CEP Obrigatorio")]
        [RegularExpression(@"^\d{5}-\d{3}$", ErrorMessage = "Formato Invalido... Exemplo: 00000-000")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "UF")]
        [RegularExpression(@"[a-zA-Z]{2,2}", ErrorMessage = "Exemplo: SP")]
        public string UF { get; set; }
    }
}
