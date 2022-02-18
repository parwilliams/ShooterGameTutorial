using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float MaxSpeed = 1f;

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * MaxSpeed * Time.deltaTime;

        if(transform.position.x < -20 || transform.position.x > 20 || transform.position.z <-20 || transform.position.z > 20)
        {
            Destroy(gameObject);
        }
    }
}
