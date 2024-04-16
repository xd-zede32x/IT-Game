using UnityEngine;

namespace ScriptPolymorphism
{
    public abstract class Unit : MonoBehaviour
    {
        protected int Damage;
        protected int Speed;

        public void Initialize(int damage, int speed)
        {
            Damage = damage;
            Speed = speed;
        }

        public void SpawnTo(Vector3 spawnPosition)
        {
            Vector2 randomPosition = Random.insideUnitCircle * 3;
            transform.position = spawnPosition + new Vector3(randomPosition.x, 0f, randomPosition.y);
        }

        public abstract void IssueCry();
    }
}