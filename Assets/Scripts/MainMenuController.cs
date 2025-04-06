using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("MixingLab");
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game Closed!");
    }
}
