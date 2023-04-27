using System.Collections;
using System.Collections.Generic;
using UniRx;
using VContainer;
using VContainer.Unity;

public class SelectMenuPresenter: IInitializable 
{
    private SelectMenuView _selectMenuView;
    private ILocalStorageService _localStorageService;
    
    [Inject]
    public SelectMenuPresenter(
        SelectMenuView selectMenuView,
        ILocalStorageService localStorageService)
    {
        _selectMenuView = selectMenuView;
        _localStorageService = localStorageService;
    }
        
    
    public void Initialize()
    {
        _selectMenuView._selectSceneId
            .Subscribe(id =>
            {
                _localStorageService.SetLoalStorage("Effect", id);
                _selectMenuView.LoadScene();
            }).AddTo(_selectMenuView);
    }
        
}
