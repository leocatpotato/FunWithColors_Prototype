using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ColorDropTarget : MonoBehaviour, IDropHandler
{
    public string correctColor;
    public static int correctMatches = 0;
    public static int goal = 3;
    public GameObject nextButton;

    public AudioClip correctSound;
    public AudioClip wrongSound;

    private AudioSource audioSource;
    private bool alreadyMatched = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;

        if (dropped == null) return;

        string droppedName = dropped.name.ToLower();
        string expected = correctColor.ToLower();

        Debug.Log($"Dropped: {droppedName}, Expected: {expected}, AlreadyMatched: {alreadyMatched}");

        if (droppedName.Contains(expected))
        {
            if (!alreadyMatched)
            {
                Debug.Log("Correct match for " + gameObject.name);

                if (correctSound != null && audioSource != null)
                    audioSource.PlayOneShot(correctSound);

                Destroy(dropped);
                correctMatches++;
                alreadyMatched = true;

                if (correctMatches >= goal && nextButton != null)
                {
                    nextButton.SetActive(true);
                }
            }
        }
        else
        {
            Debug.Log("Wrong color for " + gameObject.name);

            if (wrongSound != null && audioSource != null)
                audioSource.PlayOneShot(wrongSound);
        }
    }
}
