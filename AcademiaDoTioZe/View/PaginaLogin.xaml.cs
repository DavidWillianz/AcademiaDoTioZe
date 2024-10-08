﻿using System;
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
    /// Interação lógica para PaginaLogin.xam
    /// </summary>
    public partial class PaginaLogin : Page
    {
        public PaginaLogin()
        {
            InitializeComponent();
            idText.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            idText.LostFocus += (sender, e) => ClassFuncoes.Box_LostFocus(sender, e);
            passwordText.GotFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
            passwordText.LostFocus += (sender, e) => ClassFuncoes.Box_GotFocus(sender, e);
        }

  
    }
}
