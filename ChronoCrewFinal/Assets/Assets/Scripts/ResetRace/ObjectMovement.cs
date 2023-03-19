using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class ObjectMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float distance;
    [SerializeField] private float axis; //set this to 1 for vertical movement and 0 for horizontal
    [SerializeField] private float direction; //set to -1 for negative movement and 1 for positive
    [SerializeField] private float countr;
    // Start is called before the first frame updates
    void Start()
    {
        if (direction == 1 ^ direction == -1)
        {
            speed *= direction;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        countr += 1;
        if (countr > distance)
        {
            speed = speed * -1f;
            countr = 1; 
        }
        //after update has been called 20 times the direction of the saw will flip as its speed is multiplied by -1

        var SawPos = this.gameObject.transform.position;
        if (axis == 1)
        {
            SawPos.y += speed;
        }
        if (axis == 0)
        {
            SawPos.x += speed;
        }
        this.gameObject.transform.position = SawPos;
    }
}
