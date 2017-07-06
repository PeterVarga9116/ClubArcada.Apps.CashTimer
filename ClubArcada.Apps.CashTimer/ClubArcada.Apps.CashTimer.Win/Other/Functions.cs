using ClubArcada.Common;
using System;
using System.ComponentModel;

namespace ClubArcada.Apps.CashTimer.Win.Other
{
    public class Functions
    {
        public static void CreateProtocolItem(Guid userId, Guid cashGameId, string text)
        {
            //TODO: uncomment if ready to live
            Functions.RunAsync(() =>
            {
                var protocolItem = new ClubArcada.Common.BusinessObjects.DataClasses.CashGameProtocolItem(userId, cashGameId, text);
                App.ProtocolItems.Add(protocolItem);
                //protocolItem.Save(App.CR);
            });
        }

        public static void RunAsync(Action action, Action callcack = null)
        {
            var bw = new BackgroundWorker();
            bw.RunWorkerCompleted += delegate
            {
                if (callcack.IsNotNull())
                    callcack();
            };
            bw.DoWork += delegate
            {
                if (action.IsNotNull())
                    action();
            };

            bw.RunWorkerAsync();
        }
    }
}
