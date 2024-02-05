using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using KR2_Nizamiev.Models;

namespace KR2_Nizamiev
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static KR2_NizamievAdelEntities DB = new KR2_NizamievAdelEntities();
    }
}
