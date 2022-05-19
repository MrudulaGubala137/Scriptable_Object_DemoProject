using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="NewCar",menuName ="Cars")]
public class Cars : ScriptableObject
{
    public string carName;
    public Sprite carImage;
    public string carDescription;
    public int rank;
    public int score;

}
