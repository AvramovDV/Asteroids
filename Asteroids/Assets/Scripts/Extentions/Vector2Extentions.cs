using UnityEngine;

namespace Avramov.Asteroids
{
    public static class Vector2Extentions
    {
        public static Vector2 Rotate(this Vector2 vector, float degreeAngle)
        {
            float radians = degreeAngle * Mathf.Deg2Rad;
            float x = vector.x * Mathf.Cos(radians) + vector.y * Mathf.Sin(radians);
            float y = -vector.x * Mathf.Sin(radians) + vector.y * Mathf.Cos(radians);
            return new Vector2(x, y);
        }
    }
}

