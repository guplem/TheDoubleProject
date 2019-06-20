using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderController : MonoBehaviour
{

    public bool inContact { get; private set; }
    private bool isColTrigger;

    private void Start()
    {
        isColTrigger = GetComponent<Collider2D>().isTrigger;
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (isColTrigger)
            inContact = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (isColTrigger)
            inContact = false;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!isColTrigger)
            inContact = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (!isColTrigger)
            inContact = false;
    }

}
