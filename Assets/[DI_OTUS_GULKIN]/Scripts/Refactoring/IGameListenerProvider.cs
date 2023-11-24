using System.Collections.Generic;

namespace _DI_OTUS_GULKIN_.Scripts.Refactoring
{
    //IGameListenerProvider предоставляет слушателей для регистрации в GameContext.
    public interface IGameListenerProvider
    {
        IEnumerable<object> GetListeners();
    }
}