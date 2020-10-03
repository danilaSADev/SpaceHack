using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cController : MonoBehaviour
{
    float vertical;
    float horizontal;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world!");
    }

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxisRaw("Vertical");
        horizontal = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(horizontal, 0, vertical ) * Time.deltaTime;
        Debug.Log("Y: " + vertical + " ; X: " + horizontal);
    }
}
