using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPickUps : MonoBehaviour
{
   public float seconds;


    // Update is called once per frame
    void Update()
    {
       Destroy(gameObject,seconds); 
    }
}
