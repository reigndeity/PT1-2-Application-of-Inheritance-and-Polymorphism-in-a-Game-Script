using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gladiator : Swordsman
{
    public string playerSubClass = "Gladiator";

    void Start()
    {
        Debug.Log(playerSubClass);
        Attack();
        Skill();

    }

    public override void Attack()
    {
        Debug.Log("Gladiator Attacked");
        normalInfoTxt = "Gladiator used a Normal Attack";
        GameManager.instance.normalTxt.text = normalInfoTxt;
        //base.Attack();

    }
    public override void Skill()
    {
        Debug.Log("Gladiator used SKill");
        skillInfoTxt = "Gladiator used a Skill Attack";
        GameManager.instance.skillTxt.text = skillInfoTxt;
        //base.Skill();

    }
}
