using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SimpleCameraShakeInCinemachine : MonoBehaviour
{

    public float ShakeDuration = 0.3f;          // Time the Camera Shake effect will last
    public float ShakeAmplitude = 1.2f;         // Cinemachine Noise Profile Parameter
    public float ShakeFrequency = 2.0f;         // Cinemachine Noise Profile Parameter

    private float ShakeElapsedTime = 0f;
    public GameObject show;
    public GameObject canvas;

    // Cinemachine Shake
    public CinemachineVirtualCamera VirtualCamera;
    private CinemachineBasicMultiChannelPerlin virtualCameraNoise;

    public Slider Pslider;
    public Slider Lslider;
    public AudioSource audioSource1;

    // Use this for initialization
    void Start()
    {
        // Get Virtual Camera Noise Profile
        if (VirtualCamera != null)
            virtualCameraNoise = VirtualCamera.GetCinemachineComponent<Cinemachine.CinemachineBasicMultiChannelPerlin>();
    }

    // Update is called once per frame
    void Update()
    {
        // TODO: Replace with your trigger
        if ((Pslider.value > .7 && Lslider.value > .7) && (Pslider.value < .8 && Lslider.value < .8))
        {
            ShakeElapsedTime = ShakeDuration;
        }
       

        // If the Cinemachine componet is not set, avoid update
        if (VirtualCamera != null && virtualCameraNoise != null)
        {
            // If Camera Shake effect is still playing
            if (ShakeElapsedTime > 0)
            {
                // Set Cinemachine Camera Noise parameters
                virtualCameraNoise.m_AmplitudeGain = ShakeAmplitude;
                virtualCameraNoise.m_FrequencyGain = ShakeFrequency;

                // Update Shake Timer
                ShakeElapsedTime -= Time.deltaTime;
            }
            else
            {
                // If Camera Shake effect is over, reset variables
                virtualCameraNoise.m_AmplitudeGain = 0f;
                ShakeElapsedTime = 0f;
            }
        }
    }
    public void shakeSoundStart()
    {
        if ((Pslider.value > .7 && Lslider.value > .7) && (Pslider.value < .8 && Lslider.value < .8))
            {
            audioSource1.Play();
            FindObjectOfType<DialogueTrigger>().TriggerDialogue();
        }
        if ((Pslider.value < .7 || Lslider.value < .7) || (Pslider.value > .8 || Lslider.value > .8))
        {
            audioSource1.Stop();
        }
        if (Pslider.value > .8 && Lslider.value > .8)
        {
            FindObjectOfType<DialogueTrigger2>().TriggerDialogue();
            canvas.SetActive(true);
            show.SetActive(true);
        }
        if (Pslider.value < .75 && Lslider.value < .75)
        {
            show.SetActive(false);
        }
        


    }
}