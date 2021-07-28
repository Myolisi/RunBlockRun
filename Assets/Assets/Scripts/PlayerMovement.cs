using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    // Use this for initialization
    public float moveSpeed;

    [HideInInspector]
    public Vector3 position;

    public Rigidbody rigidBody;

    public GameObject pointer;

    [HideInInspector]
    public Vector3 initialPosition;
    [HideInInspector]
    public bool isMoving = true;

    public GameObject deathParticles;
    void Start () {

        initialPosition = transform.position; //current position
        
    }
    
    // Update is called once per frame
    void FixedUpdate () {

        float horizontal = Input.GetAxisRaw("Horizontal");  //GetAxisRaw eliminates the progression in the GetAxis
        float vertical = Input.GetAxisRaw("Vertical");
        position = new Vector3(horizontal, 0f, vertical);

        /*if (rigidBody.velocity.magnitude < moveSpeed) // will remove the progression, same as GetAxisRaw
        {   
        }*/

        if (isMoving == false)
        {
            rigidBody.AddForce(position * moveSpeed);

        }
        else
        {
            isMoving = true;
        }

        
       
    }

    public void OnTriggerEnter (Collider otherCollider)
    {

        if (otherCollider.gameObject.CompareTag("Point"))
         {
            GameManager.CompleteLevel();
        }

        
        
    }

    public void OnCollisionStay(Collision other)    //-stay as long as the collision is happening 
    {
        isMoving = false;
        if (other.gameObject.CompareTag("Enemy") || other.gameObject.CompareTag("Wall"))
        {
            playerDies();
            isMoving = true;
        }

    }

    void playerDies()
    {
        Instantiate(deathParticles, transform.position, Quaternion.identity); //transform.position: player posution, identity: No rotation
        transform.position = initialPosition;
    }
}
