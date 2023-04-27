using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;

public interface IMainARService
{
    bool IsARLidarSupported();
    void UpdateLifeCycle();
    void SetARLidarEffect(ARMeshManager arMeshManager);
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
    
    public void SetARLidarEffect(ARMeshManager arMeshManager)
    {
        
        Material mat;
        var currentEffect = PlayerPrefs.GetInt("Effect");
        switch (currentEffect)
        {
            case 1:
                mat = Resources.Load<Material>("Materials/Shader Graphs_NoiseGiraGira");
                break;
            case 2:
                mat = Resources.Load<Material>("Materials/Shader Graphs_Pattern");
                break;
            case 3:
                mat = Resources.Load<Material>("Materials/Shader Graphs_Scanline");
                break;
            case 4:
                mat = Resources.Load<Material>("Materials/Shader Graphs_TextureEffect");
                break;
            default:
                mat = Resources.Load<Material>("Materials/TextureEffect");
                break;
        }
        arMeshManager.meshPrefab.gameObject.GetComponent<MeshRenderer>().material = mat; 
    }
}
