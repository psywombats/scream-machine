﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Game/Item")]
public class ItemData : ScriptableObject {

    public string Name;
    public Sprite IconBig;
    public Sprite IconSmall;

    public static ItemData ItemByName(string name) {
        return Resources.Load<ItemData>("Database/Items/" + name);
    }
}
