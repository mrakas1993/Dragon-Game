using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointScript : MonoBehaviour
{
    private DeadZone respawn;
    // Start is called before the first frame update
    void Start()
    {
        GameObject respawnObject = GameObject.FindGameObjectWithTag("deadZone");
        if (respawnObject != null)
        {
            respawn = respawnObject.GetComponent<DeadZone>();
            Debug.Log("Yes");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            respawn.respawnPoint = this.gameObject;
        }
    }
}
