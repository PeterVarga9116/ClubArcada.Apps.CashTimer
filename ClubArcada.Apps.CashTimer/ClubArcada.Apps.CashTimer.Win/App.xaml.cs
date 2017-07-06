using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ClubArcada.Common.BusinessObjects.DataClasses;
using ClubArcada.Common;
using System.ComponentModel;
using ClubArcada.Apps.CashTimer.Win.Other;

namespace ClubArcada.Apps.CashTimer.Win
{
    public partial class App : Application
    {
        public static User User { get; set; }

        public static CashGame CashGame { get; set; }

        public static List<CashGameProtocolItem> ProtocolItems { get; set; }

        public static void UpdateOnline()
        {
            Functions.RunAsync(() => 
            {

            });
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ProtocolItems = new List<CashGameProtocolItem>();
        }

        private static string _cs = "Data Source=82.119.117.77;Initial Catalog=ACDB_DEV;User ID=ACDB_user; Password=ULwEsjcpDxjKLbL5";
        public static Credentials CR
        {
            get
            {
                if(User.IsNotNull())
                {
                    return new Credentials(User.Id, (int)eApplication.Cashtimer, _cs);
                }
                else
                {
                    return null;
                }
            }
        }
            
    }
}
