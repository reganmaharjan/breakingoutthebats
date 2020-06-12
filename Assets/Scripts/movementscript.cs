using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movementscript : MonoBehaviour
{
    public Slider Pslider;
    public Slider Lslider;
    public GameObject gameobj;
    public float speed = 6.0F;

    void Start()
    {
        gameobj.SetActive(false);
    }


        // Update is called once per frame
        void Update()
        {
            if (Pslider.value >.7 && Lslider.value >.7)
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

            if (Pslider.value > 0 || Lslider.value > 0)
            {
                gameobj.SetActive(true);
            }
            if (Pslider.value < 0 || Lslider.value < 0)
            {
                gameobj.SetActive(true);
            }

        }
}
