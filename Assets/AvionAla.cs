using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvionAla : MonoBehaviour
{
   
   public float girospeed;

    // Update is called once per frame
    void Update()
    {
      transform.Rotate(Vector3.forward * girospeed * Time.deltaTime);
    }
}
