using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ptichSliderScript : MonoBehaviour
{

    public Slider sliderInstance;
    public Slider audiovolume;

    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource.volume = audiovolume.value;
        Debug.Log(audioSource.volume);
    }

    public void OnValueChanged(float value)
    {
        audioSource.pitch = value;
        audioSource.Play();
    }

}
