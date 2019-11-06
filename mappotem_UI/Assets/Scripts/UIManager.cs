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
    public Slider sizeSlider;
    public Toggle icedToggle;
    public Toggle decafToggle;


    private int shots = 0;
    private double total = 0.00;
    private string drinkName = "";
    private string order = "";

    public void Start()
    {
        deliveryPanel.SetActive(true);
        ClearTicket();
        ClearFields();
    }

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
        ClearFields();
    }
    public void AddtoOrder()
    {
        string drink = drinkName;
        string size;
        string iced;
        string decaf;
        double price = 0;
        
        //size
        if(sizeSlider.value > 0.66)
        {
            drink += "\n\tlarge";
            price = 4.99;
        }
        else if(sizeSlider.value > 0.33)
        {
            drink += "\n\tmedium";
            price = 3.45;
        }
        else
        {
            drink += "\n\tsmall";
            price = 1.50;
        }

        //ice
        if(icedToggle.isOn)
        {
            drink += "\n\ticed";
        }

        //caffeine
        if (decafToggle.isOn)
        {
            drink += "\n\tdecaf";
        }

        //shots
        if(shots > 0)
        {
            drink += "\n\t" + shotText.text + " extra shot";
            if(shots > 1)
            {
                drink += "s";
            }
        }

        //adding to the menu
        AddItem(drink);

        total += price;
        print(total.ToString());
        print(price.ToString());
        totalText.text = "Total: $" + total.ToString();

        ToMain();
        ClearFields();
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
        print("add item");
        double price;
        order += "\n" + item;
        orderText.text = order;
        if (item.Equals("muffin"))
        {
            price = 5.50;
        }
        else if(item.Equals("cake pop"))
        {
            price = 2.05;
        }
        else if(item.Equals("cookie"))
        {
            price = 4.00;
        }
        else
        {
            price = 0;
        }
        total += price;
        totalText.text = "Total: $" + total.ToString();
    }

    public void ClearFields()
    {
        sizeSlider.value = 0;
        icedToggle.isOn = false;
        decafToggle.isOn = false;
        shots = 0;
        shotText.text = "0";
    }

    public void ClearTicket()
    {
        totalText.text = "Total: $0.00";
        orderText.text = "";
        total = 0.00;
        order = "";
    }

    public void CancelOrder()
    {
        ToggleDeliveryMenu();
        ClearTicket();
        ClearFields();
    }

}
