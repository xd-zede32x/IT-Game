using Zenject;
using UnityEngine;

namespace ScriptsZenject
{
    public class GameplaySceneInstaller :  MonoInstaller
    {
        [SerializeField] private Player _player;
        [SerializeField] private Transform _playerSpawnPoints;
        [SerializeField] private PlayerConfig _playerConfig;

        public override void InstallBindings()
        {
            BindPlayer();
            BindMovementService();
        }

        private void BindPlayer()
        {
            Container.Bind<PlayerConfig>().FromInstance(_playerConfig);
            Player player = Container.InstantiatePrefabForComponent<Player>(_player, _playerSpawnPoints.position, Quaternion.identity, null);
            Container.BindInterfacesAndSelfTo<Player>().FromInstance(player).AsSingle();

        }

        private void BindMovementService() => Container.Bind<MovementHandler>().AsSingle().NonLazy();
    }
}