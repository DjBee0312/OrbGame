using UnityEngine;
using UnityEngine.UI;

public class SoundButtonController : MonoBehaviour
{
    public Text text;

    public void ChangeState()
    {
        text.text = text.text == "SOUND\nON" ? "SOUND\nOFF" : "SOUND\nON";
    }
}
