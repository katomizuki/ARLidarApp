using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.XR;

namespace Model
{
    public interface IMainARService
    {
        bool IsARLidarSupported();
        void UpdateLifeCycle();
        Material GetARMaterial();
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
    
        public Material GetARMaterial()
        {
            return PlayerPrefs.GetInt("Effect") switch
            {
                1 => Resources.Load<Material>("Materials/Shader Graphs_NoiseGiraGira"),
                2 => Resources.Load<Material>("Materials/Shader Graphs_Pattern"),  
                3 => Resources.Load<Material>("Materials/Shader Graphs_Scanline"),
                4 => Resources.Load<Material>("Materials/Shader Graphs_TextureEffect"),
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}