using myMusicPlayer.Dal.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myMusicPlayer.Dal
{
    public interface IPlaylistDal
    {
        List<PlaylistDto> Fetch();
    }
}
