using System.Collections;
using System.Collections.Generic;
using UnityEngine;





 
using UnityEngine.UI;

public class JoystickPlayerExample : MonoBehaviour
{
    public float accelerationRate = 10f; // Скорость ускорения
    public float maxSpeed = 200f; // Максимальная скорость
    private float currentSpeed = 0f; // Текущая скорость

    public float speedForward = 0.7f;
    public VariableJoystick variableJoystick;
    public Rigidbody rb;
    public GameObject joisticBackground;
    public Text speedText;

    private void Start()
    {
        speedText.text = "Speed: 0 km/h"; // Инициализируем текст скорости
    }

    public void FixedUpdate()
    {
        if (joisticBackground.activeSelf)
        {
            // Увеличиваем скорость до максимальной
            if (currentSpeed < maxSpeed)
            {
                currentSpeed += accelerationRate * Time.fixedDeltaTime;
            }
            else
            {
                currentSpeed = maxSpeed; // Устанавливаем максимальную скорость
            }

            // Отображаем скорость
            speedText.text = "Speed: " + Mathf.Round(currentSpeed) + " km/h";

            // Машина движется вперед только если joisticBackground активен
            Vector3 direction = transform.forward * speedForward
                                + transform.right * variableJoystick.Horizontal; // Движение влево и вправо
            rb.AddForce(direction * currentSpeed * Time.fixedDeltaTime, ForceMode.VelocityChange);
        }
        else
        {
            // Если joisticBackground не активен, сбрасываем скорость
            currentSpeed = 0f;
        }
    }
}

