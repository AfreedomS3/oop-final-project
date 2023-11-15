using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cylinder : Figure
{
    private float torqueForce = 50.0f;

    // POLYMORPHISM
    protected override void Move()
    {
        rb.AddForce(impulseForce * new Vector3(0, 1, 0).normalized, ForceMode.Impulse);
        rb.AddTorque(torqueForce * new Vector3(1, 1, 0).normalized);
    }
}
