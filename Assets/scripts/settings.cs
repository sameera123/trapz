using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class settings : MonoBehaviour
{

    public bool muteToggle;
    public Toggle muteButton;
    public AudioSource audio;

    public bool mute;

    // Use this for initialization
    void Start()
    {
        muteButton = muteButton.GetComponent<Toggle>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void onToggleClicked()
    {
        muteToggle = !muteToggle;

        if (audio.mute)
        {
            audio.mute = false;
            muteToggle = true;
        }
        else
        {
            audio.mute = true;
            muteToggle = false;
        }

    }

    public void fullScreen()
    {
    }


    public void getButtonHorizontal()
    {
        print("Horizontal");
    }

    public void getButtonVertical()
    {
        print("vertical");
    }

}
