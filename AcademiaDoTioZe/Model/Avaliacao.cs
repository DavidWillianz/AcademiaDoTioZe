using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDoTioZe.Model
{
    public class Avaliacao
    {
        public int AvaliacaoId { get; set; }
        public int AlunoId { get; set; }
        public int ColaboradorId { get; set; }
        public DateTime Data { get; set; }
        public string Peso { get; set; }
        public string Altura { get; set; }
        public string  Torax { get; set; }
        public string Cintura { get; set; }
        public string Quadril { get; set; }
        public string AntebracoDir { get; set; }
        public string AntebracoEsq { get; set; }
        public string BicepsDir { get; set; }
        public string BicepsEsq { get; set; }
        public string CoxaDir { get; set; }
        public string CoxaEsq { get; set; }
        public string PanturrilhaEsq{ get; set; }
        public string PanturrilhaDir { get; set; }
        public string MassaGorda { get; set; }
        public string MassaMagra { get; set; }
        public string PercentualGordura { get; set; }
        public string Imc { get; set; }
        public string PesoIdeal { get; set; }
        public string Observacoes { get; set; }
        public Avaliacao(int avaliacaoId = 0, int alunoId = 0, int colaboradorId = 0, DateTime? data = null,
                     string peso = "", string altura = "", string torax = "", string cintura = "",
                     string quadril = "", string antebracoDir = "", string antebracoEsq = "",
                     string bicepsDir = "", string bicepsEsq = "", string coxaDir = "", string coxaEsq = "",
                     string panturrilhaDir = "", string panturrilhaEsq = "", string massaGorda = "",
                     string massaMagra = "", string percentualGordura = "", string imc = "", string pesoIdeal = "",
                     string observacoes = "")
        {
            AvaliacaoId = avaliacaoId;
            AlunoId = alunoId;
            ColaboradorId = colaboradorId;
            Data = data ?? DateTime.Now;  // Se data for nula, usa a data atual
            Peso = peso;
            Altura = altura;
            Torax = torax;
            Cintura = cintura;
            Quadril = quadril;
            AntebracoDir = antebracoDir;
            AntebracoEsq = antebracoEsq;
            BicepsDir = bicepsDir;
            BicepsEsq = bicepsEsq;
            CoxaDir = coxaDir;
            CoxaEsq = coxaEsq;
            PanturrilhaDir = panturrilhaDir;
            PanturrilhaEsq = panturrilhaEsq;
            MassaGorda = massaGorda;
            MassaMagra = massaMagra;
            PercentualGordura = percentualGordura;
            Imc = imc;
            PesoIdeal = pesoIdeal;
            Observacoes = observacoes;
        }
    }
}
