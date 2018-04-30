using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame
{
    public static partial class UniverseObjects
    {
        public static List<SpaceTimeLocation> SpaceTimeLocations = new List<SpaceTimeLocation>()
        {

            new SpaceTimeLocation
            {
                CommonName = "Norad Town",
                SpaceTimeLocationID = 1,
                UniversalDate = 386759,
                UniversalLocation = "P-3, SS-278, G-2976, LS-3976",
                Description = "A average sized town near the rocky mountains of the kingdom " +
                    "where dragons reside, resulting in frequent attacks. ",
                GeneralContents = "The town has several ballista's surrounding the walls, " +
                    "and a statue of a fallen hero resides in the town square. ",
                Accessible = true,
                ExperiencePoints = 10
            },

            new SpaceTimeLocation
            {
                CommonName = "Setar Mountain Range",
                SpaceTimeLocationID = 2,
                UniversalDate = 386759,
                UniversalLocation = "P-2, SS-85, G-2976, LS-3976",
                Description = "Located near Norad Town, the Setar Mountain Range is the home " +
                    "of several dragon species that are highly aggressive. ",
                GeneralContents = "- A dreary and lifeless mountain range. -",
                Accessible = true,
                ExperiencePoints = 10
            },

            new SpaceTimeLocation
            {
                CommonName = "Black Swamp",
                SpaceTimeLocationID = 3,
                UniversalDate = 386759,
                UniversalLocation = "P-6, SS-3978, G-2976, LS-3976",
                Description = "A dreary swamp that is nigh impossible to navigate with a carriage. " +
                              "The swamp is told to be home to a witch that uses her victims in dark rituals. ",
                GeneralContents = "- Various mucky lakes are spread throughout surrounded by thick trees -",
                Accessible = false,
                ExperiencePoints = 20
            },

                        new SpaceTimeLocation
            {
                CommonName = "Farmlands",
                SpaceTimeLocationID = 4,
                UniversalDate = 386759,
                UniversalLocation = "P-3, SS-278, G-2976, LS-3976",
                Description = "The Farmlands are various patches of land near the kingdoms left border " +
                              "that used to produce ripe crops before the crisis.",
                GeneralContents = "- A grassy field with various crops scattered throughout -",
                Accessible = true,
                ExperiencePoints = 10
            }
        };
    }
}
