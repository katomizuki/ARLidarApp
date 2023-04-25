using UniRx;
using UnityEngine;

public class MainARView : MonoBehaviour
{
    public Subject<Unit> lifeCycleAwake = new Subject<Unit>();
    private void Awake()
    {
        lifeCycleAwake.OnNext(Unit.Default);
    }

    public void showErrorOnLidar()
    {
        Debug.Log("not supported Lidar");
    }
}
