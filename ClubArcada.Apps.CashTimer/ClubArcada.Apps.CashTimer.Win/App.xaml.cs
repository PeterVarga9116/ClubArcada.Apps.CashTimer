using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ClubArcada.Common.BusinessObjects.DataClasses;

namespace ClubArcada.Apps.CashTimer.Win
{
    public partial class App : Application
    {
        public static User User { get; set; }

        public static CashGame CashGame { get; set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
        }
    }
}
