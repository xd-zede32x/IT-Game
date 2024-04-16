using UnityEngine;
using ScriptInterface;

public class Shooter : MonoBehaviour
{
    [SerializeField] private int _damageValue;
    [SerializeField] private Transform _targetPosition;

    private Camera _camera;

    private void Awake() => _camera = Camera.main;

    private void Update()
    {
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            _targetPosition.position = hit.point;

            if (Input.GetMouseButtonDown(0) && hit.collider.TryGetComponent(out IDamageable damageable))
                damageable.ApplyDamage(_damageValue);
        }
    }
}