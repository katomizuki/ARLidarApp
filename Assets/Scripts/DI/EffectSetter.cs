using UnityEngine;
using VContainer;

public class EffectSetter : MonoBehaviour
{
    private ARLidarEffect arLidarEffect;

    [Inject]
    public void Construct(ARLidarEffect arLidarEffect)
    {
        this.arLidarEffect = arLidarEffect;
    }
}
