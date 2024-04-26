using UnityEngine;
using TMPro;

namespace Avramov.Asteroids
{
    public class HUD : MonoBehaviour
    {
        [field: SerializeField] public TMP_Text ScoreText;
        [field: SerializeField] public TMP_Text CoordinatesText;
        [field: SerializeField] public TMP_Text AngleText;
        [field: SerializeField] public TMP_Text SpeedText;
        [field: SerializeField] public TMP_Text LaserStrikesText;
        [field: SerializeField] public TMP_Text LaserReloadingText;

    }
}

