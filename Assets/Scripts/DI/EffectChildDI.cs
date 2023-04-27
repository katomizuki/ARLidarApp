using UnityEngine;
using VContainer;
using VContainer.Unity;

public sealed class EffectChildDI : LifetimeScope 
{
    [SerializeField] private ARLidarEffect _arLidarEffect;
    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterEntryPoint<MainARPresenter>();
        builder.RegisterComponent<ARLidarEffect>(_arLidarEffect);
    }
}
