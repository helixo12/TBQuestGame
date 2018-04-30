using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame
{
    public static partial class UniverseObjects
    {
        public static List<GameObject> gameObjects = new List<GameObject>()
        {
            new TravelerObject
            {
                Id = 1,
                Name = "Bag of Gold",
                SpaceTimeLocationId = 1,
                Description = "A small leather pouch filled with 9 gold coins.",
                Type = TravelerObjectType.Treasure,
                Value = 45,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 2,
                Name = "Ring of Asphar",
                SpaceTimeLocationId = 3,
                Description = "A platinum ring adorned with sapphire's.",
                Type = TravelerObjectType.Treasure,
                Value = 45,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 3,
                Name = "Potion",
                SpaceTimeLocationId = 4,
                Description = "A vial of glowing liquid with healing properties.",
                Type = TravelerObjectType.Medicine,
                Value = 45,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 4,
                Name = "Stone Mallet",
                SpaceTimeLocationId = 3,
                Description = "A giant mallet used for combat with large foes.",
                Type = TravelerObjectType.Information,
                Value = 0,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 8,
                Name = "Map",
                SpaceTimeLocationId = 0,
                Description =
                    "A map of the kingdom and the surrounding area's.",
                Type = TravelerObjectType.Information,
                Value = 0,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 9,
                Name = "Meat Chunk",
                SpaceTimeLocationId = 0,
                Description =
                    "A chunk of cooked meat that will restore some health.",
                Type = TravelerObjectType.Food,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },

            new SpaceTimeLocationObject
            {
                Id = 5,
                Name = "Mystery Chest",
                SpaceTimeLocationId = 2,
                Description = "A large wooden chest adorned with jewels.",
                IsDeadly = true
            },

            new SpaceTimeLocationObject
            {
                Id = 6,
                Name = "Sharp Scale",
                SpaceTimeLocationId = 2,
                Description = "A reflective scale taken off of an elder dragon." +
                "It's sharp enough to cut through flesh like butter",
                IsDeadly = true

            }
        };
    }
}
