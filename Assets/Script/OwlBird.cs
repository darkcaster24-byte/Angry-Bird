using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwlBird : Bird
{
    void OnTriggerEnter2D(Collider2D col)
    {
        string tag = col.gameObject.tag;
        if (tag == "Enemy" || tag == "Obstacle")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
