using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame
{
    public static partial class UniverseObjects
    {
        public static List<Npc> Npcs = new List<Npc>()
        {
            new Civilian
            {
                Id = 1,
                Name = "Old Farmer",
                SpaceTimeLocationId = 4,
                Description = "An old man dressed in typical farming clothes.",
                Messages = new List<string>
                {
                    "Greetings stranger. You are not from these parts as I can see.",
                    "The plague has started to reach into the farmlands, so the crops have." +
                    "begun to wither and die."
                }
            },

            new Civilian
            {
                Id = 2,
                Name = "Sir Ivard",
                SpaceTimeLocationId = 1,
                Description = "A knight in charge of managing the town's ballista's.",
                Messages = new List<string>
                {
                    "I have to go. Good bye!",
                    "You shouldn't go out at night, or else a dragon may attack.",
                    "You don't look like your from around here."
                }
            },

            new Civilian
            {
                Id = 3,
                Name = "Commoner",
                SpaceTimeLocationId = 2,
                Description = "A citizen of the town."
            }
        };
    }
}
