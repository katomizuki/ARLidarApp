using UniRx;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARKit;

#if UNITY_IOS

namespace View
{
    public class ARCoachingOverlayView : MonoBehaviour 
    {
        [SerializeField] private bool activesAutomatically = true;
        [SerializeField] private ARCoachingGoal goal = ARCoachingGoal.Tracking;
        public Subject<Unit> lifeCycleEnable = new Subject<Unit>();
        public Subject<Unit> lifeCycleDisable = new Subject<Unit>();
        private void OnEnable()
        {
            "OnEable!!".DebugBlue();
            lifeCycleEnable.OnNext(Unit.Default);
        }

        public void EnableOverlay()
        {
            "enable overlay".DebugBlue();
            var subsystem = (ARKitSessionSubsystem) GetComponent<ARSession>().subsystem;
            subsystem.requestedCoachingGoal = goal;
            subsystem.coachingActivatesAutomatically = activesAutomatically;
            subsystem.sessionDelegate = new ARKitOverlayCustomDelegate();
        }

        public void ShowOverlay()
        {
            var subsystem = (ARKitSessionSubsystem) GetComponent<ARSession>().subsystem;
            subsystem.SetCoachingActive(true, ARCoachingOverlayTransition.Animated);
            "show Overlay".DebugOrange();
        }
    
        public void HideOverlay()
        {
            var subsystem = (ARKitSessionSubsystem) GetComponent<ARSession>().subsystem;
            subsystem.SetCoachingActive(false, ARCoachingOverlayTransition.Animated);
            "hide Overlay".DebugBlue();
        }

        public void ShownotSupportOverlayView()
        {
            "ARCoachingOverlayView is not supported by this device.".DebugCyan(); 
        }

        private void OnDisable()
        {
            "OnDisable!!".DebugBlue();
            lifeCycleDisable.OnNext(Unit.Default);
        }


        private void OnDestroy()
        {
            lifeCycleEnable.Dispose();
            lifeCycleDisable.Dispose();
        }
    
    }
}
#endif
