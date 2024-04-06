using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundBlock : MonoBehaviour
{

    public Transform other_Block;
    public float half_Length = 100f;
    private Transform player;
    private float endOffSet = 10f;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        MoveGround();
    }

    void MoveGround()
    {
        if(transform.position.z + half_Length < player.transform.position.z - endOffSet)
        {
            transform.position = new Vector3(other_Block.position.x, other_Block.position.y, other_Block.position.z + half_Length * 2);
        }
    }

} // class
