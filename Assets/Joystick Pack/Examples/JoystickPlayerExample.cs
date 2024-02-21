using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
    public float speed;
    public float speedForward = 0.7f;
    public VariableJoystick variableJoystick;
    public Rigidbody rb;
    public GameObject joisticBackground;

    public void FixedUpdate()
    {
        if (joisticBackground.activeSelf)
        {
            Vector3 direction = Vector3.forward
           * speedForward /*variableJoystick.Vertical*/
           + Vector3.right
           * variableJoystick.Horizontal;

            rb.AddForce(direction
                * speed
                * Time.fixedDeltaTime,
                ForceMode.VelocityChange);
        }
       

      
    }
}