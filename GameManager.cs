using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header("Script References")]
    public PlayerAbstract playerAbstract;
    public Swordsman swordsman;
    public Barbarian barbarian;
    public Gladiator gladiator;
    public Archer archer;
    public Sniper sniper;
    public Artillery artillery;

    [Header("Lines Properties")]
    public Image swordToPlayer;
    public Image barbarianToLine;
    public Image gladiatorToLine;
    public Image lineToSword;
    public Image archerToPlayer;
    public Image sniperToLine;
    public Image artilleryToLine;
    public Image lineToArcher;

    [Header("Button Image Properties")]
    public Image playerImageBut;
    public Image swordsmanImageBut;
    public Image barbarianImageBut;
    public Image gladiatorImageBut;
    public Image archerImageBut;
    public Image sniperImageBut;
    public Image artilleryImageBut;

    [Header("Button Properties")]
    public Button playerButton;
    public Button swordsmanButton;
    public Button barbarianButton;
    public Button gladiatorButton;
    public Button archerButton;
    public Button sniperButton;
    public Button artilleryButton;

    [Header("Display Visuals")]
    public TextMeshProUGUI normalTxt;
    public TextMeshProUGUI skillTxt;
    public TextMeshProUGUI infoGuideTxt;


    public void Start()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }

        
        
    }

    public void PlayerClick()
    {
        playerImageBut.color = Color.cyan;
        playerButton.interactable = false;

        playerAbstract.Attack();
        playerAbstract.Skill();

        infoGuideTxt.text = "Player > ";

        playerAbstract.Attack();
        playerAbstract.Skill();
    }

    public void SwordsmanClick()
    {
        swordsmanImageBut.color = Color.cyan;
        swordToPlayer.color = Color.cyan;
        playerImageBut.color = Color.cyan;

        playerButton.interactable = false;
        swordsmanButton.interactable = false;
        archerButton.interactable = false;
        sniperButton.interactable = false;
        artilleryButton.interactable = false;

        infoGuideTxt.text = "Player > Swordsman >";
        swordsman.Attack();
        swordsman.Skill();

    }

    public void BarbarianClick()
    {
        barbarianImageBut.color = Color.cyan;
        barbarianToLine.color = Color.cyan;
        lineToSword.color = Color.cyan;
        swordsmanImageBut.color = Color.cyan;
        swordToPlayer.color = Color.cyan;
        playerImageBut.color = Color.cyan;

        playerButton.interactable = false;
        swordsmanButton.interactable = false;
        barbarianButton.interactable = false;
        gladiatorButton.interactable = false;
        archerButton.interactable = false;
        sniperButton.interactable = false;
        artilleryButton.interactable = false;

        infoGuideTxt.text = "Player > Swordsman > Barbarian";
        barbarian.Attack();
        barbarian.Skill();
    }

    public void GladiatorClick()
    {
        gladiatorImageBut.color = Color.cyan;
        gladiatorToLine.color = Color.cyan;
        lineToSword.color = Color.cyan;
        swordsmanImageBut.color = Color.cyan;
        swordToPlayer.color = Color.cyan;
        playerImageBut.color = Color.cyan;

        playerButton.interactable = false;
        swordsmanButton.interactable = false;
        barbarianButton.interactable = false;
        gladiatorButton.interactable = false;
        archerButton.interactable = false;
        sniperButton.interactable = false;
        artilleryButton.interactable = false;

        infoGuideTxt.text = "Player > Swordsman > Gladiator";
        gladiator.Attack();
        gladiator.Skill();
    }

    public void ArcherClick()
    {
        archerImageBut.color = Color.cyan;
        archerToPlayer.color = Color.cyan;
        playerImageBut.color = Color.cyan;

        swordsmanButton.interactable = false;
        barbarianButton.interactable = false;
        gladiatorButton.interactable = false;

        infoGuideTxt.text = "Player > Archer >";
        archer.Attack();
        archer.Skill();

    }

    public void SniperClick()
    {
        sniperImageBut.color = Color.cyan;
        sniperToLine.color = Color.cyan;
        lineToArcher.color = Color.cyan;
        playerImageBut.color = Color.cyan;
        archerToPlayer.color = Color.cyan;
        archerImageBut.color = Color.cyan;

        playerButton.interactable = false;
        swordsmanButton.interactable = false;
        barbarianButton.interactable = false;
        gladiatorButton.interactable = false;
        archerButton.interactable = false;
        sniperButton.interactable = false;
        artilleryButton.interactable = false;

        infoGuideTxt.text = "Player > Archer > Sniper";
        sniper.Attack();
        sniper.Skill();
    }

    public void ArtilleryClick()
    {
        artilleryImageBut.color = Color.cyan;
        artilleryToLine.color = Color.cyan;
        lineToArcher.color = Color.cyan;
        playerImageBut.color = Color.cyan;
        archerToPlayer.color = Color.cyan;
        archerImageBut.color = Color.cyan;


        playerButton.interactable = false;
        swordsmanButton.interactable = false;
        barbarianButton.interactable = false;
        gladiatorButton.interactable = false;
        archerButton.interactable = false;
        sniperButton.interactable = false;
        artilleryButton.interactable = false;

        infoGuideTxt.text = "Player > Archer > Artillery";
        artillery.Attack();
        artillery.Skill();
    }

}

