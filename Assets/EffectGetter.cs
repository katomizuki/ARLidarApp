using UnityEngine;
using VContainer;

public class EffectGetter : MonoBehaviour
{

    private ARLidarEffect _arLidarEffect;

    [Inject]
    public void Construct(ARLidarEffect arLidarEffect)
    {
        this._arLidarEffect = arLidarEffect;
    }

    public ARLidarEffect GetARLidarEffect()
    {
        return this._arLidarEffect;
    }
}
