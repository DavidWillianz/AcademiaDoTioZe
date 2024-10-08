﻿using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Windows.Shapes;

namespace AcademiaDoTioZe.View
{
    /// <summary>
    /// Lógica interna para WindowConfig.xaml
    /// </summary>
    public partial class WindowConfig : Window
    {
        // Atributos para conexão e persistência com o banco de dados
        private string ConnectionString { get; set; }
        private string ProviderName { get; set; }
        public WindowConfig()
        {
            InitializeComponent();
            //busca os dados de conexão com o banco de dados, do arquivo de configuração
            ProviderName = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            ConnectionString = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

            // seleciona no comboBox o idioma/cultura atual
            // comboBoxIdioma.SelectedItem = ConfigurationManager.AppSettings.Get("IdiomaRegiao");
            // atribui os valores aos controles da janela
            comboBoxProvider.SelectedItem = ProviderName;
            textBoxStringDeConexao.Text = ConnectionString;
            this.KeyDown += new System.Windows.Input.KeyEventHandler(ClassFuncoes.Window_KeyDown);
        }
        private void EncerrarAplicacao_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
        // código do salvar idioma
        // código do salvar bd
        private void SalvaIdioma_Click(object sender, RoutedEventArgs e)
        {

        }

        //private void SalvaIdioma_Click(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //        //abre o arquivo local como leitura/escrita e salva as alterações em AcademiaDoZe_WPF.dll.config
        //        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        //        config.AppSettings.Settings.Remove("IdiomaRegiao");
        //        config.AppSettings.Settings.Add("IdiomaRegiao", comboBoxIdioma.Text);
        //        config.Save(ConfigurationSaveMode.Modified);
        //        ConfigurationManager.RefreshSection("appSettings");
        //        ClassFuncoes.AjustaIdiomaRegiao(); _ = MessageBox.Show("Idioma/região alterada com sucesso!");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        Close();
        //    }
        //}

        private void SalvaBD_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //abre o arquivo local como leitura/escrita - ControleEstoqueDoZe.exe.config
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                //altera os valores de provider e da connectionStrings com nome BD
                config.ConnectionStrings.ConnectionStrings["BD"].ProviderName = comboBoxProvider.Text;
                config.ConnectionStrings.ConnectionStrings["BD"].ConnectionString = textBoxStringDeConexao.Text;
                config.Save(ConfigurationSaveMode.Modified, true);
                ConfigurationManager.RefreshSection("connectionStrings"); _ = MessageBox.Show("Dados alterados com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Close();
            }
        }
    }
}
