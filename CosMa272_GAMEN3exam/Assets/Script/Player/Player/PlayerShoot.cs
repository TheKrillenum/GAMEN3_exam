using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject projectilePrefab;
    private Vector3 playerPosition;
    public float dfp = 1.5f; //distance from player

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButton("Fire1"))
        {
            playerPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z) + transform.forward * dfp;
            Instantiate(projectilePrefab, playerPosition, transform.rotation);
        }
    }
}
