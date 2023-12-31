using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState
{
    void Enter();
    void Execute();
    void Exit();

}

public class IdleState : IState
{
    private AdvancedEnemy enemy;

    public IdleState(AdvancedEnemy enemy)
    {
        this.enemy = enemy;
    }

    public void Enter()
    {
        Debug.Log("Entered Idle");
    }

    public void Execute()
    {
        Debug.Log("Idling");
    }

    public void Exit()
    {
        Debug.Log("Exited Idle");
    }
}

public class ChaseState : IState
{

    private AdvancedEnemy enemy;

    public ChaseState(AdvancedEnemy enemy)
    {
        this.enemy = enemy;
    }

    public void Enter()
    {

    }

    public void Execute()
    {

    }

    public void Exit()
    {

    }
}

public class StateMachine
{
    
    private IState currentState;

    public void SetState(IState state)
    {
        if(currentState != null)
        {
            currentState.Exit();
        }
        currentState = state;
        currentState.Enter();
    }

    public void Execute()
    {
        if(currentState != null)
        {
            currentState.Execute();
        }
    }
}

public class AdvancedEnemy : MonoBehaviour
{
    private StateMachine stateMachine;

    private void Awake()
    {
        stateMachine = new StateMachine();
        stateMachine.SetState(new IdleState(this));
    }

    private void Update()
    {
        stateMachine.Execute();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            stateMachine.SetState(new ChaseState(this));
        }
    }
}
