using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Unit
{

    public string unit_name;
    public float max_hp;
    public List<Ability> abilities = new List<Ability>();
    public Type unit_type;

    float _current_hp;

    public float current_hp
    {
        get
        {
            return _current_hp;
        }
        set
        {
            _current_hp = value;
            if (_current_hp < 0.0f)
                _current_hp = 0.0f;
            if (_current_hp > max_hp)
                _current_hp = max_hp;
        }
    }

    List<Ability> available_abilities = new List<Ability>();

    public enum Type
    {
        FIRE,WATER
    }

    void SetUnitHealth()
    {
        current_hp = max_hp;

    }
    void SetUnitAbility()
    {
        for (int i = 0; i < abilities.Count; ++i)
        abilities[i] = GameObject.Instantiate(abilities[i]);

    }

    //public void ApplyAbility(Ability ability)
    //{
    //    ability.Use();
    //    current_hp -= ability.damage;
    //}

    //public void Start()
    //{
    //    for (int i = 0; i < abilities.Count; ++i)
    //        abilities[i] = GameObject.Instantiate(abilities[i]);
    //    current_hp = max_hp;
    //}

    //Ability GetRandomAbility()
    //{
    //    available_abilities.Clear();
    //    foreach (var ability in abilities)
    //    {
    //        if (ability.is_ready)
    //            available_abilities.Add(ability);
    //    }
    //    return available_abilities[UnityEngine.Random.Range(0, available_abilities.Count)];
    //}

    //public void OnTurnStart()
    //{
    //    foreach (var ability in abilities)
    //        ability.OnTurnStart();
    //}
}
