using Zenject;
using UnityEngine;

namespace ScriptsZenject
{
    public class GlobalInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            if (SystemInfo.deviceType == DeviceType.Handheld)
                Container.BindInterfacesAndSelfTo<MobileInput>().AsSingle();

            else
                Container.BindInterfacesAndSelfTo<DesktopInput>().AsSingle();
        }
    }
}   