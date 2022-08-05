using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1 : MonoBehaviour
{
    private void Start()
    {
        double firstLeg = 8;
        double secondLeg = 9;
        double perimeterTriangle = CalculatePerimeter(firstLeg, secondLeg);
        Debug.Log(perimeterTriangle);
    }

    private double CalculatePerimeter(double firstLeg, double secondLeg)
    {
        double hypotenuse = Math.Sqrt(Math.Pow(firstLeg, 2) + Math.Pow(secondLeg, 2));
        return firstLeg + secondLeg + hypotenuse;
    }
}
