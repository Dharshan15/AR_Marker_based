using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButton : MonoBehaviour
{
    public GameObject cube;
    VirtualButtonBehaviour vButton;
    public Rigidbody rbCube;
    void Start()
    {
        cube.SetActive(true);

        vButton = GetComponentInChildren<VirtualButtonBehaviour>();
    }
    private void FixedUpdate()
    {
        vButton.RegisterOnButtonPressed(onButtonPressed);
        vButton.RegisterOnButtonReleased(onButtonReleased);
    }
    void onButtonPressed(VirtualButtonBehaviour vb)
    {
        rbCube.AddForce(Vector3.right*Time.deltaTime*12);
    }
    void onButtonReleased(VirtualButtonBehaviour vb)
    {
        rbCube.AddForce(Vector3.right*Time.deltaTime*-12);
    }
}
