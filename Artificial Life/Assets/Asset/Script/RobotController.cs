using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour {

    public float MaxHealth { get; set; }
    public float CurrentHealth { get; set; }
    public float AttackMin { get; set; }
    public float AttackMax { get; set; }
    public float Defense { get; set; }
    public float Speed { get; set; }
    public bool isProtected { get; set; }
    public List<RobotMove> MoveSet { get; set; }




    // Use this for initialization
    void Start () {
        isProtected = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Dead()
    {
        if(CurrentHealth < 0)
        {
            //dead
        }
    }

    
}
