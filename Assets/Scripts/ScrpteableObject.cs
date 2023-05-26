using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Item/New Weapon")]
public class ScrpteableObject : ScriptableObject
{

    public string weaponName;

    public string weaponPrecio;

    public Sprite weaponSprite;
    
    public float weaponType;
}
