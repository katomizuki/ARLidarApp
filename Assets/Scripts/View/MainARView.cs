using UniRx;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;

namespace View
{
    public class MainARView : MonoBehaviour
    {
        public Subject<Unit> lifeCycleAwake = new Subject<Unit>();
        [HideInInspector]
        public ReactiveProperty<bool> isTapButton = new ReactiveProperty<bool>(false);
        [SerializeField] 
        private ARMeshManager arMeshManager;
        [SerializeField] TMPro.TextMeshProUGUI textMeshProUgui;
        private void Awake()
        {
            lifeCycleAwake.OnNext(Unit.Default);
        }

        public void ShowErrorOnLidar()
        {
#if DEBUG 
            Debug.Log("not supported Lidar");   
#endif
            textMeshProUgui.text = "not supported Lidar";
        }

        public void NotActiveARMeshManager()
        {
            arMeshManager.gameObject.SetActive(false);
        }

        public void OnTapBackButton()
        {
            isTapButton.Value = true;
        }

        public void BackMenuScene()
        {
            SceneManager.LoadScene("FirstScene", LoadSceneMode.Single);
        }

        public void ShowAREffect(Material material)
        {
            arMeshManager.meshPrefab.gameObject.GetComponent<MeshRenderer>().material = material; 
        }
    }
}
