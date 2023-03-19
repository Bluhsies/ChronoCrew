using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeMovement5 : MonoBehaviour {


    [SerializeField] public float speed;
    [SerializeField] public float PlayerTarget;    // 1 for Player 1 and 2 for Player 2

    private Transform target;


    // Start is called before the first frame update
    void Start()
    {
           
        if(PlayerTarget == 1)
        {
            target = GameObject.FindGameObjectWithTag("Player1").GetComponent<Transform>();
        }
     
        if(PlayerTarget == 2)
        {
            target = GameObject.FindGameObjectWithTag("Player2").GetComponent<Transform>();

        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed);
    }
}
