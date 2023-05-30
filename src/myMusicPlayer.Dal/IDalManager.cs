using System;

namespace myMusicPlayer.Dal
{
    public interface IDalManager : IDisposable
    {
        T GetProvider<T>() where T : class;
    }
}
