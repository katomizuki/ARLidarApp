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
            PlayerPrefs.SetInt("Effect",1);
        }

        public void OnTapGreenScenePanel()
        {
#if DEBUG
            Debug.Log("OnTapGreenScenePanel");
#endif 
            LoadScene();
            PlayerPrefs.SetInt("Effect",2);
        }

        public void OnTapBlueScenePanel()
        {
#if DEBUG
            Debug.Log("OnTapBlueScenePanel");
#endif
            LoadScene();
            PlayerPrefs.SetInt("Effect",3);
        }

        public void OnTapPurpleScenePanel()
        {
#if DEBUG
            Debug.Log("OnTapPurpleScenePanel");
#endif
            LoadScene();
            PlayerPrefs.SetInt("Effect",4);
        }

        private void LoadScene()
        {
            SceneManager.LoadScene("ARScene", LoadSceneMode.Single);
        }
    } 
}

