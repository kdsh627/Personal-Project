using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;

public interface IInitiator
{
    public UniTask GameInitialize(CancellationToken token);
}
