using System;
using System.Collections;
using System.Collections.Generic;
using Shop;
using UnityEngine;
using Utilities;

namespace Players
{
    public class PlayerSkins : MonoBehaviour
    {
        public Sprite[] skins;
        public SpriteRenderer player;

        private int Number;

        private void Start()
        {
            player = GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>();
            Number = PlayerPrefs.GetInt(Constant.SKIN, 0) + 1;
            if (ShopManager.SkinSelected == true)
            {
                player.sprite = skins[Number];
            }
            else
            {
                player.sprite = skins[0];
            }
        }
    }
}


