using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using cs_rpg_game.Enums;
using RPGGame.Enums;

namespace cs_rpg_game.PeopleClasses
{
    public abstract class PeopleBase
    {
        // Terms
        protected const int     EMPTY_SLOT          = 0;
        protected const int     BASE_INV_SIZE       = 2;
        protected const int     MINIMUM_INV_SIZE    = 1;
        protected const double  INV_STR_MOD         = 0.5;


        // General
        public string       Name            {get;set;}  = "_MISSING_";
        public int          ArmourRating    {get;set;}  = 0;
        
        // Stats 
        public int          Health          {get;set;}  = 10;
        public int          Speed           {get;set;}  = 10;
        public int          Strength        {get;set;}  = 10;
        public int          Magic           {get;set;}  = 0;
        public int          Luck            {get;set;}  = 10;
        public int          Agility         {get;set;}  = 10;

        // Derived Stats
        public int          InvSize         {get;set;}  = BASE_INV_SIZE;
        
        // Items
        public string[]     Backpack        {get;set;}
        public StorageType  AddStorage      {get;set;}  = StorageType.None;

        // Hands
        public int          HandLeft        {get;set;}  = EMPTY_SLOT;   
        public int          HandRight       {get;set;}  = EMPTY_SLOT;

        // Clothing
        public int          ArmourHead      {get;set;}  = EMPTY_SLOT;
        public int          ArmourChest     {get;set;}  = EMPTY_SLOT;
        public int          ArmourTrousers  {get;set;}  = EMPTY_SLOT;
        public int          ArmourGloves    {get;set;}  = EMPTY_SLOT;

        public int          RingOne         {get;set;}  = EMPTY_SLOT;
        public int          RingTwo         {get;set;}  = EMPTY_SLOT;
        public int          RingThree       {get;set;}  = EMPTY_SLOT;
        public int          RingFour        {get;set;}  = EMPTY_SLOT;

        // Ammunition
        public int[]       curArrows       = {EMPTY_SLOT, 0};                       //  // [Arrow type, Amount]
         
  

        // Constructor
        protected PeopleBase(string aName = "MISSING_NAME")
        {
            // Personal Stuff
            Name    = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(
                aName.ToLower()
            );
            
            // Backpack generation
            double invSizeMod   = Math.Floor(INV_STR_MOD * Strength);
            InvSize             = BASE_INV_SIZE + (int)invSizeMod;
            Backpack            = new string[InvSize];
        }
        
        // Generation
        protected void GenerateBackpack()
        {
            // Equation
            double invSizeMod   = Math.Floor(INV_STR_MOD * Strength);
            InvSize             = BASE_INV_SIZE + (int)invSizeMod;
            
            // Guard Clause: Below Minimum Size
            if (InvSize < MINIMUM_INV_SIZE)
            {
                InvSize = MINIMUM_INV_SIZE;
            }

            // Additional Storage Check
            InvSize += AddStorage switch
            {
                StorageType.None            => 0,
                StorageType.Pouch           => 2,
                StorageType.Sack            => 4,
                StorageType.BigSack         => 8,
                StorageType.PocketDimension => 1024,
                _ => 0,
            };

            // Set Backpack
            Backpack            = new string[InvSize];
        }

        protected void GenerateDerivedStuff()
        {
            GenerateBackpack();
        }

    }
}