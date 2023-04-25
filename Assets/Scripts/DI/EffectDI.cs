using VContainer;
using VContainer.Unity;

public sealed class EffectDI : LifetimeScope 
{
    protected override void Configure(IContainerBuilder builder)
    {
        base.Configure(builder);
        builder.Register<ARLidarEffect>(Lifetime.Singleton);
    }
}