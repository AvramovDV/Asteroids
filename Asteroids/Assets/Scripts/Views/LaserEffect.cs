using UnityEngine;

namespace Avramov.Asteroids
{
    public class LaserEffect : MonoBehaviour
    {
        [SerializeField] private AnimationCurve _brightnessCurve;
        [SerializeField] private SpriteRenderer _renderer;
        [SerializeField] private Color _brightColor;
        [SerializeField] private float _speed;

        private float value = 0f;

        private void Update()
        {
            value += _speed * Time.deltaTime;
            _renderer.color = Color.Lerp(Color.clear, _brightColor, _brightnessCurve.Evaluate(value));

            if (value >= 1f )
            {
                Destroy(gameObject);
            }
        }
    }
}

