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
    public Text totalText;
    public Text orderText;
    public Text optionsTitle;

    private int shots = 0;
    private int total = 0;
    private string drinkName = "";
    private string order = "";

    public void ToggleDeliveryMenu(){
        deliveryPanel.SetActive(!deliveryPanel.activeSelf);
    }

    public void ShowOptions(string name)
    {
        menuPanel.SetBool("isHidden", true);
        ticketPanel.SetBool("isHidden", true);

        drinkName = name;
        optionsTitle.text = "How would you like your " + name + "?";

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
        if(shots > 0)
        {
            shots--;
        }
        shotText.text = shots.ToString();
    }

    public void AddItem(string item)
    {
        order += "\n" + item;
        orderText.text = order;
    }
}
