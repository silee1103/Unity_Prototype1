using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    private Vector3 _offset = new Vector3(0, 5, -10);
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void LateUpdate()
    {
        transform.position = player.transform.position + _offset;
    }
}
