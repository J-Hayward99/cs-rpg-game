using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using RPGGame.Enums;

namespace RPGGame.ItemClasses
{
    public abstract class ItemBase
    {
        public string       Name            {get; set;} = "__ITEM__";
        public string       Description     {get; set;} = "__DESC__";

        public ItemType     ItemType        {get; set;}
        public RarityType   ItemRarity      {get; set;}
        public int          Value           {get; set;}
        public int          Weight          {get; set;}

    }
}