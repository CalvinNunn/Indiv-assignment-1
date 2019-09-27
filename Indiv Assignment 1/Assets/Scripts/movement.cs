using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) {
            transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + 1);
        }
        if (Input.GetKeyDown(KeyCode.A)) {
            transform.position = new Vector3(this.transform.position.x - 1, this.transform.position.y, this.transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.S)) {
            transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z - 1);
        }
        if (Input.GetKeyDown(KeyCode.D)) {
            transform.position = new Vector3(this.transform.position.x + 1, this.transform.position.y, this.transform.position.z);
        }
    }
}
