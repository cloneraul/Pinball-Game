using UnityEngine;

public class FlipperController : MonoBehaviour
{
    public HingeJoint2D leftFlipper;
    public HingeJoint2D rightFlipper;
    public float motorSpeed = 1000f;
    public float motorMaxTorque = 10000f;

    void Update()
    {
        // Flipper esquerdo (seta esquerda ou A)
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            SetMotor(leftFlipper, -motorSpeed); // gira pra dentro
        }
        else
        {
            SetMotor(leftFlipper, motorSpeed); // repouso
        }

        // Flipper direito (seta direita ou D)
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            SetMotor(rightFlipper, motorSpeed); // gira pra dentro
        }
        else
        {
            SetMotor(rightFlipper, -motorSpeed); // repouso
        }
    }

    void SetMotor(HingeJoint2D hinge, float speed)
    {
        JointMotor2D motor = hinge.motor;
        motor.motorSpeed = speed;
        motor.maxMotorTorque = motorMaxTorque;
        hinge.motor = motor;
    }
}
