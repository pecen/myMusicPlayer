using myMusicPlayer.UI.Wpf.Core;
using System.Runtime.InteropServices;
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

        public RelayCommand ShowHomeViewCommand { get; set; }
        public RelayCommand ShowPlaylistsViewCommand { get; set; }
        public RelayCommand ShowArtistsViewCommand { get; set; }

        #endregion

        #region Properties

        private ViewModelBase _currentView;
        public ViewModelBase CurrentView
        {
            get { return _currentView; }
            set { SetProperty(ref _currentView, value); }
        }

        #endregion

        #region ViewModels

        public HomeViewViewModel HomeViewVM { get; set; }
        public PlaylistsViewViewModel PlaylistsViewVM { get; set; }
        public ArtistsViewViewModel ArtistsViewVM { get; set; }

        #endregion

        public MainWindowViewModel()
        {
            HomeViewVM = new HomeViewViewModel();
            PlaylistsViewVM = new PlaylistsViewViewModel();
            ArtistsViewVM = new ArtistsViewViewModel();

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

            ShowHomeViewCommand = new RelayCommand(o => CurrentView = HomeViewVM);
            
            ShowPlaylistsViewCommand = new RelayCommand(o => CurrentView = PlaylistsViewVM);

            ShowArtistsViewCommand = new RelayCommand(o => CurrentView = ArtistsViewVM);
        }
    }
}
