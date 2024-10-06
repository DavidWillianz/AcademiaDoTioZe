using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDoTioZe.Model
{
    public class Matricula
    {
        public int IdMatricula { get; set; }
        public int AlunoId { get; set; }
        public int ColaboradorId { get; set; }
        public string Plano { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public string Objetivo { get; set; }
        public string RestricaoMedica { get; set; }
        public string ObsRestricao { get; set; }
        public string LaudoMedico { get; set; }

        public Matricula(int idMatricula = 0, int alunoId = 0, int colaboradorId = 0, string plano = "",
                         DateTime? dataInicio = null, DateTime? dataFim = null, string objetivo = "",
                         string restricaoMedica = "", string obsRestricao = "", string laudoMedico = "")
        {
            IdMatricula = idMatricula;
            AlunoId = alunoId;
            ColaboradorId = colaboradorId;
            Plano = plano;
            DataInicio = dataInicio ?? DateTime.Now;  // Usa a data atual se nenhum valor for fornecido
            DataFim = dataFim;
            Objetivo = objetivo;
            RestricaoMedica = restricaoMedica;
            ObsRestricao = obsRestricao;
            LaudoMedico = laudoMedico;
        }
    }
}
