using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    public Slider sliderVolumeMusic;
    public AudioSource audio;
    public float volume;

    void Start()
    {
        Load();
        ValueMusic();

        sliderVolumeMusic = GameObject.FindGameObjectWithTag("Slider").GetComponent<Slider>();
    }


    public void SliderMusic()
    {
        volume = sliderVolumeMusic.value;
        Save();
        ValueMusic();
    }

    private void ValueMusic()
    {
        audio.volume = volume;
        sliderVolumeMusic.value = volume;
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("volume", volume);
    }

    private void Load()
    {
        volume = PlayerPrefs.GetFloat("volume", volume);
    }
}

