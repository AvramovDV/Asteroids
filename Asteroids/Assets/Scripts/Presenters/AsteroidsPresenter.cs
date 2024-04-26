using System.Collections.Generic;

namespace Avramov.Asteroids
{
    public class AsteroidsPresenter
    {
        private AsteroidsModel _asteroids;
        private SpaceObjectView _spaceObjectView;

        private List<SpaceObjectPresenter> _presenters = new List<SpaceObjectPresenter>();

        public AsteroidsPresenter(AsteroidsModel asteroids, SpaceObjectView view)
        {
            _asteroids = asteroids;
            _spaceObjectView = view;
            _asteroids.AsteroidCreatedEvent += OnAsteroidCreated;
        }

        public void Update()
        {
            foreach (var presenter in _presenters)
            {
                presenter.Update();
            }
        }

        private void OnAsteroidCreated(SpaceObject spaceObject)
        {
            SpaceObjectPresenter presenter = new SpaceObjectPresenter(spaceObject, _spaceObjectView);
            _presenters.Add(presenter);
        }
    }
}

