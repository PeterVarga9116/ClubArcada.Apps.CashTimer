using ClubArcada.Common.BusinessObjects.DataClasses;
using System;
using System.ComponentModel;
using System.Windows.Input;

namespace ClubArcada.Apps.CashTimer.Win.DataClasses
{
    public class CashPlayerDto : CashPlayer, INotifyPropertyChanged
    {
        public CashPlayerDto(Guid adminUserId, Guid cashTableId, Guid userId)
        {
            base.New(adminUserId, cashTableId, userId);
        }

        public void _playPause()
        {
            ToogleRunning();
        }
        private ICommand _btnTooglePlayPauseClick;
        public ICommand btnTooglePlayPauseClick
        {
            get
            {
                return _btnTooglePlayPauseClick ?? (_btnTooglePlayPauseClick = new CommandHandler(() => _playPause(), true));
            }
        }

        private void _transfer()
        { }
        private ICommand _btnTransferClick;
        public ICommand btnTransferClick
        {
            get
            {
                return _btnTransferClick ?? (_btnTransferClick = new CommandHandler(() => _transfer(), true));
            }
        }

        private void _cashIn()
        { }
        private ICommand _btnCashInClick;
        public ICommand btnCashInClick
        {
            get
            {
                return _btnCashInClick ?? (_btnCashInClick = new CommandHandler(() => _cashIn(), true));
            }
        }

        private void _cashOut()
        { }
        private ICommand _btnCashOutClick;
        public ICommand btnCashOutClick
        {
            get
            {
                return _btnCashOutClick ?? (_btnCashOutClick = new CommandHandler(() => _cashOut(), true));
            }
        }

        private void _bonus()
        { }
        private ICommand _btnBonusClick;
        public ICommand btnBonusClick
        {
            get
            {
                return _btnBonusClick ?? (_btnBonusClick = new CommandHandler(() => _bonus(), true));
            }
        }
    }
}
