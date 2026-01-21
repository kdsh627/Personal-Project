using System.Threading;
using Cysharp.Threading.Tasks;
using VContainer;

public class CoreInitiator : IInitiator
{
    [Inject] private LoadingUI   _loadingScreen;
    [Inject] private SceneLoader _sceneLoader;
    [Inject] private string      _scenePath;

    public async UniTask GameInitialize(CancellationToken token)
    {
        await TitleSceneLoad(token);
    }

    private async UniTask TitleSceneLoad(CancellationToken token)
    {
        await using (var Loding = new LoadingUIStarter(_loadingScreen))
        {
            await _sceneLoader.LoadSceneByPath(_scenePath, token);
        }
    }
}
