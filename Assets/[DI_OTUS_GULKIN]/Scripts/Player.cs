using UnityEngine;

namespace _DI_OTUS_GULKIN_.Scripts
{
    public sealed class Player : MonoBehaviour, IPlayer
    {
        [SerializeField] private float _speed = 2.0f;

        public void Move(Vector3 direction)
        {
            transform.position += direction * _speed * Time.deltaTime;
        }
    }
}