using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    [Header("Starting Stat Variables")]
    #region Starting Stats Variables
    public static int strengthStat;
    public static int dexterityStat;
    public static int intelligenceStat;
    public static int maxMana;
    public static int maxHealth;
    #endregion
    [Header("Script References")]
    #region Script References
    public ChoosingAClass ChooseClass;
    #endregion
    //////Player Base Stats that change based on which class is choose//////
    //Every stat has a base of 1,
    //Starting Mana ranges 100 to 200
    //Health ranges 100 to 200
    public void chooseAssassin()
    {
        strengthStat = 1;
        dexterityStat = 1;
        intelligenceStat = 1;
        maxMana = 100;
        maxHealth = 100;
    }
    public void chooseBard()
    {
        strengthStat = 1;
        dexterityStat = 1;
        intelligenceStat = 1;
        maxMana = 160;
        maxHealth = 120;
    }
    public void chooseCleric()
    {
        strengthStat = 1;
        dexterityStat = 1;
        intelligenceStat = 1;
        maxMana = 180;
        maxHealth = 140;
    }
    public void chooseDruid()
    {
        strengthStat = 1;
        dexterityStat = 1;
        intelligenceStat = 1;
        maxMana = 160;
        maxHealth = 140;
    }
    public void chooseEnchanter()
    {
        strengthStat = 1;
        dexterityStat = 1;
        intelligenceStat = 1;
        maxMana = 100;
        maxHealth = 100;
    }
    public void chooseFighter()
    {
        strengthStat = 1;
        dexterityStat = 1;
        intelligenceStat = 1;
        maxMana = 100;
        maxHealth = 200;
    }
    public void chooseMonk()
    {
        strengthStat = 1;
        dexterityStat = 1;
        intelligenceStat = 1;
        maxMana = 140;
        maxHealth = 180;
    }
    public void choosePaladin()
    {
        strengthStat = 1;
        dexterityStat = 1;
        intelligenceStat = 1;
        maxMana = 100;
        maxHealth = 100;
    }
    public void chooseRouge()
    {
        strengthStat = 1;
        dexterityStat = 1;
        intelligenceStat = 1;
        maxMana = 100;
        maxHealth = 100;
    }
    public void chooseWizard()
    {
        strengthStat = 1;
        dexterityStat = 1;
        intelligenceStat = 1;
        maxMana = 200;
        maxHealth = 100;
    }
}