using UnityEngine;

namespace ScriptVirtualMethod
{
    public class Gun : MonoBehaviour
    {
        [SerializeField] protected float ReloadTime; // Время перезарядки.
        protected float CurrentReloadTime; // Наше текущие время перезарядки.

        [SerializeField] protected Bullet BulletPrefab; // Prefab самой пули.
        [SerializeField] protected Transform BulletSpawnPoint; // Точка в которой будет спавнить пуля.

        private void Update() 
        {
            if (CurrentReloadTime > 0) // Проверка что Текущие время перезарядки больше > 0.
                CurrentReloadTime -= Time.deltaTime; // Вычитаем время
        }

        public virtual void Shoot() // Метод для стрельбы.
        {
            if (CurrentReloadTime <= 0 && BulletPrefab != null) 
            {
                Bullet bullet = Instantiate(BulletPrefab, BulletSpawnPoint.position, Quaternion.identity);
                CurrentReloadTime = ReloadTime;
            }
        }
    }
}