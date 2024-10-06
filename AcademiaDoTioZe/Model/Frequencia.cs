using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDoTioZe.Model
{
    public class Frequencia
    {
        public int FrequenciaId { get; set; }
        public int AlunoId { get; set; }
        public DateTime? Entrada { get; set; }
        public DateTime? Saida { get; set; }
        public Frequencia(int frequenciaId = 0, int alunoId = 0, DateTime? entrada = null, DateTime? saida = null)
        {
            FrequenciaId = frequenciaId;
            AlunoId = alunoId;
            Entrada = entrada ?? DateTime.Now;  // Se não for passada uma data, usa a data atual
            Saida = saida;
        }
    }
}
