using Csla;
using myMusicPlayer.Dal.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Documents;

namespace myMusicPlayer.Library
{
    [Serializable]
    public class PlaylistInfo : ReadOnlyBase<PlaylistInfo>
    {
        #region Properties

        public static readonly PropertyInfo<Uri> HrefProperty = RegisterProperty<Uri>(c => c.Href);
        public Uri Href
        {
            get { return GetProperty(HrefProperty); }
            set { LoadProperty(HrefProperty, value); }
        }

        public static readonly PropertyInfo<List<ItemDto>> ItemsProperty = RegisterProperty<List<ItemDto>>(c => c.Items);
        public List<ItemDto> Items
        {
            get { return GetProperty(ItemsProperty); }
            set { LoadProperty(ItemsProperty, value); }
        }

        public static readonly PropertyInfo<long> LimitProperty = RegisterProperty<long>(c => c.Limit);
        public long Limit
        {
            get { return GetProperty(LimitProperty); }
            set { LoadProperty(LimitProperty, value); }
        }

        public static readonly PropertyInfo<Uri> NextProperty = RegisterProperty<Uri>(c => c.Next);
        public Uri Next
        {
            get { return GetProperty(NextProperty); }
            set { LoadProperty(NextProperty, value); }
        }

        public static readonly PropertyInfo<long> OffsetProperty = RegisterProperty<long>(c => c.Offset);
        public long Offset
        {
            get { return GetProperty(OffsetProperty); }
            set { LoadProperty(OffsetProperty, value); }
        }

        public static readonly PropertyInfo<object> PreviousProperty = RegisterProperty<object>(c => c.Previous);
        public object Previous
        {
            get { return GetProperty(PreviousProperty); }
            set { LoadProperty(PreviousProperty, value); }
        }

        public static readonly PropertyInfo<long> TotalProperty = RegisterProperty<long>(c => c.Total);
        public long Total
        {
            get { return GetProperty(TotalProperty); }
            set { LoadProperty(TotalProperty, value); }
        }

        #endregion

        #region Data Access

        [FetchChild]
        private void Child_Fetch(PlaylistDto item)
        {
            Href = item.Href;
            Items = item.Items.ToList();
            Limit = item.Limit;
            Next = item.Next;
            Offset = item.Offset;
            Previous = item.Previous;
            Total = item.Total;
        }

        #endregion
    }
}
