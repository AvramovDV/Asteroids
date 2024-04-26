using System;
using System.Collections.Generic;
using UnityEngine;

namespace Avramov.Asteroids
{
[CreateAssetMenu(fileName = "Assets", menuName = "Asteroids/Assets")]
    public class Assets : ScriptableObject
    {
        [Serializable]
        public class SpaceObjectAsset
        {
            [field: SerializeField] public SpaceObjectType SpaceObjectType { get; private set; }
            [field: SerializeField] public SpaceObjectView Prefab { get; private set; }
        }

        [SerializeField] private List<SpaceObjectAsset> _spaceObjects;

        public SpaceObjectView GetPrefab(SpaceObjectType spaceObjectType) => _spaceObjects.Find(x => x.SpaceObjectType == spaceObjectType).Prefab;
    }
}

