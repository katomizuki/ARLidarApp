using Model;
using Presenter;
using UnityEngine;
using VContainer.Unity;
using VContainer;
using View;

namespace DI 
{
    public class MainARDIContainer: LifetimeScope {
        [SerializeField] private MainARView _mainARView;
    
        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterEntryPoint<MainARPresenter>(Lifetime.Singleton);
            builder.Register<IMainARService, MainARService>(Lifetime.Singleton);
            builder.RegisterComponent(_mainARView);
        }
    }  
}
