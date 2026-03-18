using UnityEngine;

public class PlayerMovement: MonoBehaviours
{
    private Rigidbody rb;
    public float speed = 10F;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Debug.Log("Start function in playmovement script");


        rb = GetComponent<Rigidbody>();
    
    }

    private void FixedUpdate()
    {
        float moveX = input.GetAxis("horizontal");
        float moveZ = input.GetAxis("Vertical");

        Vecter3 movement = new Vecter3(moveX, 0F, moveZ);

        rb AddForce(movement = speed);
    }


    
    
        
    
}
