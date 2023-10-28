using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollector : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        //Check if the other game object has the ICollectible interface
        if(collision.gameObject.TryGetComponent(out ICollectible collectible))
        {
            //If it does, call the collect method
            collectible.Collect();
        }
    }
}
