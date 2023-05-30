using myMusicPlayer.Dal;
using myMusicPlayer.Dal.Dto;
using System.Collections.Generic;
using System.Linq;

namespace myMusicPlayer.DalMock
{
    public class PlaylistDal : IPlaylistDal
    {
        public List<PlaylistDto> Fetch()
        {
            var data = from r in MockDb.MockDb.Playlists
                       select new PlaylistDto
                       {
                           Href = r.Href,
                           Items = r.Items,
                           Limit = r.Limit,
                           Next = r.Next,
                           Offset = r.Offset,
                           Previous = r.Previous,
                           Total = r.Total
                       };

            return data.ToList();
        }
    }
}
