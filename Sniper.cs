using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sniper : Archer
{
    public string playerSubClass = "Sniper";
    void Start()
    {
        Debug.Log(playerSubClass);
        Attack();
        Skill();

    }

    public override void Attack()
    {
        Debug.Log("Sniper Attacked");
        normalInfoTxt = "Sniper used a Normal Attack";
        GameManager.instance.normalTxt.text = normalInfoTxt;
        //base.Attack();

    }
    public override void Skill()
    {
        Debug.Log("Sniper used SKill");
        skillInfoTxt = "Sniper used a Skill Attack";
        GameManager.instance.skillTxt.text = skillInfoTxt;
        //base.Skill();

    }
}
