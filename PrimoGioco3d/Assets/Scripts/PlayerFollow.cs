using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour

{
    public Vector3 offset;
    public Transform player; // Il player
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
        //Debug.Log(player.position); //Dov'è il player
    }
}
