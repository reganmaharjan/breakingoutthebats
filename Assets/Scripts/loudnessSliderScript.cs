using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loudnessSliderScript : MonoBehaviour
{
    public Slider sliderInstance;
    public Slider audiopitch;

    public AudioSource audioSource;
    // Start is called before the first frame update
    
    void Start()
    {
        audioSource.pitch = audiopitch.value;
        Debug.Log(audioSource.pitch);
    }

    public void OnValueChanged(float value)
    {
        audioSource.volume = value;
        audioSource.Play();
    }
   

}
