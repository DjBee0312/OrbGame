using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class SoundButton : MonoBehaviour
{
    private SoundManager soundManager;
    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(PlayClick);
        soundManager = FindObjectOfType<SoundManager>();
    }

    public void PlayClick()
    {
        soundManager.Play("Click");
    }
}