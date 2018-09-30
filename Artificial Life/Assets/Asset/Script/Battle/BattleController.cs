using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleController : MonoBehaviour {

    public RobotController Player;
    public RobotController Enemy;
    public bool currentTurn = true; //true = player false = enemy
    public bool playerMoved = false;
    public bool PauseState = false; //true is paused
    public bool EndGame = false; //true is gameover
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //StartBattle();
        //StartCoroutine(Battle());
        if (currentTurn == true)
        {
            Debug.Log("Player Turn");
            Debug.Log("Select a move (1-4)");
            Debug.Log(currentTurn);
            StartCoroutine(Battle());
            playerMoved = false;
        }
        else if (currentTurn == false)
        {
            Debug.Log("Enemy Turn");
            EnemyTurn();
        }
        //checkEnd

    }

    IEnumerator Battle()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("Move 1 Selected");
            Move(Player.MoveSet[0], Player, Enemy);
            playerMoved = true;

        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("Move 2 Selected");
            Move(Player.MoveSet[1], Player, Enemy);
            playerMoved = true;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Debug.Log("Move 3 Selected");
            Move(Player.MoveSet[2], Player, Enemy);
            playerMoved = true;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Debug.Log("Move 4 Selected");
            Move(Player.MoveSet[3], Player, Enemy);
            playerMoved = true;
        }
        if (playerMoved == false)
            yield return null;
        else if (playerMoved == true)
            yield break;

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

    public void Move(RobotMove Move, RobotController Current, RobotController Target)
    {
        Current.buffCounter -= 1;
        Current.debuffCounter -= 1;

        if (Current.buffCounter <= 0)
        {
            Current.AttackMin = Current.BaseAttackMin;
            Current.AttackMax = Current.BaseAttackMax;
        }
        if (Current.debuffCounter <= 0)
        {
            Current.Defense = Current.BaseDefense;
            
        }
        Debug.Log("Move");
        if (Move.Type == RobotMoveType.Attack)
            Target.CurrentHealth -= (Random.Range(Current.AttackMin, Current.AttackMax) - Target.Defense);
        else if (Move.Type == RobotMoveType.Defend)
            Target.Defense += Move.Power;
        else if (Move.Type == RobotMoveType.Buff)
        {
            Target.AttackMin += Move.Power;
            Target.AttackMax += Move.Power;
            Current.buffCounter = 3;
        }
        //Target.Defense += Move.Power;
        else if (Move.Type == RobotMoveType.Debuff)
        {//Target.Attack -= Move.Power;
            Target.Defense -= Move.Power;
            Target.debuffCounter = 3;
        }
        Debug.Log("Target Name: " + Target.Name + " Target's Current Health: " + Target.CurrentHealth + " Target's Max Health" + Target.MaxHealth + " Attacker's Attack Range: " + Current.AttackMin + " - " + Current.AttackMax + " Target's Defense: " + Target.Defense );

        currentTurn = !currentTurn;
    }

    public void EnemyTurn()
    {
        int chose = Random.Range(0, 3);

        Move(Enemy.MoveSet[chose], Enemy, Player);

    }
}
