using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : PlayerAbstract
{
    public string playerClass = "Archer";
    private void Start()
    {
        Debug.Log(playerClass);
        Attack();
        Skill();
    }

    public override void Attack()
    {
        Debug.Log("Archer: Normal Attack");
        normalInfoTxt = "Archer used a Normal Attack";
        GameManager.instance.normalTxt.text = normalInfoTxt;
        //base.Attack();
    }
    public override void Skill()
    {
        Debug.Log("Archer: Skill Attack");
        skillInfoTxt = "Archer used a Skill Attack";
        GameManager.instance.skillTxt.text = skillInfoTxt;
        //base.Skill();
    }

}
