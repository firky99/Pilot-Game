using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundSetting : MonoBehaviour
{
    [SerializeField]
    GameObject optionMenu;
    [SerializeField]
    Slider slider;

    void Start()
    {
        if(!PlayerPrefs.HasKey("volume"))
            PlayerPrefs.SetFloat("volume", 1);

        AudioListener.volume = PlayerPrefs.GetFloat("volume");
        slider.value = AudioListener.volume;
        optionMenu.SetActive(false);
    }

    public void SetVolume()
    {
        float newVolume = slider.value;
        PlayerPrefs.SetFloat("volume", newVolume);
        AudioListener.volume = newVolume;
    }
}
