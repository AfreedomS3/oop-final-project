using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Square : Figure
{
    // POLYMORPHISM
    protected override void Move()
    {
        rb.AddForce(impulseForce * new Vector3(0, 0, 1), ForceMode.Impulse);
    }
}
