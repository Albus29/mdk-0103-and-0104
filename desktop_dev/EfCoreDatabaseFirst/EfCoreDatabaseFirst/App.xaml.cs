﻿using System.Configuration;
using System.Data;
using System.Windows;
using EfCoreDatabaseFirst.DbContexts;

namespace EfCoreDatabaseFirst
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            ShopDbContext dbContext = new ShopDbContext();

        }
    }

}
