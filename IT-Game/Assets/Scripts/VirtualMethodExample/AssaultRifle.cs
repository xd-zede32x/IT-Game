using UnityEngine;
using System.Collections;

namespace ScriptVirtualMethod
{
    public class AssaultRifle : Gun
    {
        [SerializeField] private int _bulletsInQueue;
        [SerializeField] private float _fireRate;

        public override void Shoot()
        {
            if (CurrentReloadTime <= 0)
            {
                StartCoroutine(FiringBurst());
                CurrentReloadTime = ReloadTime;
            }
        }

        private IEnumerator FiringBurst()
        {
            for (int index = 0; index < _bulletsInQueue; index++)
            {
                Bullet bullet = Instantiate(BulletPrefab, BulletSpawnPoint.position, Quaternion.identity);
                yield return new WaitForSeconds(_fireRate);
            }
        }
    }
}