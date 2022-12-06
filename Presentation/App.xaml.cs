using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Presentation.View;

namespace Presentation
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected void ApplicationStart(object sender, StartupEventArgs e)
        {
            var LoginView = new Login();
            LoginView.Show();
            LoginView.IsVisibleChanged += (s, ev) =>
            {
                if (LoginView.IsVisible == false && LoginView.IsLoaded)
                {
                    var mainView = new Assistan();
                    mainView.Show();
                    LoginView.Close();
                }
            };
        }
    }
}
