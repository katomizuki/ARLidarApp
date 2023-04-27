using UniRx;
using UniRx.Triggers;
using UnityEngine;
using VContainer;
using VContainer.Unity;

public class MainARPresenter : IInitializable 
{
    private readonly MainARView _mainARView;
    private readonly IMainARService _mainARService;
    private readonly ARLidarEffect _arLidarEffect;
   
    
    [Inject]
    public MainARPresenter(
        MainARView mainARView, 
        IMainARService mainARService, 
        ARLidarEffect arLidarEffect)
    {
        _mainARView = mainARView;
        _mainARService = mainARService;
        _arLidarEffect = arLidarEffect;
        Debug.Log(arLidarEffect+"きたーーーー");
    }

    public void Initialize()
    {
        
        
        _mainARView.lifeCycleAwake
            .Subscribe(_ =>
            {
                var lidarSupported = _mainARService.IsARLidarSupported();
                if (!lidarSupported)
                {
                    _mainARView.showErrorOnLidar();
                    return;
                }
            }).AddTo(_mainARView);

        _mainARView.UpdateAsObservable()
            .Subscribe(_ =>
            {
                
            }).AddTo(_mainARView);
    }
}
