using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropZone : MonoBehaviour, IDropHandler
{
    public Image outputBlob;

    private string firstColor = "", secondColor = "";

    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        if (dropped != null)
        {
            string color = dropped.name;

            if (firstColor == "")
            {
                firstColor = color;
            }
            else
            {
                secondColor = color;
                MixColors();
            }
        }
    }

    void MixColors()
    {
        if ((firstColor == "RedBlob" && secondColor == "BlueBlob") ||
            (firstColor == "BlueBlob" && secondColor == "RedBlob"))
        {
            outputBlob.color = new Color(0.5f, 0f, 0.5f); // Purple
        }

        firstColor = "";
        secondColor = "";
    }
}
