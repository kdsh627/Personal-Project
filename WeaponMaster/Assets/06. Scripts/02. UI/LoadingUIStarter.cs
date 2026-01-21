using System;
using System.Threading.Tasks;
using VContainer;

public class LoadingUIStarter : IAsyncDisposable
{
    private LoadingUI _loadingUI;

    public LoadingUIStarter(LoadingUI loadingUI)
    {
        _loadingUI = loadingUI;
        _loadingUI.SetActive(true);
    }

    public async ValueTask DisposeAsync()
    {
        await _loadingUI.FadeIn();
        _loadingUI.SetActive(false);
    }
}
