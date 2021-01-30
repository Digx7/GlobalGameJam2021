using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{

    [SerializeField] private Rigidbody rb;
    [Space]
    [SerializeField] private float forwardSpeedAdjuster = 1.0f;
    [SerializeField] private float backwardSpeedAdjuster = 1.0f;
    [SerializeField] private float leftSpeedAdjuster = 1.0f;
    [SerializeField] private float rightSpeedAdjuster = 1.0f;
    [SerializeField] private float upSpeedAdjuster = 1.0f;
    [SerializeField] private float downSpeedAdjuster = 1.0f;
    [SerializeField] private float upDownRotationAdjuster = 0.5f;
    [SerializeField] private float leftRightRotationAdjuster = 0.5f;


    public void moveFishHorizonally(Vector2 input){

      Vector2 _input = horizontalInputProcessing(input);

      Vector3 locVel = transform.InverseTransformDirection(rb.velocity);
      locVel.x = _input.x * Time.deltaTime;
      locVel.z = _input.y * Time.deltaTime;
      rb.velocity = transform.TransformDirection(locVel);

      //rb.velocity = new Vector3(_input.x, 0, _input.y) * Time.deltaTime;
    }

    public void moveFishVertical(float input){
      Vector3 locVel = transform.InverseTransformDirection(rb.velocity);
      locVel.y = verticalMovementProcessing(input) * Time.deltaTime;
      rb.velocity = transform.TransformDirection(locVel);

      //rb.velocity = new Vector3(0, verticalMovementProcessing(input), 0) * Time.deltaTime;
    }

    public void rotateFish(Vector2 input){
      Vector3 rotation = new Vector3();

      rotation.y += input.x * leftRightRotationAdjuster;
      rotation.x += -input.y * upDownRotationAdjuster;

      gameObject.transform.Rotate(rotation);
    }

    private Vector2 horizontalInputProcessing(Vector2 input){
      Vector2 output = input;

      if(output.x > 0.1) output.x *= forwardSpeedAdjuster;
      else if(output.x < -0.1) output.x *= backwardSpeedAdjuster;
      else output.x = 0;

      if(output.y < -0.1) output.y *= leftSpeedAdjuster;
      else if(output.y > 0.1) output.y *= rightSpeedAdjuster;
      else output.y = 0;

      return output;
    }

    private float verticalMovementProcessing(float input){
      float output = input;

      if(output > 0.1) output *= upSpeedAdjuster;
      else if(output < -0.1) output *= downSpeedAdjuster;
      else output = 0;

      return output;
    }
}
