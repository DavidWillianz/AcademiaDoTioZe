using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AcademiaDoTioZe
{
    /// <summary>
    /// Interação lógica para PaginaCadastroMatricula.xam
    /// </summary>
    public partial class PaginaCadastroMatricula : Page
    {
        public PaginaCadastroMatricula()
        {
            InitializeComponent();
            idMatricula.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            idMatricula.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

            idAluno.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            idAluno.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

            idColaborador.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            idColaborador.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

            //cpfAluno.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            //cpfAluno.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

            //nomeAluno.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            //nomeAluno.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

            plano.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            plano.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

            restricoes.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            restricoes.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

            laudoMedico.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            laudoMedico.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

            objetivoAluno.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            objetivoAluno.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

            observacoes.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            observacoes.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

        }
    }
}
