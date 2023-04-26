using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

namespace Lidar
{
    [RequireComponent(typeof(ARMeshManager))]
    public class LidarManager : MonoBehaviour
    {
        private ARMeshManager _arMeshManager;

        private void Awake()
        {
            _arMeshManager = GetComponent<ARMeshManager>();
           _arMeshManager.meshesChanged += OnMeshesChanged;  
        }
        
        private void OnMeshesChanged(ARMeshesChangedEventArgs args)
        {
            foreach (var meshFilter in args.added)
            {
            }
            
            foreach (var mesh in args.updated)
            {
                Debug.Log($"updated {mesh.mesh.uv.Length}");
            }

            foreach (var mesh in args.removed)
            {
                Debug.Log($"removed {mesh.mesh.triangles.Length}");
            }
        }
    }  
}

