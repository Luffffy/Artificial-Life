using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotMove : MonoBehaviour {

    public string Name { get; set; }
    public string Description { get; set; }
    public RobotMoveType Type { get; set; }
    public int Power { get; set; }
    public int Accuracy { get; set; }
}
