using UnityEngine;

namespace ScriptVirtualMethod
{
    public class PlayerShoot : MonoBehaviour
    {
        [SerializeField] private Gun _gun;

        public void SwitchGun(Gun gun) => _gun = gun;
        public void Shoot() => _gun.Shoot();
    }
}
