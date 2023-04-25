using Presenter;
using UnityEngine;
using VContainer;
using VContainer.Unity;
using Lidar;

namespace DI
{
    public class ARCoachingDIContainer : LifetimeScope 
    {
       [SerializeField] private ARCoachingOverlayView _arCoachingView;

       protected override void Configure(IContainerBuilder builder)
       {
           builder.RegisterEntryPoint<ARCoachingPresenter>();
           builder.Register<IAROverlayService, AROverlayService>(Lifetime.Singleton);
           builder.RegisterComponent(_arCoachingView);
       }
    }
}