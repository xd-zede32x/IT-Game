using TMPro;
using UnityEngine;

namespace ScriptHealthBar
{
    public class DamageDisplay : MonoBehaviour
    {
        [SerializeField] private TextMesh _textPlayerDamage;
        [SerializeField] private Transform _spawnPoint;

        [SerializeField] private float _maxOffset;
        [SerializeField] private float _minOffset;

        private float _offset;

        public void SetDamage(int damage)
        {
            _offset = Random.Range(_minOffset, _maxOffset);
            TextMesh text = Instantiate(_textPlayerDamage, new Vector3(_spawnPoint.position.x + _offset, _spawnPoint.position.y, _spawnPoint.position.z), Quaternion.identity);
            text.text = damage.ToString();  
        }
    }
}