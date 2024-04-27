using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Avramov.Asteroids
{
    public class GameOverScreen : MonoBehaviour
    {
        [field: SerializeField] public TMP_Text CountText { get; private set; }
        [field: SerializeField] public Button RestartButton { get; private set; }
    }
}

