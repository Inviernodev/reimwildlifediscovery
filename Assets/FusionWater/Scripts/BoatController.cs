using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("FusionWater/_Examples/BoatController")]
public class BoatController : MonoBehaviour
{

    [SerializeField]
    public ParticleSystem particulaVapor;
    [SerializeField]
    public ParticleSystem particulaChoque;
   

    public float moveSpeed = 10f;
    public float turnSpeed = 10f;

    [Range(0.5f, 5)]
    public float accelerationTime = 3f;
    private float accTime = 0;

    public AnimationCurve accelerationCurve;

    public Transform boatMotor;
    private Vector3 startRotation;

    private Rigidbody rb;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Terrain")
        {
            particulaChoque.Play();
 
            Debug.Log("Choco: ");
        }
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        startRotation = boatMotor.localEulerAngles;
    }

    void FixedUpdate()
    {
        float moveInput = -Input.acceleration.z;
        float turnInput = Input.acceleration.x;

        if (moveInput == 0)
        {
            accTime = 0;
        }
        else
        {
            accTime += Time.fixedDeltaTime;
        }
            

        float accelerationFactor = 1 / accelerationTime;
        float acceleration = accelerationCurve.Evaluate(accTime * accelerationFactor);

        //Add Force at Boat Motors Position
        if (moveInput < 0.55)
        {
            particulaVapor.Stop();
            moveInput = moveInput - 0.55f;
            rb.AddForceAtPosition(moveInput * acceleration * moveSpeed * boatMotor.forward, boatMotor.position);
        }
        else
        {
            particulaVapor.Play();
            rb.AddForceAtPosition(moveInput * acceleration * moveSpeed * boatMotor.forward, boatMotor.position);
        }
        

        //Rotate the Motor itself (subtract: Motor turning left = Boat turning right)
        boatMotor.localEulerAngles = startRotation;
        boatMotor.Rotate(Vector3.right, turnInput * turnSpeed, Space.Self);
    }
}
