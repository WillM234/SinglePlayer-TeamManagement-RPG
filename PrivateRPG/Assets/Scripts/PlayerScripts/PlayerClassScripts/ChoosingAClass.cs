using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ChoosingAClass : MonoBehaviour
{
    [Header("UI Variables")]
    #region UI Variables
    public GameObject ConfirmPanel;
    public bool ConfirmOn;
    [Header("Class Selection Buttons")]
    public Button NextButton;
    public Button AssassinButton;
    public Button BardButton;
    public Button ClericButton;
    public Button DruidButton;
    public Button EnchanterButton;
    public Button FighterButton;
    public Button MonkButton;
    public Button PaladinButton;
    public Button RougeButton;
    public Button WizardButton;
    #endregion
    #region Player Class Enums
    public enum pClassType {Guardian, Combat_Support, Magic_Attacker, Physical_Attacker  }
    public enum playerClass { Assassin, Bard, Cleric, Druid, Enchanter, Fighter, Monk, Paladin, Rouge, Wizard }
    [Header("Player Class")]
    public playerClass chosenClass;
    public pClassType classType;
    #endregion
    private void Update()
    {
        ///Displaying Class Stats based on chosen Class
        ///Turning on confirmation screen///
        if (ConfirmOn)
        {
            ConfirmPanel.SetActive(true);
            AssassinButton.enabled = false;
            BardButton.enabled = false;
            ClericButton.enabled = false;
            FighterButton.enabled = false;
            MonkButton.enabled = false;
            WizardButton.enabled = false;
        }
        if (!ConfirmOn)
        {
            ConfirmPanel.SetActive(false);
            AssassinButton.enabled = true;
            BardButton.enabled = true;
            ClericButton.enabled = true;
            FighterButton.enabled = true;
            MonkButton.enabled = true;
            WizardButton.enabled = true;
        }
    }
    //////Switching the choosen class when a button is pressed///////
    public void chooseAssassinClass()
    {
        chosenClass = playerClass.Assassin;
        classType = pClassType.Physical_Attacker;
        //Setting Buttons Interactable or not Interactable
        AssassinButton.interactable = false;
        BardButton.interactable = true;
        ClericButton.interactable = true;
        FighterButton.interactable = true;
        MonkButton.interactable = true;
        WizardButton.interactable = true;
    }
    public void chooseBardClass()
    {
        chosenClass = playerClass.Bard;
        classType = pClassType.Combat_Support;
        //Setting Buttons Interactable or not Interactable
        BardButton.interactable = false;
        AssassinButton.interactable = true;
        ClericButton.interactable = true;
        FighterButton.interactable = true;
        MonkButton.interactable = true;
        WizardButton.interactable = true;
    }
    public void chooseClericClass()
    {
        chosenClass = playerClass.Cleric;
        classType = pClassType.Combat_Support;
        //Setting Buttons Interactable or not Interactable
        ClericButton.interactable = false;
        AssassinButton.interactable = true;
        BardButton.interactable = true;
        FighterButton.interactable = true;
        MonkButton.interactable = true;
        WizardButton.interactable = true;
    }
    public void chooseDruidClass()
    {
        chosenClass = playerClass.Druid;
        classType = pClassType.Combat_Support;
        //Setting Buttons Interactable or not Interactable

    }
    public void chooseEnchanterClass()
    {
        chosenClass = playerClass.Enchanter;
        classType = pClassType.Magic_Attacker;
        //Setting Buttons Interactable or not Interactable

    }
    public void chooseFighterClass()
    {
        chosenClass = playerClass.Fighter;
        classType = pClassType.Guardian;
        //Setting Buttons Interactable or not Interactable
        FighterButton.interactable = false;
        AssassinButton.interactable = true;
        BardButton.interactable = true;
        ClericButton.interactable = true;
        MonkButton.interactable = true;
        WizardButton.interactable = true;
    }
    public void chooseMonkClass()
    {
        chosenClass = playerClass.Monk;
        classType = pClassType.Guardian;
        //Setting Buttons Interactable or not Interactable
        MonkButton.interactable = false;
        AssassinButton.interactable = true;
        BardButton.interactable = true;
        ClericButton.interactable = true;
        FighterButton.interactable = true;
        WizardButton.interactable = true;
    }
    public void choosePaladinClass()
    {
        chosenClass = playerClass.Paladin;
        classType = pClassType.Guardian;
        //Setting Buttons Interactable or not Interactable

    }
    public void chooseRougeClass()
    {
        chosenClass = playerClass.Rouge;
        classType = pClassType.Physical_Attacker;
        //Setting Buttons Interactable or not Interactable

    }
    public void chooseWizardClass()
    {
        chosenClass = playerClass.Wizard;
        classType = pClassType.Magic_Attacker;
        //Setting Buttons Interactable or not Interactable
        WizardButton.interactable = false;
        AssassinButton.interactable = true;
        BardButton.interactable = true;
        ClericButton.interactable = true;
        FighterButton.interactable = true;
        MonkButton.interactable = true;
    }
    //////Turning the confirmation screen  ON or OFF//////
    public void turnOnConfirmation()
    {
        ConfirmOn = true;
    }
    public void TurnOffConfirmation() 
    {
        ConfirmOn = false;
    }
}
