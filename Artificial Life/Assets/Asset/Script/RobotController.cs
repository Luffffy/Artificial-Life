using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour {

    public string Name;
    public float MaxHealth;
    public float CurrentHealth;
    public float AttackMin;
    public float AttackMax;
    public float BaseAttackMin;
    public float BaseAttackMax;
    public float BaseDefense;
    public float Defense;
    public float Speed;
    public bool isProtected;
    public int buffCounter;
    public int debuffCounter;
    public List<RobotMove> MoveSet;




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
