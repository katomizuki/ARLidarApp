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
            CurrentEffect.currentEffect = ARLidarEffect.Texture;
        }

        public void OnTapGreenScenePanel()
        {
#if DEBUG
            Debug.Log("OnTapGreenScenePanel");
#endif 
            LoadScene();
            CurrentEffect.currentEffect = ARLidarEffect.Vertex;
        }

        public void OnTapBlueScenePanel()
        {
#if DEBUG
            Debug.Log("OnTapBlueScenePanel");
#endif
            LoadScene();
            CurrentEffect.currentEffect = ARLidarEffect.PointCloud;
        }

        public void OnTapPurpleScenePanel()
        {
#if DEBUG
            Debug.Log("OnTapPurpleScenePanel");
#endif
            LoadScene();
            CurrentEffect.currentEffect = ARLidarEffect.ScanLine;
        }

        private void LoadScene()
        {
            SceneManager.LoadScene("ARScene", LoadSceneMode.Single);
        }
    } 
}

