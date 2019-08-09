using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BattleStateMachine : MonoBehaviour
{

    public enum BattleState
    {
        WAITING,
        ACTION
    }

    public BattleState battle_state;

    //public List<GameObject> hero_units;
    //public List<GameObject> evil_units;

    public List<GameObject> hero_units = new List<GameObject>();
    public List<GameObject> evil_units = new List<GameObject>();

    public List<Turn> turn_list = new List<Turn>();

    // Start is called before the first frame update
    void Start()
    {
        battle_state = BattleState.WAITING;
        //hero_units = new List<GameObject>(GameObject.FindGameObjectsWithTag("Hero"));
        //evil_units = new List<GameObject>(GameObject.FindGameObjectsWithTag("Evil"));
        hero_units.AddRange(GameObject.FindGameObjectsWithTag("Hero"));
        evil_units.AddRange(GameObject.FindGameObjectsWithTag("Evil"));

    }

    // Update is called once per frame
    void Update()
    {
        switch (battle_state)
        {
            case (BattleState.WAITING):
                break;
            case (BattleState.ACTION):
                break;
        }
    }

    public void HistoryActions( Turn _turn )
    {
        turn_list.Add(_turn);
    }

}
