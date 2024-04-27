using System;
using System.Collections.Generic;

namespace Avramov.Asteroids
{
    public class SpaceObjectsPresenter
    {
        private GameModel _gameModel;
        private SpaceObjects _spaceObjects => _gameModel.SpaceObjects;

        private Assets _assets;

        private List<SpaceObjectPresenter> _presenters = new List<SpaceObjectPresenter>();

        public SpaceObjectsPresenter(GameModel gameModel, Assets assets)
        {
            _gameModel = gameModel;
            _assets = assets;
        }

        public void Initialize()
        {
            _spaceObjects.SpaceObjectAddedEvent += OnAddSpaceObjcet;
        }

        private void OnAddSpaceObjcet(SpaceObject spaceObj)
        {
            SpaceObjectPresenter presenter = new SpaceObjectPresenter(spaceObj, _assets.GetPrefab(spaceObj.SpaceObjectType));
            _presenters.Add(presenter);
        }

        private void OnPresenterDestroyed(SpaceObjectPresenter presenter)
        {
            presenter.DestroyedEvent -= OnPresenterDestroyed;
            _presenters.Remove(presenter);
        }
    }
}

