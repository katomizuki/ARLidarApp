using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;

public interface IMainARService
{
    bool IsARLidarSupported();
    void UpdateLifeCycle();
    void SetARLidarEffect(ARLidarEffect currentEffect, ARMeshManager arMeshManager);
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
    
    public void SetARLidarEffect(ARLidarEffect currentEffect, ARMeshManager arMeshManager)
    {
        Material mat;
        switch (currentEffect)
        {
            case ARLidarEffect.Texture:
                mat = Resources.Load<Material>("Materials/Shader Graphs_NoiseGiraGira");
                break;
            case ARLidarEffect.Vertex:
                mat = Resources.Load<Material>("Materials/Shader Graphs_Pattern");
                break;
            case ARLidarEffect.PointCloud:
                mat = Resources.Load<Material>("Materials/Shader Graphs_Scanline");
                break;
            case ARLidarEffect.ScanLine:
                mat = Resources.Load<Material>("Materials/Shader Graphs_TextureEffect");
                break;
            default:
                mat = Resources.Load<Material>("Materials/TextureEffect");
                break;
        }
        arMeshManager.GetComponent<MeshRenderer>().material = mat; 
    }
}
