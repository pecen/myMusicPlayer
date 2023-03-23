using myMusicPlayer.UI.Wpf.Core;
using System.Windows;

namespace myMusicPlayer.UI.Wpf.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        #region Commands

        public RelayCommand MoveWindowCommand { get; set; }
        public RelayCommand ShutdownWindowCommand { get; set; }
        public RelayCommand MinimizeWindowCommand { get; set; }
        public RelayCommand MaximizeWindowCommand { get; set; }

        #endregion

        #region Properties

        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { SetProperty(ref _currentView, value); }
        }

        #endregion

        #region ViewModels

        public HomeViewViewModel HomeViewVM { get; set; }

        #endregion

        public MainWindowViewModel()
        {
            HomeViewVM = new HomeViewViewModel();

            _currentView = HomeViewVM;

            MoveWindowCommand = new RelayCommand(o => { Application.Current.MainWindow.DragMove(); });
            ShutdownWindowCommand = new RelayCommand(o => { Application.Current.Shutdown(); });
            MinimizeWindowCommand = new RelayCommand(o => { Application.Current.MainWindow.WindowState = WindowState.Minimized; });

            MaximizeWindowCommand = new RelayCommand(o =>
            {
                if (Application.Current.MainWindow.WindowState == WindowState.Maximized)
                {
                    Application.Current.MainWindow.WindowState = WindowState.Normal;
                }
                else
                {
                    Application.Current.MainWindow.WindowState = WindowState.Maximized;
                }
            });
        }
    }
}
