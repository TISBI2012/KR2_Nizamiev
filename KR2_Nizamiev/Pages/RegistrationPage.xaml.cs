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
using KR2_Nizamiev.Models;
using KR2_Nizamiev.Pages;

namespace KR2_Nizamiev.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        User contextUser;
        public RegistrationPage()
        {
           
            InitializeComponent();
            User user = new User();
            contextUser = user;
            DataContext = contextUser;

        }

        private void BReg_Click(object sender, RoutedEventArgs e)
        {
            if (contextUser.id == 0)
            {
                App.DB.User.Add(contextUser);
                App.DB.SaveChanges();
                NavigationService.GoBack();
            }
        }

        private void BVihod_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
