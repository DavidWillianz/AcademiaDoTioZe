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
    /// Interação lógica para PaginaCadastroSenha.xam
    /// </summary>
    public partial class PaginaCadastroSenha : Page
    {
        public PaginaCadastroSenha()
        {
            InitializeComponent();
            id.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            id.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

            cpf.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            cpf.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

            nome.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            nome.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

            senha.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            senha.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

            confirmSenha.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            confirmSenha.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

        }
    }
}
