using Scenes;
using UnityEngine;

[RequireComponent(typeof(ARDensePointCloud))]
public class ARDensePointCloudVisualizer : MonoBehaviour
{
    // Point Cloudをの可視化する
    protected ARDensePointCloud _pointCloud { get; private set; }

    protected virtual void Awake()
    {
        // 可視化するPointCloudを取得する
        _pointCloud = GetComponent<ARDensePointCloud>();
    }

    protected virtual void OnEnable()
    {
        // コールバックを登録
        _pointCloud.pointCloudUpdated += OnPointCloudUpdated;
    }

    protected virtual void OnDisable()
    {
        // コールバックを解除する
        _pointCloud.pointCloudUpdated -= OnPointCloudUpdated;
    }
    
    protected virtual void OnPointCloudUpdated(PointCloudUpdatedEventArgs args)
    {
    }
}
