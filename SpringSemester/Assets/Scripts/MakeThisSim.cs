using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class MakeThisSim : MonoBehaviour
{
    private Image img;
    void Awake ()
    {
        img = GetComponent<Image>();
    }

    public void UpdateImage(FloatValue data)
    {
        img.fillAmount = data.value;
    }
}