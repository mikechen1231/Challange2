using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill : MonoBehaviour
{
     public Collider playerCollider; // Attach the collider to the player in the Unity editor
    public KeyCode killButton = KeyCode.Space;


    // Update is called once per frame
    void Update()
    {
                    if (Input.GetKeyDown(killButton))
            {
                Collider[] hitColliders = Physics.OverlapBox(playerCollider.bounds.center, playerCollider.bounds.extents, Quaternion.identity);

            foreach (Collider hitCollider in hitColliders)
            {
                if (hitCollider.CompareTag("enemy")) 
                {
                    // Destroy or deactivate the enemy GameObject
                    Destroy(hitCollider.gameObject);
                }
        
             }
            }
}
}
