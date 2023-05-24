using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float characterSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z + characterSpeed * Time.deltaTime);
        transform.position = newPosition;
    }
}
