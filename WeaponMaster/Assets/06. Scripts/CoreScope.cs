using UnityEngine;
using VContainer;
using VContainer.Unity;
public class CoreScope : LifetimeScope
{
    [SerializeField] private LoadingUI _loadingScreen;

    protected override void Configure(IContainerBuilder builder)
    {
       //builder.Register
    }
}
