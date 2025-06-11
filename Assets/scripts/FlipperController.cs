using UnityEngine;

public class FlipperController : MonoBehaviour
{
    public HingeJoint2D leftFlipper;
    public HingeJoint2D rightFlipper;
    public float motorSpeed = 1000f;
    public float motorMaxTorque = 10000f;

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            SetMotor(leftFlipper, -motorSpeed);
        }
        else
        {
            SetMotor(leftFlipper, motorSpeed);
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            SetMotor(rightFlipper, motorSpeed);
        }
        else
        {
            SetMotor(rightFlipper, -motorSpeed);
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
