using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour
{
    public float speed = 30;
    GameObject botan;
    // Start is called before the first frame update
    void Start()
    {
        var power = (transform.forward + transform.right) * 10;
        GetComponent<Rigidbody>().AddForce(power, ForceMode.VelocityChange);

        botan = GameObject.Find("Retry");
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x >= 25)
        {
            botan.GetComponent<Button>().interactable = true;
        }
    }
}
