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
    /// Interação lógica para PaginaCadastroColaborador.xam
    /// </summary>
    public partial class PaginaCadastroColaborador : Page
    {
        public PaginaCadastroColaborador()
        {
            InitializeComponent();
            idColaborador.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            idColaborador.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

            cpfColaborador.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            cpfColaborador.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

            telefoneColaborador.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            telefoneColaborador.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

            nomeColaborador.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            nomeColaborador.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

            emailColaborador.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            emailColaborador.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

            numeroCasa.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            numeroCasa.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

            complementoEndereco.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            complementoEndereco.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

            idLogradouro.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            idLogradouro.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

            numeroCasa.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            numeroCasa.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

            complementoEndereco.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            complementoEndereco.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

            senha.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            senha.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);
        }
    }
}
