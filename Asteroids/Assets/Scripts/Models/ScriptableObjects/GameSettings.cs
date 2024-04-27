using UnityEngine;

namespace Avramov.Asteroids
{
[CreateAssetMenu(fileName = "GameSettings", menuName = "Asteroids/GameSettings")]
    public class GameSettings : ScriptableObject
    {
        [field: SerializeField] public float GameFieldHeight { get; private set; }
        [field: SerializeField] public float GameFieldWidth { get; private set; }
        [field: SerializeField] public float AsteroidsSpawnRate { get; private set; }
        [field: SerializeField] public SpaceShipSettings ShipSettings { get; private set; }
        [field: SerializeField] public AsteroidSettings AsteroidSettings { get; private set;}
        [field: SerializeField] public BulletSettings BulletSettings { get; private set; }
        [field: SerializeField] public MeteorsSettings MeteorsSettings { get; private set;}
        [field: SerializeField] public AlienSettings AlienSettings { get; private set;}
        [field: SerializeField] public LaserSettings LaserSettings { get; private set; }

        public SpaceData GetSpaceData() => new SpaceData(GameFieldWidth, GameFieldHeight);

        public ShipModel GetShipModel() => new ShipModel(ShipSettings, GetSpaceData());

        public AsteroidModel GetAsteroidModel()
        {
            float x = Random.Range(-GameFieldWidth * 0.5f, GameFieldWidth * 0.5f);
            Vector2 position = new Vector2(x, GameFieldHeight * 0.5f);
            float angle = Random.Range(0f, 360f);
            AsteroidModel asteroid = new AsteroidModel(GetSpaceData(), position, angle,AsteroidSettings.Speed);
            return asteroid;
        }

        public BulletModel GetBulletModel(ShipModel ship) => new BulletModel(GetSpaceData(), BulletSettings.LifeTime, ship.Position, ship.Angle, BulletSettings.Speed);

        public MeteorModel GetMeteorModel(Vector2 position)
        {
            float angle = Random.Range(0f, 360f);
            MeteorModel meteor = new MeteorModel(GetSpaceData(), position, angle, MeteorsSettings.Speed);
            return meteor;
        }

        public AlienModel GetAlien(SpaceObject target)
        {
            float x = Random.Range(-GameFieldWidth * 0.5f, GameFieldWidth * 0.5f);
            Vector2 position = new Vector2(x, GameFieldHeight * 0.5f);
            AlienModel alien = new AlienModel(GetSpaceData(), target, position, 0f, AlienSettings.Speed);
            return alien;
        }
    }
}

