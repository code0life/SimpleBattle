using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitStateMachine : MonoBehaviour
{

    private BattleStateMachine BSM;

    public Unit unit;
    private float current_cooldown = 0f;
    private float max_cooldown = 5f;

    public enum UnitState
    {
        WAITING,
        ACTION,
        DEAD,
        PROCESS,
        CHOISE

    }

    public UnitState current_state;

    // Start is called before the first frame update
    void Start()
    {
        current_state = UnitState.PROCESS;
        BSM = GameObject.Find("BattleManager").GetComponent<BattleStateMachine>();
    }

    void Update()
    {
        switch (current_state)
        {
            case (UnitState.WAITING):
                break;
            case (UnitState.ACTION):
                break;
            case (UnitState.DEAD):
                break;
            case (UnitState.PROCESS):
                break;
            case (UnitState.CHOISE):
                break;
         }
    }

    void UpdateProgressBar()
    {
        current_cooldown = current_cooldown + Time.deltaTime;
    }

    void Choise()
    {
        Turn current_turn = new Turn();
        current_turn.attack_name_unit = unit.unit_name;
        current_turn.AttackObj = this.gameObject;
        //current_turn.TargetAttack = AI.MakeAction(unit, BSM.hero_units, BSM.evil_units );
        //current_turn.TargetAttack = AI.ChoiseEnemy(unit);
        var enemy_unit = BSM.evil_units[UnityEngine.Random.Range(0, BSM.evil_units.Count)];
        //enemy_unit.ApplyAbility(attack_ability);

    }

}
