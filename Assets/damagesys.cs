using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damagesys : MonoBehaviour
{
    void OnCollisionEnter2D() => Debug.Log("TEMAS!");
    void OnTriggerEnter2D() => Debug.Log("Trigger");
}
