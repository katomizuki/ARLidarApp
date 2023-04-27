using UniRx;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;

public class MainARView : MonoBehaviour
{
    public Subject<Unit> lifeCycleAwake = new Subject<Unit>();
    [HideInInspector]
    public ReactiveProperty<bool> isTapButton = new ReactiveProperty<bool>(false);
    public ARMeshManager arMeshManager;
    private void Awake()
    {
        lifeCycleAwake.OnNext(Unit.Default);
    }

    public void ShowErrorOnLidar()
    {
        Debug.Log("not supported Lidar");
    }

    public void OnTapBackButton()
    {
        isTapButton.Value = true;
    }

    public void BackMenuScene()
    {
        SceneManager.LoadScene("FirstScene", LoadSceneMode.Single);
    }
}
