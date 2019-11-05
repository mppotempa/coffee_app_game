using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    public GameObject deliveryPanel;
    public Animator menuPanel;
    public Animator drinkOptionsPanel;

    public void ToggleDeliveryMenu(){
        deliveryPanel.SetActive(!deliveryPanel.activeSelf);
    }

    public void ShowOptions()
    {
        menuPanel.SetBool("isHidden", true);
        drinkOptionsPanel.SetBool("isHidden", false);
        
    }

    public void ToMain()
    {
        drinkOptionsPanel.SetBool("isHidden", true);
        menuPanel.SetBool("isHidden", false);
    }
}
