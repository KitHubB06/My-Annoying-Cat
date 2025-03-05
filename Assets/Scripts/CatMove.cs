using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMove : MonoBehaviour
{
    public List<Transform> points; 
    public float speed = 5f; 

    private Rigidbody2D rb;
    private int currentPointIndex = 0; 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if (points.Count > 0)
        {
            MoveToNextPoint();
        }
    }

    void Update()
    {
        if (points.Count == 0) return; 

        Vector2 targetPosition = points[currentPointIndex].position;
        Vector2 direction = (targetPosition - rb.position).normalized;

        rb.velocity = direction * speed;

        if (Vector2.Distance(rb.position, targetPosition) < 0.1f)
        {
            currentPointIndex = (currentPointIndex + 1) % points.Count;
            MoveToNextPoint();
        }
    }

    private void MoveToNextPoint()
    {
        Vector2 targetPosition = points[currentPointIndex].position;
        Vector2 direction = (targetPosition - rb.position).normalized;
        rb.velocity = direction * speed;
    }
}
