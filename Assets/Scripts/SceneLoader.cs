using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using VContainer.Unity;

namespace FirstScene 
{
    public class SceneLoader : MonoBehaviour
    {
        [SerializeField] private LifetimeScope scoreLifetimeScope;
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
            StartCoroutine(LoadSceneAsync());
        }
        
        private IEnumerator LoadSceneAsync()
        {
            // 引数のLifeTimeScopeを親にして、子のLifeTimeScopeから参照できるようにする
            using (LifetimeScope.EnqueueParent(scoreLifetimeScope))
            {
                // Addptive=>現在のシーンにシーンを追加。Singleton=>シーンが一つだけであることを保証。
                var loading = SceneManager.LoadSceneAsync("ARScene", LoadSceneMode.Additive);
                while (!loading.isDone)
                {
                    yield return null;
                }
            }
        }
    } 
}

