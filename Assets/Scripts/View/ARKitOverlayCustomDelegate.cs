using UnityEngine;
using UnityEngine.XR.ARKit;

    public class ARKitOverlayCustomDelegate : DefaultARKitSessionDelegate 
    {
        protected override void OnCoachingOverlayViewWillActivate(ARKitSessionSubsystem sessionSubsystem)
        {
            Debug.Log("ViewWillActivate");
        }

        protected override void OnCoachingOverlayViewDidDeactivate(ARKitSessionSubsystem sessionSubsystem)
        {
            Debug.Log("ViewDidDeactivate");
        } 
    }