using UnityEngine;
using UnityEngine.UI;

namespace IngameDebugConsole
{
    public class FpsCounter : MonoBehaviour
    {
        [SerializeField] private Text _label;


        private float deltaTime = 0.0f;

        private void Update()
        {
            deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;
            var fps = Mathf.RoundToInt(1.0f / deltaTime);
            _label.text = fps.ToString();
        }
    }
}