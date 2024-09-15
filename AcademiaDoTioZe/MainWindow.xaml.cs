using System.Globalization;
using System.Text;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChangeLanguage(string cultureCode)
        {
            // en-US, es-ES, pt-BR
            // Definir a cultura
            CultureInfo culture = new CultureInfo(cultureCode);
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            // Recargar a interface do usuário para refletir as mudanças
            var oldWindow = this;
            var newWindow = new MainWindow();
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
            oldWindow.Close();
        }

        private void BotaoHome(object sender, RoutedEventArgs e)
        {

        }

        private void BotaoLogradouro(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new PaginaLogradouro();
        }

        private void BotaoCadastroAluno(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new PaginaCadastroAluno();
        }

        private void BotaoCadastroColaborador(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new PaginaCadastroColaborador();
        }

        private void BotaoCadastroSenha(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new PaginaCadastroSenha();
        }

        private void BotaoCadastroMatricula(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new PaginaCadastroMatricula();
        }

        private void BotaoCadastroAvaliacao(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new PaginaAvaliacaoFisica();
        }

        private void BotaoCadastroFrequencia(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new PaginaFrequencia();
        }

        private void BotaoCadastroAulas(object sender, RoutedEventArgs e)
        {

        }

        private void BotaoTreinos(object sender, RoutedEventArgs e)
        {

        }

        private void BotaoLoginLogout(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new PaginaLogin();
        }

        private void BotaoPortugues(object sender, RoutedEventArgs e)
        {
            ChangeLanguage("pt-BR");
        }

        private void BotaoEspanhol(object sender, RoutedEventArgs e)
        {
            ChangeLanguage("en-US");
        }

        private void BotaoIngles(object sender, RoutedEventArgs e)
        {
            ChangeLanguage("es-ES");
        }
    }
}