using UnityEngine;
using UnityEngine.SceneManagement;

//Udostepnia metode do cyklicznego ladowania kolejnej sceny
public class NextSceneLoader : MonoBehaviour
{
    public void LoadScene()
    {
        int sceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
        if (sceneToLoad == SceneManager.sceneCountInBuildSettings)
            sceneToLoad = 0;
        SceneManager.LoadScene(sceneToLoad);
    }
}
