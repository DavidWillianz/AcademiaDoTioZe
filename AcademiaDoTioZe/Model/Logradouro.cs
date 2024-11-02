using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDoTioZe.Model
{
    public class Logradouro : ICloneable
    {
        public int Id { get; set; }
        public string Cep { get; set; }
        public string Rua { get; set; } //campo pode ser chamado como logradouro também
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public int Numero { get; set; }
        public string Uf { get; set; }
        public string Pais { get; set; }
        public string Complemento { get; set; }

        //public Logradouro(int id = 0, string cep = "", string rua = "", string bairro = "", string cidade = "", int numero = 0, string uf = "", string pais = "", string complemento = "")
        //{
        //    Id = id;
        //    Cep = cep;
        //    Rua = rua;
        //    Bairro = bairro;
        //    Cidade = cidade;
        //    Numero = numero;
        //    Uf = uf;
        //    Pais = pais;
        //    Complemento = complemento;
        //}
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}