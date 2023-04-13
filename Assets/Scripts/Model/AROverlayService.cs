using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARKit;

    public interface IAROverlayService
    {
        bool IsAROverlayCoaching();
    }
    public class AROverlayService : IAROverlayService 
    {
        public bool IsAROverlayCoaching()
        {
            return ARKitSessionSubsystem.coachingOverlaySupported;
        } 
    }