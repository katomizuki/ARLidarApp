using UnityEngine;
using VContainer;
using VContainer.Unity;

public class SelectMenuDI : LifetimeScope 
{
    [SerializeField] SelectMenuView _selectMenuView;
    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterEntryPoint<SelectMenuPresenter>();
        builder.Register<ILocalStorageService, LocalStorageService>(Lifetime.Singleton);
        builder.RegisterComponent<SelectMenuView>(_selectMenuView);
    }
}
