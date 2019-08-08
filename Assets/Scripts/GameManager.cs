using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private BattleStateMachine BSM;

    public List<Ability> all_abilites = new List<Ability>();
    // Start is called before the first frame update
    void Start()
    {
        BSM = GameObject.Find("BattleManager").GetComponent<BattleStateMachine>();

        LoadAllAbilites();
        SetAllUnitAbilites();
        SetAllUnitHP();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadAllAbilites()
    {
        all_abilites = new List<Ability>(Resources.LoadAll<Ability>("Abilites"));
    }

    void SetAllUnitAbilites()
    {
        Debug.Log(BSM.hero_units.Count + " столько героев ");
        Debug.Log(BSM.evil_units.Count + " столько злодеев ");
        for (int i = 0; i < BSM.hero_units.Count; ++i)
            for (int j = 0; j < 2; ++i)
                BSM.hero_units[i].GetComponent<UnitStateMachine>().unit.abilities[j] = GameObject.Instantiate(all_abilites[j]);
        //BSM.hero_units.get
    }
    void SetAllUnitHP()
    {

    }
}
