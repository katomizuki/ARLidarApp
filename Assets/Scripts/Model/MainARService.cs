using UniRx;
using UnityEngine.XR.ARFoundation;

public interface IMainARService
{
    bool IsARLidarSupported();
    void UpdateLifeCycle();
}
public class MainARService : IMainARService 
{
    public bool IsARLidarSupported()
    {
        return true;
    }

    public void UpdateLifeCycle()
    {
        // do something
    }
}
