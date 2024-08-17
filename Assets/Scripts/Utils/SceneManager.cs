using UnityEngine;



public class SceneManager : StaticInstance<SceneManager>
    {
        public void ChangeCurrentScene(string sceneName) => UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);

        public void ChangeCurrentScene(int sceneBuildIndex) => UnityEngine.SceneManagement.SceneManager.LoadScene(sceneBuildIndex);

        public static void ReloadCurrentScene()
        {
            string currentSceneName = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
            UnityEngine.SceneManagement.SceneManager.LoadScene(currentSceneName);
        }

        public void ExitApplication() => Application.Quit();
    }
