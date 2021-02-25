using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlaneController : MonoBehaviour
{

    public Transform spawnPoint;
    

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            //get a reference to the players character controller
            var controller = other.gameObject.GetComponent<CharacterController>();
            //turn controller off
            controller.enabled = false;

            //move player to spawn point
          other.gameObject.transform.position = spawnPoint.position;

            //turn controller off
            controller.enabled = true;
        }
    }
}
