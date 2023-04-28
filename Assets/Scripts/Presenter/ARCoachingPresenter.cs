using Model;
using VContainer.Unity;
using UniRx;
using VContainer;
using View;

namespace Presenter
{
    public class ARCoachingPresenter :IInitializable
    {
        private readonly ARCoachingOverlayView _coachingOverlayView;
        private readonly IAROverlayService _arOverlayService;
        
        [Inject]
        public ARCoachingPresenter(
            ARCoachingOverlayView coachingOverlayView,
            IAROverlayService arOverlayService)
        {
            _coachingOverlayView = coachingOverlayView;
            _arOverlayService = arOverlayService;
        }
        
        
        public void Initialize()
        {
           _coachingOverlayView.lifeCycleEnable
               .Subscribe(_ =>
               {
                   if (_arOverlayService.IsAROverlayCoaching())
                   {
                       _coachingOverlayView.EnableOverlay();
                       _coachingOverlayView.ShowOverlay();
                   }
                   else
                   {
                       _coachingOverlayView.HideOverlay();
                       _coachingOverlayView.ShownotSupportOverlayView(); 
                   }
               }).AddTo(_coachingOverlayView);


           _coachingOverlayView.lifeCycleDisable
               .Subscribe(_ =>
               {
                   _coachingOverlayView.HideOverlay();
               }).AddTo(_coachingOverlayView);
        }
    }
}