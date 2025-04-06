using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigator : MonoBehaviour
{
    public string nextSceneName;

    public void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
