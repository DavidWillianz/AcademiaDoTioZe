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

namespace AcademiaDoTioZe.View
{
    /// <summary>
    /// Interação lógica para PaginaLogradouro.xam
    /// </summary>
    public partial class PaginaLogradouro : Page
    {
        public PaginaLogradouro()
        {
            InitializeComponent();
            id.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            id.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

            cpf.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            cpf.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

            logradouro.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            logradouro.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

            bairro.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            bairro.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

            cidade.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            cidade.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

            numero.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            numero.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

            uf.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            uf.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

            pais.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            pais.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

            complemento.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            complemento.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

        }
    }
}
