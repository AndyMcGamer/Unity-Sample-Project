using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EnemyAI : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float chaseRange;

    private Vector3 direction;
    private void Update()
    {
        if (Vector3.Distance(transform.position, target.position) <= chaseRange)
        {
            direction = (target.position - transform.position);
            direction.y = 0;
        }
        else
        {
            direction = Vector3.zero;
        }
        // transform.position += direction.normalized * speed * Time.deltaTime;
    }

    private void FixedUpdate()
    {
        
        rb.velocity = direction.normalized * speed;
        // transform.position += direction.normalized * speed * Time.fixedDeltaTime;
    }

}
