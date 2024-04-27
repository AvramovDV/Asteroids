using System.Collections.Generic;
using UnityEngine;

namespace Avramov.Asteroids
{
    public class SpaceData
    {
        private float _width;
        private float _height;

        private float _borderUp;
        private float _borderDown;
        private float _borderLeft;
        private float _borderRight;

        //private List<SpaceObject> _spaceObjects = new List<SpaceObject>();

        public SpaceData(float spaceWidth, float spaceHeight)
        {
            _width = spaceWidth;
            _height = spaceHeight;

            _borderUp = spaceHeight * 0.5f;
            _borderDown = -spaceHeight * 0.5f;
            _borderLeft = -spaceWidth * 0.5f;
            _borderRight = spaceWidth * 0.5f;
        }

        //public void AddObjectToSpace(SpaceObject spaceObject)
        //{
        //    _spaceObjects.Add(spaceObject);
        //}

        //public void RemoveObjectFromSpace(SpaceObject spaceObject)
        //{
        //    _spaceObjects.Remove(spaceObject);
        //}

        //public void MoveSpaceObjects()
        //{
        //    for (int i = 0; i < _spaceObjects.Count; i++)
        //    {
        //        _spaceObjects[i].Move();
        //    }
        //}

        public Vector2 ApplyBorders(Vector2 targetPosition)
        {
            float xCorrection = targetPosition.x > _borderRight ? -_width : targetPosition.x < _borderLeft ? _width : 0f;
            float yCorrection = targetPosition.y > _borderUp ? -_height : targetPosition.y < _borderDown ? _height : 0f;
            targetPosition.x += xCorrection;
            targetPosition.y += yCorrection;
            return targetPosition;
        }
    }
}

