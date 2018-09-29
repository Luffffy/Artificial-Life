using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRobot : RobotController {

    private RobotAttack currentAttack;
    private EnemyRobot currentEnemyTarget;

    // Use this for initialization
    void Start () {
        MaxHealth = 100;
        CurrentHealth = 100;
        AttackMin = 10;
        AttackMax = 20;
        Defense = 0;
        Speed = 10;
        RobotMove move1 = new RobotMove();
        move1.Name = "Karate Chop";
        move1.Description = "Attack the enemy once with a physical strike.";
        move1.Power = 76;
        move1.Accuracy = 100;
        move1.Type = RobotMoveType.Attack;
        MoveSet.Add(move1);


        RobotMove move2 = new RobotMove();
        move2.Name = "Block";
        move2.Description = "Defend against an enemy attack.";
        move2.Power = 0;
        move2.Accuracy = 100;
        move2.Type = RobotMoveType.Defend;
        MoveSet.Add(move2);

        RobotMove move3 = new RobotMove();
        move3.Name = "Power Up";
        move3.Description = "Increase your attack power.";
        move3.Power = 0;
        move3.Accuracy = 100;
        move3.Type = RobotMoveType.Buff;
        MoveSet.Add(move3);

        RobotMove move4 = new RobotMove();
        move4.Name = "Pierce";
        move4.Description = "Attack the enemy with a weak strike that ignores defense.";
        move4.Power = 38;
        move4.Accuracy = 100;
        move4.Type = RobotMoveType.Attack;
        MoveSet.Add(move4);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
