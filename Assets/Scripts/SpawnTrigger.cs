using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrigger : MonoBehaviour
{
    public GameObject beach;
    float zvalue;
    private void OnTriggerEnter(Collider other) {
       // if (other.gameObject.CompareTag("Player")) {
            zvalue = transform.position.z - 40f;
            Instantiate(beach,new Vector3(0,0,zvalue),Quaternion.identity);
      //  }
    }
}
