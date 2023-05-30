using myMusicPlayer.Library;
using myMusicPlayer.UI.Wpf.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace myMusicPlayer.UI.Wpf.ViewModel
{
    public class PlaylistsViewViewModel : ViewModelBase
    {
        private ObservableCollection<PlaylistInfo> _playlists;
        public ObservableCollection<PlaylistInfo> Playlists
        {
            get { return _playlists; }
            set { SetProperty(ref _playlists, value); }
        }

        public PlaylistsViewViewModel()
        {
            Title = "Playlists";

            Playlists = PlaylistList.GetPlaylists();
            

        }
    }
}
