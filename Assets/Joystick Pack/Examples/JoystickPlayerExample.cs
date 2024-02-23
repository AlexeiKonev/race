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
            // Машина движется вперед только если joisticBackground активен
            Vector3 direction = transform.forward * speedForward
                                + transform.right * variableJoystick.Horizontal; // Движение влево и вправо
            rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
        }
    }
}
