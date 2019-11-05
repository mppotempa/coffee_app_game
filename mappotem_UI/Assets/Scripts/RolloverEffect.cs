using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RolloverEffect : MonoBehaviour
{

    Image img;
    Sprite originalSprite;
    public Sprite rollOverSprite;

    // Start is called before the first frame update
    void Start()
    {
       img = GetComponent<Image>();
       originalSprite = img.sprite;
    }

    public void Enter()
    {
        img.sprite = rollOverSprite;
    }

    public void Exit(){
        img.sprite = originalSprite;
    }
}
