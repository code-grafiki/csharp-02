using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;

    void Start()
    {
        
    }


    void Update()
    {
        transform.position = Player.transform.position + new Vector3 (0 , 4, -10);    
    }
}
