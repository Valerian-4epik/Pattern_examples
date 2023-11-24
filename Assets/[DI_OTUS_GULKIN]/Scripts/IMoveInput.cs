using System;
using UnityEngine;

namespace _DI_OTUS_GULKIN_.Scripts
{
    public interface IMoveInput
    {
        event Action<Vector3> OnMove;
    }
}