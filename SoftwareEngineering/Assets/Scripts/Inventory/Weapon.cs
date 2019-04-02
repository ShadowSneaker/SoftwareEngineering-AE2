using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Inventory/Item")]
public class Weapon : ItemScript
{
    public GameObject WeaponMesh;
    public float Damage;
    public float AttackSpeed;
    public float Range;


    public override void Use(EntityScript Entity)
    {
        Entity.Equip(this);
    }
}
