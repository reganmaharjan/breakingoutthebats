using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class frequencySliderScript : MonoBehaviour
{

    public Slider frequency;
    public GameObject wave;

    public AudioSource audioSource;
    // Start is called before the first frame update

    void Start()
    {
        audioSource.pitch = frequency.value;
    }

    public void OnValueChanged(float value)
    {
        audioSource.pitch = value;
        audioSource.Play();
        if (value == 0)
        {
            wave.SetActive(false);
        }
    }


}
