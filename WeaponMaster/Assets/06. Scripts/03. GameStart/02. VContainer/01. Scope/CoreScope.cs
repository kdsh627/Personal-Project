using UnityEngine;
using VContainer;
using VContainer.Unity;
public class CoreScope : LifetimeScope
{
    [SerializeField] private string    _scenePath;
    [SerializeField] private LoadingUI _loadingScreen;

    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterEntryPoint<SceneLoader>(Lifetime.Scoped).AsSelf();
        builder.RegisterComponent<LoadingUI>(_loadingScreen);

        builder.Register<IInitiator, CoreInitiator>(Lifetime.Scoped).WithParameter("_scenePath", _scenePath);
        builder.RegisterEntryPoint<EntryPoint>(Lifetime.Scoped);
    }
}
