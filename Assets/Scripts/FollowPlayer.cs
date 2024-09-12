
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;
    private Vector3 offset = new Vector3(0 , 4, -10);

    void Start()
    {
        
    }


    void Update()
    {
        transform.position = Player.transform.position + offset;    
    }
}
