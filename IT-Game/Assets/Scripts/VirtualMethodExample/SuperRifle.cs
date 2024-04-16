using UnityEngine;

namespace ScriptVirtualMethod
{
    public class SuperRifle : Gun
    {
        public override void Shoot()
        {
            if (CurrentReloadTime <= 0)
            {
                for (int index = -1; index < 2; index++)
                {
                    Bullet bullet = Instantiate(BulletPrefab, BulletSpawnPoint.position + Vector3.right * index, Quaternion.identity);
                }

                CurrentReloadTime = ReloadTime;
            }
        }
    }
}