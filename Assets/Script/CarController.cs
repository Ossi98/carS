using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
public class CarController : MonoBehaviour
{
    // Start is called before the first frame update
/*    public WheelJoint2D frontwheel;
    public WheelJoint2D backwheel;

    JointMotor2D motorFront;

    JointMotor2D motorBack;

    public float speedF;
    public float speedB;

    public float torqueF;
    public float torqueB;


    public bool TractionFront = true;
    public bool TractionBack = true;


    public float carRotationSpeed;*/

    public float fuel = 1;
    public float fuelConsomation = 0.1f;

    public float speed;
    public float outOfMap;
    private WheelJoint2D wheel;
    private JointMotor2D motor;
    public GameObject[] car;
    public GameObject[] sol;

    public static bool gameOver; 
    public GameObject GameOverPanel;
    public UnityEngine.UI.Image image;
    // Use this for initialization
    void Start () {
        wheel = GetComponent<WheelJoint2D>();
        motor = wheel.motor;
        car = GameObject.FindGameObjectsWithTag("Car");
        sol = GameObject.FindGameObjectsWithTag("Sol");
    
    }
    
    void Update(){



        float hForce = Input.GetAxis("Horizontal");
        image.fillAmount = fuel;
        if (fuel>0) {
        	motor.motorSpeed = speed * hForce;
        	wheel.motor = motor;

        	outOfMap = sol[0].transform.position.y - car[0].transform.position.y;

        	
        	if (outOfMap > 100){

            	car[0].transform.position =  new Vector3(0, 0, 0);  
            	car[0].transform.rotation =  Quaternion.Euler(0, 0, 0);  
            	gameOver = true;
            	GameOverPanel.SetActive(true);
            
        		}



            if ((Math.Abs(car[0].transform.rotation.z) > 0.97 && Math.Abs(car[0].transform.rotation.z) <1 )&& motor.motorSpeed == 0 ){
                gameOver = true;
                GameOverPanel.SetActive(true);
            }

       // Debug.Log(car[0].transform.rotation.z+"  -- "+motor.motorSpeed);
        }



        fuel -= fuelConsomation * Mathf.Abs(hForce)* Time.fixedDeltaTime/10;
         Debug.Log(fuel);
        if(fuel<0f){
        	Debug.Log(fuel);
        	motor.motorSpeed = 0;
        	wheel.motor = motor;
            gameOver = true;
            GameOverPanel.SetActive(true);
        }


        // if(respawns[0].transform.rotation.z < -0.8 && speed == 0){

        //  Debug.Log(respawns[0].transform.rotation.z);
        //  Application.Quit();
        // }

        


    }
    // Update is called once per frame
/*    void Update () {
    
        if (Input.GetAxisRaw ("Vertical") > 0) {
            

            if (TractionFront) {
                motorFront.motorSpeed = speedF ;
                motorFront.maxMotorTorque = torqueF;
                frontwheel.motor = motorFront;
            }

            if (TractionBack) {
                motorBack.motorSpeed = speedF * 1;
                motorBack.maxMotorTorque = torqueF;
                backwheel.motor = motorBack;
            }

        } else if (Input.GetAxisRaw ("Vertical") < 0) {


            if (TractionFront) {
                motorFront.motorSpeed = speedB * -1;
                motorFront.maxMotorTorque = torqueB;
                frontwheel.motor = motorFront;
            }

            if (TractionBack) {
                motorBack.motorSpeed = speedB * -1;
                motorBack.maxMotorTorque = torqueB;
                backwheel.motor = motorBack;
            }

        } else {

            backwheel.useMotor = false;
            frontwheel.useMotor = false;

        }

        if (Input.GetAxisRaw ("Horizontal") != 0) {

            GetComponent<Rigidbody2D> ().AddTorque (carRotationSpeed * Input.GetAxisRaw ("Horizontal") * -1);

        }
    }*/
}
