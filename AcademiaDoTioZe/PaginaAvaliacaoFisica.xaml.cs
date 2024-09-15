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
    /// Interação lógica para PaginaAvaliacaoFisica.xam
    /// </summary>
    public partial class PaginaAvaliacaoFisica : Page
    {
        public PaginaAvaliacaoFisica()
        {
            InitializeComponent();

            pesoKg.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            pesoKg.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);
            altura.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            altura.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);
            torax.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            torax.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);
            cintura.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            cintura.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);
            antebracoEsq.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            antebracoEsq.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);
            antebracoDir.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            antebracoDir.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);
            bicepsEsq.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            bicepsEsq.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);
            bicepsDir.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            bicepsDir.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);
            coxaEsq.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            coxaEsq.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);
            coxaDir.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            coxaDir.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);
            panturrilhaEsq.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            panturrilhaEsq.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);
            panturrilhaDir.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            panturrilhaDir.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);
            quadril.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            quadril.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);
            obs.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            obs.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);
        }
    }
}
