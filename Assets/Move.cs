﻿using UnityEngine;

public class Move : MonoBehaviour {

    public GameObject goal;
    Vector3 direction;
    public float speed = 5f;

    void Start() {

        //direction = goal.transform.position - transform.position;
       
        //transform.Translate(direction);
      
    }

    private void LateUpdate() 
    {
         direction = goal.transform.position - transform.position;
         transform.LookAt(goal.transform.position);
         if (direction.magnitude > 2)
         {
            Vector3 velocity = direction.normalized * speed * Time.deltaTime;
            transform.position = transform.position + velocity;
         }

    }
}
