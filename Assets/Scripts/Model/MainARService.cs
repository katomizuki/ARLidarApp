using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.XR;

public interface IMainARService
{
    bool IsARLidarSupported();
    void UpdateLifeCycle();
}
public class MainARService : IMainARService 
{
    public bool IsARLidarSupported()
    {
        // https://forum.unity.com/threads/check-if-armeshing-supported-on-device.909839/#post-6048380
        var subsystems = new List<XRMeshSubsystem>();
        SubsystemManager.GetInstances(subsystems);
        return subsystems.Any();
    }

    public void UpdateLifeCycle()
    {
        // do something
    }
}
