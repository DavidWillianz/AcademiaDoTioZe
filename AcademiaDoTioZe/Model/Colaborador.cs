using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDoTioZe.Model
{
    public class Colaborador
    {
        public int IdColaborador { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string Email { get; set; }
        public int LogradouroId { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Senha { get; set; }
        public DateTime Admissao { get; set; }
        public string Tipo { get; set; }
        public string Vinculo { get; set; }

        public Colaborador(int idColaborador = 0, string cpf = "", string telefone = "", string nome = "", DateTime? nascimento = null,
                           string email = "", int logradouroId = 0, string numero = "", string complemento = "",
                           string senha = "", DateTime? admissao = null, string tipo = "", string vinculo = "")
        {
            IdColaborador = idColaborador;
            Cpf = cpf;
            Telefone = telefone;
            Nome = nome;
            Nascimento = nascimento ?? DateTime.Now;  // Usa a data atual se nenhum valor for fornecido
            Email = email;
            LogradouroId = logradouroId;
            Numero = numero;
            Complemento = complemento;
            Senha = senha;
            Admissao = admissao ?? DateTime.Now;  // Usa a data atual se nenhum valor for fornecido
            Tipo = tipo;
            Vinculo = vinculo;
        }
    }

}
