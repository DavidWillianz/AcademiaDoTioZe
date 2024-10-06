using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDoTioZe.Model
{
    public class Aluno
    {
        public int Id{ get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Nome{ get; set; }
        public string Nascimento { get; set; }
        public string Email { get; set; }
        public int LogradouroId { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Senha { get; set; }

        public Aluno(int id = 0, string cpf = "", string telefone = "", string nome = "", string nascimento = "", 
            string email = "", int logradouroId = 0, string numero = "", string complemento = "", string senha = "") 
        {
            Id = id;
            Cpf = cpf;
            Telefone = telefone;
            Nome = nome;
            Nascimento = nascimento;
            Email = email;
            LogradouroId = logradouroId;
            Numero = numero;
            Complemento = complemento;
            Senha = senha;
        }
    }
}
