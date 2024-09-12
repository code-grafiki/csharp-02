using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 20.0f;

    void Start()
    {
        
    }

   void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * Speed);

    }
}
