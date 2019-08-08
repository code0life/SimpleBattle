using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI
{
    private BattleStateMachine BSM;

    //static Ability GetHealAbility(Unit unit)
    //{
    //    foreach (var ability in unit.abilities)
    //    {
    //        if (ability.damage < 0.0f && ability.is_ready)
    //            return ability;
    //    }

    //    return null;
    //}

    //static Ability GetBestAttackAbility(Unit unit)
    //{
    //    Ability best = null;
    //    foreach (var ability in unit.abilities)
    //    {
    //        if (ability.damage < 0.0f || !ability.is_ready)
    //            continue;

    //        if (best == null || best.damage < ability.damage)
    //            best = ability;
    //    }

    //    return best;
    //}
    public static void ChoiseEnemy(Unit unit)
    {
        if (ally.Count == 0 || enemy.Count == 0)
            return;

        //foreach (var ally_unit in ally)
        //{
        //    var heal_ability = GetHealAbility(unit);
        //    if (heal_ability != null && ally_unit.current_hp < ally_unit.max_hp / 2)
        //    {
        //        //ally_unit.ApplyAbility(heal_ability);
        //        return;
        //    }
        //}

        //var attack_ability = GetBestAttackAbility(unit);
        //if (attack_ability != null)
        //{
        //    var enemy_unit = enemy[UnityEngine.Random.Range(0, enemy.Count)];
        //    //enemy_unit.ApplyAbility(attack_ability);
        //}
    }
    public static void MakeAction(Unit unit, List<GameObject> ally, List<GameObject> enemy)
    {
        if (ally.Count == 0 || enemy.Count == 0)
            return;

        //foreach (var ally_unit in ally)
        //{
        //    var heal_ability = GetHealAbility(unit);
        //    if (heal_ability != null && ally_unit.current_hp < ally_unit.max_hp / 2)
        //    {
        //        //ally_unit.ApplyAbility(heal_ability);
        //        return;
        //    }
        //}

        //var attack_ability = GetBestAttackAbility(unit);
        //if (attack_ability != null)
        //{
        //    var enemy_unit = enemy[UnityEngine.Random.Range(0, enemy.Count)];
        //    //enemy_unit.ApplyAbility(attack_ability);
        //}
    }
}
