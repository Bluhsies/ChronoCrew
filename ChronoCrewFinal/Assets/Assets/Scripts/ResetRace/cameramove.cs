using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class cameramove : MonoBehaviour
{
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        var camPos = Camera.main.gameObject.transform.position;
        camPos.x += speed;
        Camera.main.gameObject.transform.position = camPos;
    }
}

//https://stackoverflow.com/questions/44468749/trying-to-get-camera-in-unity-2d-to-automatically-scroll-not-follow-the-player
