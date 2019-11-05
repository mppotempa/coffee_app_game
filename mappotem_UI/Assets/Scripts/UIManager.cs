using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    public GameObject deliveryPanel;
    public Animator menuPanel;
    public Animator drinkOptionsPanel;

    public void Start()
    {
        menuPanel.SetBool("isShown", true);
        drinkOptionsPanel.SetBool("isShown", false);
    }

    public void ToggleDeliveryMenu(){
        deliveryPanel.SetActive(!deliveryPanel.activeSelf);
    }

    public void showOptions()
    {
        menuPanel.SetBool("isShown", false);
        drinkOptionsPanel.SetBool("isShown", true);
    }
}
