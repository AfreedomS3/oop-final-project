using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Sphere : Figure
{
    // POLYMORPHISM
    protected override void Move()
    {
        rb.AddForce(impulseForce * new Vector3(0, 1, 0).normalized, ForceMode.Impulse);
    }
}
