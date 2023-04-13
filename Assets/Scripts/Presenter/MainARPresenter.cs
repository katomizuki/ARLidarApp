using UniRx;
using UniRx.Triggers;
using VContainer;
using VContainer.Unity;

public class MainARPresenter : IInitializable 
{
    private readonly MainARView _mainARView;
    private readonly IMainARService _mainARService;
    
    [Inject]
    public MainARPresenter(MainARView mainARView, IMainARService mainARService)
    {
        _mainARView = mainARView;
        _mainARService = mainARService;
    }

    public void Initialize()
    {
        
        
        _mainARView.lifeCycleAwake
            .Subscribe(_ =>
            {
                var lidarSupported = _mainARService.IsARLidarSupported(); 
                if (!lidarSupported) _mainARView.showErrorOnLidar();
            }).AddTo(_mainARView);

        _mainARView.UpdateAsObservable()
            .Subscribe(_ =>
            {
                
            }).AddTo(_mainARView);
    }
}
