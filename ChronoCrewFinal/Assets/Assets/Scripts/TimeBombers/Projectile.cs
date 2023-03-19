using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private float speed = 4;
    private Vector3 launchOffset; // Don't want to hit yourself with your own projectile, do you?
    Rigidbody2D rb;
    public GameObject owner;
    // Used to determine player characters.

    // Start is called before the first frame update
    void Start()
    {
        Vector3 transformScale = owner.transform.localScale;
        rb = GetComponent<Rigidbody2D>();
        if (transformScale.x < 0)
        // Checks transformation scale of x to determine if character is facing left.
        {
            var direction = Vector3.left * 1.2f + Vector3.up * 0.8f;
            Debug.Log("Left: " + direction);
            rb.AddForce(direction * speed, ForceMode2D.Impulse);
            // Impulse ensures instant force application, accounting for mass.
        }
        else
        // Assume player is facing right in any other circumstance of x.
        {
            var direction = Vector3.right * 1.2f + Vector3.up * 0.8f;
            Debug.Log("Right: " + direction);
            rb.AddForce(direction * speed, ForceMode2D.Impulse);
            // Impulse ensures instant force application, accounting for mass.
        }
        transform.Translate(launchOffset);
        Destroy(gameObject, 5);
        // Will destroy itself after 5 seconds.
        // This ensures that it will always be removed and not cause too many instances to be active at the same time.
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.LogWarning("Bomb hit: " + hitInfo.name);

        PlayerHit hitPlayer = hitInfo.GetComponent<PlayerHit>();

        if  (hitPlayer != null)
        {
            if (hitInfo.gameObject != owner)
            // Checks projectile isn't hitting its owner.
            {
                hitPlayer.IsHit();
                Destroy(gameObject); // Destroys self if actually hitting player.
            }
        }

        else
        {
            Destroy(gameObject); // Destroys self hitting anything else.
        }
    }
}
