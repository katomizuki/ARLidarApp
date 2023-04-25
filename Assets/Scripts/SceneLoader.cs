using UnityEngine;
using UnityEngine.SceneManagement;

namespace FirstScene 
{
    public class SceneLoader : MonoBehaviour
    {
        public void OnTapOrangeScenePanel()
        {
#if DEBUG
            Debug.Log("OnTapOrangeScenePanel");   
#endif
            LoadScene();
        }

        public void OnTapGreenScenePanel()
        {
#if DEBUG
            Debug.Log("OnTapGreenScenePanel");
#endif 
            LoadScene();
        }

        public void OnTapBlueScenePanel()
        {
#if DEBUG
            Debug.Log("OnTapBlueScenePanel");
#endif
            LoadScene();
        }

        public void OnTapPurpleScenePanel()
        {
#if DEBUG
            Debug.Log("OnTapPurpleScenePanel");
#endif
            LoadScene();
        }

        private void LoadScene()
        {
            SceneManager.LoadScene("ARScene");
        }
    } 
}

