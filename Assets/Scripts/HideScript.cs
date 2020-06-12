using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideScript : MonoBehaviour
{
    public GameObject gameObject;

    // Update is called once per frame
    void Start()
    {
        gameObject.SetActive(false);
    }
}
