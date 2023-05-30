using Csla;
using myMusicPlayer.Dal;
using myMusicPlayer.Dal.Dto;
using myMusicPlayer.Dal.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myMusicPlayer.Library
{
    [Serializable]
    public class PlaylistList : ReadOnlyListBase<PlaylistList, PlaylistInfo>
    {
        #region Factory Methods

        public async static Task<PlaylistList> GetPlaylistsAsync()
        {
            return await DataPortal.FetchAsync<PlaylistList>();
        }

        public static PlaylistList GetPlaylists()
        {
            return DataPortal.Fetch<PlaylistList>();
        }

        #endregion

        #region Data Access

        [Fetch]
        private void Fetch()
        {
            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            IsReadOnly = false;

            using (var dalManager = DalFactory.GetManager(DalManagerTypes.DalManagerJson))
            {
                IPlaylistDal dal = dalManager.GetProvider<IPlaylistDal>();
                IList<PlaylistDto> data = null;

                data = dal.Fetch();

                if (data != null)
                {
                    foreach (var item in data)
                    {
                        Add(DataPortal.FetchChild<PlaylistInfo>(item));
                    }
                }

                RaiseListChangedEvents = rlce;
                IsReadOnly = true;
            }
        }

        #endregion
    }
}
