using UniRx;
using UniRx.Triggers;
using VContainer;
using VContainer.Unity;

public class MainARPresenter : IInitializable 
{
    private readonly MainARView _mainARView;
    private readonly IMainARService _mainARService;
    private readonly IAROverlayService _arOverlayService;
    
    [Inject]
    public MainARPresenter(
        MainARView mainARView, 
        IMainARService mainARService,
        IAROverlayService arOverlayService)
    {
        _mainARView = mainARView;
        _mainARService = mainARService;
        _arOverlayService = arOverlayService;
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
