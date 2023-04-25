using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using VContainer;
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
            // LifetimeScope generated in this block will be parented by `this.lifetimeScope`
            using (LifetimeScope.EnqueueParent(scoreLifetimeScope))
            {
                // If this scene has a LifetimeScope, its parent will be `parent`.
                var loading = SceneManager.LoadSceneAsync("ARScene", LoadSceneMode.Additive);
                while (!loading.isDone)
                {
                    yield return null;
                }
            }
        }
    } 
}

