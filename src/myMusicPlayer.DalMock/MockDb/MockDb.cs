using myMusicPlayer.Dal.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myMusicPlayer.DalMock.MockDb
{
    public class MockDb
    {
        public static List<PlaylistDto> Playlists { get; private set; }

        static MockDb()
        {
            Playlists = new List<PlaylistDto>
            {
                new PlaylistDto
                {
                    Href = new Uri("https://api.spotify.com/v1/users/1157986284/playlists?offset=0&limit=20"),
                    Items = new ItemDto[]
                    {
                        new ItemDto
                        {
                            Collaborative = false,
                            Description = string.Empty,
                            ExternalUrls = new ExternalUrlDto
                            {
                                Spotify = new Uri("https://open.spotify.com/playlist/0gO5ZZ3mRbLdBMRIYEhdhg")
                            },
                            Href = new Uri("https://api.spotify.com/v1/playlists/0gO5ZZ3mRbLdBMRIYEhdhg"),
                            Id = "0gO5ZZ3mRbLdBMRIYEhdhg",
                            Images = new ImageDto[]
                            {
                                new ImageDto
                                {
                                    Height = 640,
                                    Url = new Uri("https://mosaic.scdn.co/640/ab67616d0000b27346ea47fd9f97917f2ef708f0ab67616d0000b27367f74b459fcbfedbf2eed745ab67616d0000b273b449aec96dcb1c458ab551a8ab67616d0000b273b6aa65ea45fef5e36dfe1a45"),
                                    Width = 640
                                },
                                new ImageDto
                                {
                                    Height = 300,
                                    Url = new Uri("https://mosaic.scdn.co/300/ab67616d0000b27346ea47fd9f97917f2ef708f0ab67616d0000b27367f74b459fcbfedbf2eed745ab67616d0000b273b449aec96dcb1c458ab551a8ab67616d0000b273b6aa65ea45fef5e36dfe1a45"),
                                    Width = 300
                                },
                                new ImageDto
                                {
                                    Height = 60,
                                    Url = new Uri("https://mosaic.scdn.co/60/ab67616d0000b27346ea47fd9f97917f2ef708f0ab67616d0000b27367f74b459fcbfedbf2eed745ab67616d0000b273b449aec96dcb1c458ab551a8ab67616d0000b273b6aa65ea45fef5e36dfe1a45"),
                                    Width = 60
                                }
                            },
                            Name = "Sommar 23❤️",
                            Owner = new OwnerDto
                            {
                                DisplayName = "Molly💋",
                                ExternalUrls = new ExternalUrlDto
                                {
                                    Spotify = new Uri("https://open.spotify.com/user/s1yq4lj3j5oxuvaedwli5gm0g")
                                },
                                Href = new Uri("https://api.spotify.com/v1/users/s1yq4lj3j5oxuvaedwli5gm0g"),
                                Id = "s1yq4lj3j5oxuvaedwli5gm0g",
                                Type = "user",
                                Uri = "spotify:user:s1yq4lj3j5oxuvaedwli5gm0g"
                            },
                            PrimaryColor = null,
                            Public = false,
                            SnapshotId = "MjE2LDE0YmJiNjhlODc0Njk1Y2E5Y2Y2NDE3N2NhNGQ3N2MyNjU0YWMzMjE=",
                            Tracks = new TracksDto
                            {
                                Href = new Uri("https://api.spotify.com/v1/playlists/0gO5ZZ3mRbLdBMRIYEhdhg/tracks"),
                                Total = 174
                            },
                            Type = "playlist",
                            Uri = "spotify:playlist:0gO5ZZ3mRbLdBMRIYEhdhg"
                        },
                        new ItemDto
                        {
                            Collaborative = false,
                            Description = string.Empty,
                            ExternalUrls = new ExternalUrlDto
                            {
                                Spotify = new Uri("https://open.spotify.com/playlist/2rVR93PByqy6XFKDQtDurr")
                            },
                            Href = new Uri("https://api.spotify.com/v1/playlists/2rVR93PByqy6XFKDQtDurr"),
                            Id = "2rVR93PByqy6XFKDQtDurr",
                            Images = new ImageDto[]
                            {
                                new ImageDto
                                {
                                    Height = 640,
                                    Url = new Uri("https://mosaic.scdn.co/640/ab67616d0000b273346d77e155d854735410ed18ab67616d0000b273660a360926b1be8069fcf93cab67616d0000b273994440f8d26344c186980f20ab67616d0000b273ec672b5869165398df80423d"),
                                    Width = 640
                                },
                                new ImageDto
                                {
                                    Height = 300,
                                    Url = new Uri("https://mosaic.scdn.co/300/ab67616d0000b273346d77e155d854735410ed18ab67616d0000b273660a360926b1be8069fcf93cab67616d0000b273994440f8d26344c186980f20ab67616d0000b273ec672b5869165398df80423d"),
                                    Width = 300
                                },
                                new ImageDto
                                {
                                    Height = 60,
                                    Url = new Uri("https://mosaic.scdn.co/60/ab67616d0000b273346d77e155d854735410ed18ab67616d0000b273660a360926b1be8069fcf93cab67616d0000b273994440f8d26344c186980f20ab67616d0000b273ec672b5869165398df80423d"),
                                    Width = 60
                                }
                            },
                            Name = "Bal 2023",
                            Owner = new OwnerDto
                            {
                                DisplayName = "tildeekelöf",
                                ExternalUrls = new ExternalUrlDto
                                {
                                    Spotify = new Uri("https://open.spotify.com/user/tildeekel%C3%B6f")
                                },
                                Href = new Uri("https://api.spotify.com/v1/users/tildeekel%C3%B6f"),
                                Id = "tildeekelöf",
                                Type = "user",
                                Uri = "spotify:user:tildeekel%C3%B6f"
                            },
                            PrimaryColor = null,
                            Public = false,
                            SnapshotId = "MjIyLDMxMDU2YmYyMjlmMzlkY2Q2OWZkNGJkN2UyY2I2NDRmNDZmNjVkODA=",
                            Tracks = new TracksDto
                            {
                                Href = new Uri("https://api.spotify.com/v1/playlists/2rVR93PByqy6XFKDQtDurr/tracks"),
                                Total = 213
                            },
                            Type = "playlist",
                            Uri = "spotify:playlist:2rVR93PByqy6XFKDQtDurr"
                        },
                        new ItemDto
                        {
                            Collaborative = false,
                            Description = string.Empty,
                            ExternalUrls = new ExternalUrlDto
                            {
                                Spotify = new Uri("https://open.spotify.com/playlist/5FR4qYOGOHowrXPTSoveGg")
                            },
                            Href = new Uri("https://api.spotify.com/v1/playlists/5FR4qYOGOHowrXPTSoveGg"),
                            Id = "5FR4qYOGOHowrXPTSoveGg",
                            Images = new ImageDto[]
                            {
                                new ImageDto
                                {
                                    Height = 640,
                                    Url = new Uri("https://mosaic.scdn.co/640/ab67616d0000b2737af0c13dce12e734753b4790ab67616d0000b273bc3f2817c8ae462c79fa924cab67616d0000b273d754d2ef29e3f7dcd73caa3bab67616d0000b273e49806ff277ac693976caa97"),
                                    Width = 640
                                },
                                new ImageDto
                                {
                                    Height = 300,
                                    Url = new Uri("https://mosaic.scdn.co/300/ab67616d0000b2737af0c13dce12e734753b4790ab67616d0000b273bc3f2817c8ae462c79fa924cab67616d0000b273d754d2ef29e3f7dcd73caa3bab67616d0000b273e49806ff277ac693976caa97"),
                                    Width = 300
                                },
                                new ImageDto
                                {
                                    Height = 60,
                                    Url = new Uri("https://mosaic.scdn.co/60/ab67616d0000b2737af0c13dce12e734753b4790ab67616d0000b273bc3f2817c8ae462c79fa924cab67616d0000b273d754d2ef29e3f7dcd73caa3bab67616d0000b273e49806ff277ac693976caa97"),
                                    Width = 60
                                }
                            },
                            Name = "27",
                            Owner = new OwnerDto
                            {
                                DisplayName = "Matilda_141",
                                ExternalUrls = new ExternalUrlDto
                                {
                                    Spotify = new Uri("https://open.spotify.com/user/1157986284")
                                },
                                Href = new Uri("https://api.spotify.com/v1/users/1157986284"),
                                Id = "1157986284",
                                Type = "user",
                                Uri = "spotify:user:1157986284"
                            },
                            PrimaryColor = null,
                            Public = true,
                            SnapshotId = "MTEsYmRiNzdlYWVlNjRmYmFjMjk2NmY5N2ZhZGY4OWEzYjEzOWUzYzcxYw==",
                            Tracks = new TracksDto
                            {
                                Href = new Uri("https://api.spotify.com/v1/playlists/5FR4qYOGOHowrXPTSoveGg/tracks"),
                                Total = 10
                            },
                            Type = "playlist",
                            Uri = "spotify:playlist:5FR4qYOGOHowrXPTSoveGg"
                        }
                    }, 
                    Limit = 20,
                    Next = new Uri("https://api.spotify.com/v1/users/1157986284/playlists?offset=20&limit=20"),
                    Offset = 0,
                    Previous = null,
                    Total = 41
                }
            };
        }
    }
}
