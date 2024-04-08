using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Swordsman : PlayerAbstract
{
    public string playerClass = "Swordsman";
    private void Start()
    {
        //Debug.Log(playerName);
       // Debug.Log(playerClass);
        Attack();
        Skill();
    }

    public override void Attack()
    {
        Debug.Log("Swordsman: Normal Attack");
        normalInfoTxt = "Swordsman used a Normal Attack";
        GameManager.instance.normalTxt.text = normalInfoTxt;
        // base.Attack();
    }
    public override void Skill()
    {
        Debug.Log("Swordsman: Skill Attack");
        skillInfoTxt = "Swordsman used a Skill Attack";
        GameManager.instance.skillTxt.text = skillInfoTxt;
        // base.Skill();
    }

}
