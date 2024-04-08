using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Barbarian : Swordsman
{
    public string playerSubClass = "Barbarian";
    void Start()
    {
        Debug.Log(playerSubClass);
        Attack();
        Skill();

    }

    public override void Attack()
    {
        Debug.Log("Barbarian Attacked");
        normalInfoTxt = "Barbarian used a Normal Attack";
        GameManager.instance.normalTxt.text = normalInfoTxt;
        //base.Attack();

    }
    public override void Skill()
    {
        Debug.Log("Barbarian used Skill");
        skillInfoTxt = "Barbarian used a Skill Attack";
        GameManager.instance.skillTxt.text = skillInfoTxt;
        //base.Skill();

    }

}
