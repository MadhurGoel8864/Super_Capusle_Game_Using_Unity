using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scripts : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    [SerializeField]public float movement_speed = 6f;
    [SerializeField]public float jump_force = 4f;
    [SerializeField] Transform GroundCheck;
    [SerializeField] AudioSource JumpSound;
    [SerializeField] LayerMask ground;
    
    void Start()
    {
    rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal_input = Input.GetAxis("Horizontal");
        float vertical_input = Input.GetAxis("Vertical");
        rb.velocity = new Vector3(horizontal_input*movement_speed,rb.velocity.y,vertical_input*movement_speed);
        // flo.transform.Translate(Vector2.right * Time.deltaTime*5);

        if(Input.GetButtonDown("Jump") && isGrounded()){
            Jump();
            JumpSound.Play();
        }

    }


    void Jump(){
            rb.velocity =new Vector3(rb.velocity.x,jump_force,rb.velocity.z) ;

    }

  private void OnCollisionEnter(Collision collisioned){
        if(collisioned.gameObject.CompareTag("Enemy Head") ){
            print("enemy destroy");
            Destroy(collisioned.transform.parent.gameObject);
            Jump();
        }
    }

    bool isGrounded(){
        return Physics.CheckSphere(GroundCheck.position,5f,ground);

    }
}
