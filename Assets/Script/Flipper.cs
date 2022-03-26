using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    [SerializeField]
    private float SpringConst = 0.0f;
    [SerializeField]
    private float angle = 0.0f;
    [SerializeField]
    private float flipperDamp = 0.0f;
    [SerializeField]
    private KeyCode inputKey;

    [SerializeField]
    HingeJoint hingeJoint;

    private JointSpring jointSpring;
    private void Start()
    {
        hingeJoint.useSpring = true;
        jointSpring = new JointSpring();
        jointSpring.spring = SpringConst;
        jointSpring.damper = flipperDamp;
        jointSpring.targetPosition = 0.0f;
        hingeJoint.spring = jointSpring;
    }

    private void Update()
    {
        if (Input.GetKeyDown(inputKey))
        {
            OnPressed();
        }
        if (Input.GetKeyUp(inputKey))
        {
            offPressed();
        }
    }

    private void OnPressed()
    {
        jointSpring.targetPosition = angle;
        hingeJoint.spring = jointSpring;
    }

    private void offPressed()
    {
        jointSpring.targetPosition = 0.0f;
        hingeJoint.spring = jointSpring;
    }
}
