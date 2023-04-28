using UnityEngine.XR.ARKit;

namespace Model
{
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
}