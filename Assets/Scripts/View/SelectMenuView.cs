using UniRx;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace View
{
    public class SelectMenuView : MonoBehaviour
    {
        [HideInInspector] public Subject<int> _selectSceneId = new Subject<int>();
        public void OnTapOrangeScenePanel()
        {
            _selectSceneId.OnNext(1); 
#if DEBUG
            Debug.Log("OnTapOrangeScenePanel");   
#endif
        }

        public void OnTapGreenScenePanel()
        {
            _selectSceneId.OnNext(2); 
#if DEBUG
            Debug.Log("OnTapGreenScenePanel");
#endif 
        }

        public void OnTapBlueScenePanel()
        {
            _selectSceneId.OnNext(3); 
#if DEBUG
            Debug.Log("OnTapBlueScenePanel");
#endif
        }

        public void OnTapPurpleScenePanel()
        {
            _selectSceneId.OnNext(4); 
#if DEBUG
            Debug.Log("OnTapPurpleScenePanel");
#endif
        }

        public void LoadScene()
        {
            SceneManager.LoadScene("ARScene", LoadSceneMode.Single);
        } 
    }
}
