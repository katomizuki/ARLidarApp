using UniRx;
using VContainer;
using VContainer.Unity;

public class MainARPresenter : IInitializable 
{
    private readonly MainARView _mainARView;
    private readonly IMainARService _mainARService;
   
    
    [Inject]
    public MainARPresenter(
        MainARView mainARView, 
        IMainARService mainARService)
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
                if (!lidarSupported)
                {
                    _mainARView.ShowErrorOnLidar();
                    return;
                }

                var material = _mainARService.GetARMaterial();
                _mainARView.ShowAREffect(material);
            }).AddTo(_mainARView);

        _mainARView.ObserveEveryValueChanged(view => view.isTapButton.Value)
            .Subscribe(value =>
            {
                if (value) _mainARView.BackMenuScene(); 
            }).AddTo(_mainARView);
    }
}
