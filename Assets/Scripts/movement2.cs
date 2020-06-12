using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movement2 : MonoBehaviour
{
    public Slider Fslider;
    public GameObject gameobj;
    public float speed = 6.0F;

    void Start()
    {
        gameobj.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (Fslider.value > .7)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += Vector3.right * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
            }
        }

        if (Fslider.value > 0 )
        {
            gameobj.SetActive(true);
        }
        if (Fslider.value < 0 )
        {
            gameobj.SetActive(false);
        }

    }
}
