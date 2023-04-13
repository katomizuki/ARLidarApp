using System;
using UniRx;
using UnityEngine;

interface IMainARViewable
{
    void showErrorOnLidar();
    Subject<Unit> lifeCycleAwake { get; }
}
public class MainARView : MonoBehaviour
{
    public Subject<Unit> lifeCycleAwake = new Subject<Unit>();
    private void Awake()
    {
        lifeCycleAwake.OnNext(Unit.Default);
    }

    public void showErrorOnLidar()
    {
       // show Error 
    }
}
