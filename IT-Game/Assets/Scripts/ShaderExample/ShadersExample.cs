using UnityEngine;
using System.Collections;

namespace ScriptsShaders
{
    [RequireComponent(typeof(MeshRenderer))]
    public class ShadersExample : MonoBehaviour
    {
        private const float MAX_TRESHOULD = 1;
        private const string TRESHOULD_KEY = "_Treshold";

        private MeshRenderer _meshRenderer;

        private Coroutine _show;

        private void Awake() => _meshRenderer = GetComponent<MeshRenderer>();

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (_show != null)
                    StopCoroutine(_show);

                _show = StartCoroutine(Show());
            }
        }

        private IEnumerator Show()
        {
            float treshold = 0;

            while (treshold < MAX_TRESHOULD)
            {
                treshold += Time.deltaTime;
                _meshRenderer.material.SetFloat(TRESHOULD_KEY, treshold);

                yield return null;
            }
        }
    }
}