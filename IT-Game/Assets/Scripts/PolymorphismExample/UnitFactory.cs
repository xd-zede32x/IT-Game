using UnityEngine;
using System.Collections.Generic;

namespace ScriptPolymorphism
{
    public class UnitFactory : MonoBehaviour
    {
        [SerializeField] private int _minDamage = 10, _maxDamage = 25;
        [SerializeField] private int _minSpeed = 2, _maxSpeed = 5;

        [SerializeField] private Transform _spawnPoint;

        private List<Unit> _units = new List<Unit>();

        public void Create(Unit unit)
        {
            Unit instance = Instantiate(unit);
            instance.Initialize(Random.Range(_minDamage, _maxDamage), Random.Range(_minSpeed, _maxSpeed));
            instance.SpawnTo(_spawnPoint.position);

            _units.Add(instance);
        }

        public void IssueVictoryCry()
        {
            for (int index = 0; index < _units.Count; index++)
                _units[index].IssueCry();
        }   
    }
}