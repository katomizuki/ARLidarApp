using System.Collections.Generic;
using System.Linq;
using UniRx;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARKit;

public interface IMainARService
{
    bool IsARLidarSupported();
    bool IsARCollaboration();
    bool IsARWorldMap();
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

    public bool IsARCollaboration()
    {
        return ARKitSessionSubsystem.supportsCollaboration;
    }

    public bool IsARWorldMap()
    {
        return ARKitSessionSubsystem.worldMapSupported;
    }

    public void UpdateLifeCycle()
    {
        // do something
    }
}
