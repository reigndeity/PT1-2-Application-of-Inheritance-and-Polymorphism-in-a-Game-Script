using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artillery : Archer
{
    public string playerSubClass = "Artillery";
    void Start()
    {
        Debug.Log(playerSubClass);
        Attack();
        Skill();

    }

    public override void Attack()
    {
        Debug.Log("Artillery Attacked");
        normalInfoTxt = "Artillery used a Normal Attack";
        GameManager.instance.normalTxt.text = normalInfoTxt;
        //base.Attack();

    }
    public override void Skill()
    {
        Debug.Log("Artillery used SKill");
        skillInfoTxt = "Artillery used a Skill Attack";
        GameManager.instance.skillTxt.text = skillInfoTxt;
        //base.Skill();

    }
}
