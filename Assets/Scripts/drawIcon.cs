using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class drawIcon : MonoBehaviour
{

    public Sprite spellSlot;
    public Sprite spellSlotAction;
    

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.name == "SpellSlot")
        {
            if (Input.GetMouseButton(0))
            {
                gameObject.GetComponent<Image>().sprite = spellSlotAction;
            }
            else
            {
                gameObject.GetComponent<Image>().sprite = spellSlot;
            }
        }
        else if(gameObject.name == "SpellSlot2")
        {
            if (Input.GetMouseButton(1))
            {
                gameObject.GetComponent<Image>().sprite = spellSlotAction;
            }
            else
            {
                gameObject.GetComponent<Image>().sprite = spellSlot;
            }
        }
        
    }

    private void OnGUI()
    {
        
    }
}
