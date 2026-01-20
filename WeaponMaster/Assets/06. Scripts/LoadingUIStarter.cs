using System;
using System.Threading.Tasks;

public class LoadingUIStarter : IAsyncDisposable
{
    private LoadingUI _loadingUI;

    public LoadingUIStarter()
    {
        _loadingUI.SetActive(true);
    }

    public async ValueTask DisposeAsync()
    {
        await _loadingUI.FadeIn();
        _loadingUI.SetActive(false);
    }
}
