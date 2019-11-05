using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    public GameObject deliveryPanel;

    public void ToggleDeliveryMenu(){
        deliveryPanel.SetActive(!deliveryPanel.activeSelf);
    }
}
