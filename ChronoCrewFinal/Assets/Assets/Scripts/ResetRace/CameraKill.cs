using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraKill : MonoBehaviour
{
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        var camPos = this.gameObject.transform.position;
        camPos.x += speed;
        this.gameObject.transform.position = camPos;
    }
}
