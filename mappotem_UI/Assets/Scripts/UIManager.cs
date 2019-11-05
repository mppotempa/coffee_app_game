using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public GameObject deliveryPanel;
    public Animator menuPanel;
    public Animator drinkOptionsPanel;
    public Animator ticketPanel;
    public Text shotText;

    private int shots = 0;

    public void ToggleDeliveryMenu(){
        deliveryPanel.SetActive(!deliveryPanel.activeSelf);
    }

    public void ShowOptions()
    {
        menuPanel.SetBool("isHidden", true);
        ticketPanel.SetBool("isHidden", true);
        drinkOptionsPanel.SetBool("isHidden", false);
        
    }

    public void ToMain()
    {
        drinkOptionsPanel.SetBool("isHidden", true);
        ticketPanel.SetBool("isHidden", false);
        menuPanel.SetBool("isHidden", false);
        
    }
    public void CancelDrink()
    {
        ToMain();
    }
    public void AddtoOrder()
    {
        ToMain();
    }
    public void AddShot()
    {
        shots++;
        shotText.text = shots.ToString();
    }
    public void SubShot()
    {
        shots--;
        shotText.text = shots.ToString();
    }
}
