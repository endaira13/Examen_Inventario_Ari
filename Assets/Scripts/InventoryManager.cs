using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    
    public static InventoryManager Instance;

    public ScrpteableObject[] weapons;
    public ScrpteableObject[] inventario;
    public Text[] weaponsNames;
    public Text[] weaponsPrecio;
    public Image[] weaponsSprites;
    public Text[] InventoryNames;
    public Text[] InventoryPrecio;
    public Image[] InventorySprites;


    void Awake() 
    {
        Instance = this;
    }

    public void AddWeapon(ScrpteableObject weapon)
    {
        for( int i = 0; i < weapons.Length; i++)
        {

            if(weapon.weaponType == 0)
            {
                if(weapons[i] == null)
                {
                    weapons[i] = weapon;
                    weaponsNames[i].text = weapon.weaponName;
                    weaponsPrecio[i].text = weapon.weaponPrecio;
                    weaponsSprites[i].sprite = weapon.weaponSprite;

                    return;                
                }
            }
            if(weapon.weaponType == 1)
            {
                if(inventario[i] == null)
                {
                    inventario[i] = weapon;
                    InventoryNames[i].text = weapon.weaponName;
                    InventoryPrecio[i].text = weapon.weaponPrecio;
                    InventorySprites[i].sprite = weapon.weaponSprite;

                    return;                
                }
            }   

            

        }
    }

}
