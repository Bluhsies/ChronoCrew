using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBombP2 : MonoBehaviour
{
    [SerializeField] Transform firingFrom;
    [SerializeField] GameObject bombPrefab;

    [SerializeField] float reloadTimer; // Sets max time for reload from throwing a bomb.
    private float reloadTimeRemaining; // Float used for determining time remaining before next bomb can be thrown.
    // When time remaining is 0, player can shoot again.
    
    // Start is called before the first frame update

    void FixedUpdate()
    {
        if (reloadTimeRemaining > 0)
        // If reloadTimeRemaining is greater than 0, it should decrement.
        {
            reloadTimeRemaining -= Time.fixedDeltaTime;
            // Time remaining decrements based on the last time elapsed since this line was executed(?).
            //Debug.Log(reloadTimeRemaining);
        }
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            if (reloadTimeRemaining <= 0)
            // If time remaining is less than or equal to 0, player can fire bomb again.
            {
                Shoot();
                reloadTimeRemaining = reloadTimer;
                // After shooting, resets time remaining before next shot.
            }
        }
    }

    void Shoot()
    {
        if (reloadTimeRemaining <= 0)
        {
            GameObject bomb = Instantiate(bombPrefab, firingFrom.position, firingFrom.rotation);
            // Beginning reference to owner.
            var projectile = bomb.GetComponent<Projectile>();

            projectile.owner = gameObject;
            // Bomb and owner now linked; this will stop the bomb being able to kill the player who threw it later on in Projectile.cs
        }

        else
        {
            Debug.Log("Bomb throw on cooldown @ " + gameObject);
        }
    }
}

