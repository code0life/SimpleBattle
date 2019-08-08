using UnityEngine;
using System;

[CreateAssetMenu(fileName = "New Ability", menuName = "Ability")]
public class Ability : ScriptableObject
{
    public new string name;
    public string description;

    public Sprite artwork;

    public float damage;
    public uint cooldown;

    [NonSerialized]
    public uint recharge_timer;

    //public bool is_ready
    //{
    //    get
    //    {
    //        return recharge_timer == 0;
    //    }
    //}

    //public bool prepare { get; set; }

    public float Use()
    {
        //prepare = false;
        recharge_timer = cooldown;
        return damage;
    }

    //public void OnTurnStart()
    //{
    //    if (recharge_timer > 0)
    //        recharge_timer--;
    //}
}
