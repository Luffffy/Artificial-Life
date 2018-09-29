using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleController : MonoBehaviour {

    public RobotController Player;
    public RobotController Enemy;
    public bool currentTurn = true; //true = player false = enemy
    public bool PauseState = false; //true is paused
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Debug.Log("Select a move (1-4)");
        if (Input.GetButtonDown("1"))
        {
            Move(Player.MoveSet[0], Enemy);
        }
        else if (Input.GetButtonDown("2"))
        {
            Move(Player.MoveSet[1], Enemy);
        }
        else if (Input.GetButtonDown("3"))
        {
            Move(Player.MoveSet[2], Enemy);
        }
        else if (Input.GetButtonDown("4"))
        {
            Move(Player.MoveSet[3], Enemy);
        }
        Debug.Log("Enemy Turn");
        EnemyTurn();

    }

    public void StartBattle()
    {
        if (Player.Speed > Enemy.Speed)
            currentTurn = true;
        else
            currentTurn = false;
    }

    public void Pause()
    {
        //bring up pause menu
    }

    public void Move(RobotMove Move, RobotController Target)
    {
        if (Move.Type == RobotMoveType.Attack)
            Target.CurrentHealth -= (Move.Power - Target.Defense);
        else if (Move.Type == RobotMoveType.Defend)
            Target.Defense += Move.Power;
        else if (Move.Type == RobotMoveType.Buff)
        { 
            Target.AttackMin += Move.Power;
        Target.AttackMax += Move.Power;
        }
            //Target.Defense += Move.Power;
        else if (Move.Type == RobotMoveType.Debuff)
            //Target.Attack -= Move.Power;
            Target.Defense -= Move.Power;
        Debug.Log("Target Name: " + Target.name + " Current Health: " + Target.CurrentHealth + "Attack Range" + Target.AttackMin + " - " + Target.AttackMax + "Target.Defense: " + Target.Defense );

    }

    public void EnemyTurn()
    {

    }
}
