using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Transform target;
    [SerializeField] private Rigidbody2D myRigidbody;
    [HideInInspector] public bool canMove;
    [SerializeField] float movementSpeed;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        canMove = true;
    }
    
    private void Update()
    {
        if(canMove)
        {
            RunAwayFromPlayer();
        }
    }
    
    private void RunAwayFromPlayer()
    {
        myRigidbody.velocity = -(target.transform.position - transform.position) * movementSpeed * Time.deltaTime;  
    }
}
