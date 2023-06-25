using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using RPGGame.Enums;

namespace RPGGame.Items
{
    public abstract class Item
    {
        public string Name              {get; set;}
        public string Description       {get; set;}

        public ItemType ItemType        {get; set;}
        public RarityType ItemRarity    {get; set;}
        public int Value                {get; set;}
        public int Weight               {get; set;}


        public Item(
            string aName, string aDescription, ItemType aType, 
            RarityType aRarity, int aValue, int aWeight)
        {
            Name            = aName;
            Description     = aDescription;
            ItemType        = aType;
            ItemRarity      = aRarity;
            Value           = aValue;
            Weight          = aWeight;
        }
    }
}