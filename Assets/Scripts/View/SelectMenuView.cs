using UniRx;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace View
{
    public class SelectMenuView : MonoBehaviour
    {
        [HideInInspector]
        public ReactiveProperty<int> _selectSceneId = new ReactiveProperty<int>(0);
        public void OnTapOrangeScenePanel()
        {
            _selectSceneId.Value = 1; 
#if DEBUG
            Debug.Log("OnTapOrangeScenePanel");   
#endif
        }

        public void OnTapGreenScenePanel()
        {
            _selectSceneId.Value = 2; 
#if DEBUG
            Debug.Log("OnTapGreenScenePanel");
#endif 
        }

        public void OnTapBlueScenePanel()
        {
            _selectSceneId.Value = 3; 
#if DEBUG
            Debug.Log("OnTapBlueScenePanel");
#endif
        }

        public void OnTapPurpleScenePanel()
        {
            _selectSceneId.Value = 4; 
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
