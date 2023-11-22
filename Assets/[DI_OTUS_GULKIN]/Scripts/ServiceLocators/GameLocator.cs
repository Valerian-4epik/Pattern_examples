using System;
using System.Collections.Generic;
using UnityEngine;

namespace _DI_OTUS_GULKIN_.Scripts.ServiceLocators
{
    public sealed class GameLocator : MonoBehaviour
    {
        private readonly List<object> services = new();

        public void AddService(object service)
        {
            this.services.Add(service);
        }

        public void RemoveService(object service)
        {
            this.services.Remove(service);
        }

        public T GetService<T>()
        {
            foreach (var service in this.services)
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