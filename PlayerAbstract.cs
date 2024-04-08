using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerAbstract : MonoBehaviour
{
    //public string playerName = "sung jin woo";
    public string normalInfoTxt;
    public string skillInfoTxt;

    private void Start()
    {
        //Debug.Log(playerName);
        Attack();
        Skill();
        
    }
    public virtual void Attack()
    {
        Debug.Log("Player Normal Attacks");
        normalInfoTxt = "Player used a Normal Attack";
        GameManager.instance.normalTxt.text = normalInfoTxt;

    }
    public virtual void Skill()
    {
        Debug.Log("PlayerSkill Attacks");
        skillInfoTxt = "Player used a Skill Attack";
        GameManager.instance.skillTxt.text = skillInfoTxt;
    }
}
