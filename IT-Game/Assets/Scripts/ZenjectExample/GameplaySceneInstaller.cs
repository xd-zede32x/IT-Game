using UnityEngine;
using Zenject;

namespace ScriptsZenject
{
    public class GameplaySceneInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            if (SystemInfo.deviceType == DeviceType.Handheld)
                Container.BindInterfacesAndSelfTo<MobileInput>().AsSingle();

            else
                Container.BindInterfacesAndSelfTo<DesktopInput>().AsSingle();

            Container.Bind<MovementHandler>().AsSingle();
        }
    }
}