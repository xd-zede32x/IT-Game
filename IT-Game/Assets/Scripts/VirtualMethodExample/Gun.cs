using UnityEngine;

namespace ScriptVirtualMethod
{
    public class Gun : MonoBehaviour
    {
        [SerializeField] protected float ReloadTime; // ����� �����������.
        protected float CurrentReloadTime; // ���� ������� ����� �����������.

        [SerializeField] protected Bullet BulletPrefab; // Prefab ����� ����.
        [SerializeField] protected Transform BulletSpawnPoint; // ����� � ������� ����� �������� ����.

        private void Update() 
        {
            if (CurrentReloadTime > 0) // �������� ��� ������� ����� ����������� ������ > 0.
                CurrentReloadTime -= Time.deltaTime; // �������� �����
        }

        public virtual void Shoot() // ����� ��� ��������.
        {
            if (CurrentReloadTime <= 0 && BulletPrefab != null) 
            {
                Bullet bullet = Instantiate(BulletPrefab, BulletSpawnPoint.position, Quaternion.identity);
                CurrentReloadTime = ReloadTime;
            }
        }
    }
}