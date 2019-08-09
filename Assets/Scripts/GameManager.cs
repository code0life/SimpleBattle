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
        Debug.Log(all_abilites.Count + " столько абилок ");

        for (int i = 0; i < BSM.hero_units.Count; ++i)
            for (int j = 0; j < all_abilites.Count; ++j)
            {
                //Debug.Log("Unit " + BSM.hero_units[i].GetComponent<UnitStateMachine>().unit.unit_name);
                BSM.hero_units[i].GetComponent<UnitStateMachine>().unit.abilities.Add(all_abilites[j]);
                //Debug.Log("Добавляем абилку " + all_abilites[j].name);
            }

        for (int i = 0; i < BSM.evil_units.Count; ++i)
            for (int j = 0; j < all_abilites.Count; ++j)
            {
                //Debug.Log("Unit " + BSM.evil_units[i].GetComponent<UnitStateMachine>().unit.unit_name);
                BSM.evil_units[i].GetComponent<UnitStateMachine>().unit.abilities.Add(all_abilites[j]);
                //Debug.Log("Добавляем абилку " + all_abilites[j].name);
            }

        //BSM.hero_units.get
    }
    void SetAllUnitHP()
    {

    }
}
