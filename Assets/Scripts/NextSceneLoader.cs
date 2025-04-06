using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneLoader : MonoBehaviour
{
    public string nextSceneName = "MatchingGarden";

    public void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
