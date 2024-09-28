using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interação lógica para PaginaFrequencia.xam
    /// </summary>
    public partial class PaginaFrequencia : Page
    {
        public PaginaFrequencia()
        {
            InitializeComponent();
            id.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            id.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

            idAluno.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            idAluno.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);
        }
    }
}
