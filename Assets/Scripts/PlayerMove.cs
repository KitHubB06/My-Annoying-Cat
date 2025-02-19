using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
    
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private float moveInputH;
    private float moveInputV;
    private InteractableObject currentInteractableObject;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInputH = Input.GetAxis("Horizontal");
        moveInputV = Input.GetAxis("Vertical");

        if(currentInteractableObject != null && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Yes is Interact");
            currentInteractableObject.Interactable();
        }

    }


    private void FixedUpdate()
    {

    
        rb.velocity = new Vector2(moveInputH * moveSpeed, moveInputV * moveSpeed);
  
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Interactable"))
        {
            currentInteractableObject = other.GetComponent<InteractableObject>();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Interactable"))
        {
            currentInteractableObject = null;
        }
    }
}
