using System.Collections.Generic;

namespace _DI_OTUS_GULKIN_.Scripts.Refactoring
{
    public interface IGameServiceProvider
    {
        IEnumerable<object> GetServices();
    }
}