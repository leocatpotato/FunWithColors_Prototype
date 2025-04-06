using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SortingDrop : MonoBehaviour, IDropHandler
{
    public string expectedTag;
    public AudioClip correctSound;
    public AudioClip wrongSound;

    private AudioSource audioSource;
    public static int correctCount = 0;
    public static int goal = 10;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            if (eventData.pointerDrag.CompareTag(expectedTag))
            {
                audioSource.PlayOneShot(correctSound);
                Destroy(eventData.pointerDrag);
                correctCount++;

                if (correctCount >= goal)
                {
                    SceneManager.LoadScene("GameOver");
                }
            }
            else
            {
                audioSource.PlayOneShot(wrongSound);
            }
        }
    }
}
