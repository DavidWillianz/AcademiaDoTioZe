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
    /// Interação lógica para PaginaCadastroAluno.xam
    /// </summary>
    public partial class PaginaCadastroAluno : Page
    {
        public PaginaCadastroAluno()
        {
            InitializeComponent();
            this.Loaded += Page_Loaded;

            idAluno.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            idAluno.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

            cpfAluno.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            cpfAluno.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

            telefoneAluno.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            telefoneAluno.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

            nomeAluno.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            nomeAluno.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

            emailAluno.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            emailAluno.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

            //----
            idLogradouro.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            idLogradouro.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

            numero.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            numero.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

            complemento.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            complemento.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);

            senha.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            senha.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ClassFuncoes.AjustaResources(this);
        }
    }
}
