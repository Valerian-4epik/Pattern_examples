using System;
using System.Collections.Generic;
using _DI_OTUS_GULKIN_.Scripts.Refactoring;
using UnityEngine;

//Многие опытные разработчики считают, что Service Locator — это анти - паттерн, так как при его использовании все классы
// жестко зависят от этого посредника, тем самым призывают вместо него использовать DI фреймворки.

namespace _DI_OTUS_GULKIN_.Scripts.ServiceLocators
{
    public sealed class GameLocator : MonoBehaviour, IGameMachine
    {
        private readonly List<object> _services = new();

        public void AddService(object service)
        {
            _services.Add(service);
        }

        public void RemoveService(object service)
        {
            _services.Remove(service);
        }

        public T GetService<T>()
        {
            foreach (var service in _services)
            {
                if (service is T result)
                {
                    return result;
                }
            }

            throw new Exception($"Service of type {typeof(T)} is not found!");
        }
    }
}