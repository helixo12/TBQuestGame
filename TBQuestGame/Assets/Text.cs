using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame
{
    public static class Text
    {
        public static List<string> HeaderText = new List<string>() { "Ever/Quest" };
        public static List<string> FooterText = new List<string>() { "Double Helix Productions, 2018" };

        #region INTITIAL GAME SETUP

        public static string MissionIntro()
        {
            string messageBoxText =
            "The kingdom of Avalon has thrived for hundreds of years " +
            "until recently. The land has begun to die due to an overuse of magic. " +
            "You are a farmer who, after being forced into poverty due to the crops dying, " +
            "has decided to search for an alternative source of magic to save the land." +
            " \n" +
            "Press the Esc key to exit the game at any point.\n" +
            " \n" +
            "Your quest begins now.\n" +
            " \n" +
            "\tYour first task will be to set up your information for this quest.\n" +
            " \n" +
            "\tPress any key to begin the Quest Initialization Process.\n";

            return messageBoxText;
        }

        public static string InitialLocationInfo()
        {
            string messageBoxText =
            "You are now in the Castle Town of Norad, located near a mountain range " +
            "at the edge of the kingdom's border. Surrounding the town are large " +
            "Ballista's meant to ward off Dragon's. The town square has a statue " +
            "dedicated to a long dead hero who died defending the town." +
            " \n" +
            "\tChoose from the menu options to proceed.\n";

            return messageBoxText;
        }

        #region Initialize Mission Text

        public static string InitializeMissionIntro()
        {
            string messageBoxText =
                "Before you begin your Quest we much gather your information.\n" +
                " \n" +
                "You will be prompted for the required information. Please enter the information below.\n" +
                " \n" +
                "\tPress any key to begin.";

            return messageBoxText;
        }

        public static string InitializeMissionGetTravelerName()
        {
            string messageBoxText =
                "Enter your name traveler.\n" +
                " \n" +
                "Please use the name you wish to be referred during your Quest.";

            return messageBoxText;
        }

        public static string InitializeMissionGetTravelerAge(string name)
        {
            string messageBoxText =
                $"Very good then, we will call you {name} on this Quest.\n" +
                " \n" +
                "Enter your age below.\n" +
                " \n" +
                "Please use the standard Earth year as your reference.";

            return messageBoxText;
        }

        public static string InitializeMissionGetTravelerRace(Traveler gameTraveler)
        {
            string messageBoxText =
                $"{gameTraveler.Name}, it will be important for us to know your race on this Quest.\n" +
                " \n" +
                "Enter your race below.\n" +
                " \n" +
                "Please use the race classifications below." +
                " \n";

            string raceList = null;

            foreach (Character.RaceType race in Enum.GetValues(typeof(Character.RaceType)))
            {
                if (race != Character.RaceType.None)
                {
                    raceList += $"\t{race}\n";
                }
            }

            messageBoxText += raceList;

            return messageBoxText;
        }

        public static string InitializeMissionEchoTravelerInfo(Traveler gameTraveler)
        {
            string messageBoxText =
                $"Very good then {gameTraveler.Name}.\n" +
                " \n" +
                "It appears we have all the necessary info to begin your Quest. You will find it" +
                " listed below.\n" +
                " \n" +
                $"\tTraveler Name: {gameTraveler.Name}\n" +
                $"\tTraveler Age: {gameTraveler.Age}\n" +
                $"\tTraveler Race: {gameTraveler.Race}\n" +
                " \n" +
                "Press any key to begin your Quest.";

            return messageBoxText;
        }

        #endregion

        #endregion

        #region MAIN MENU ACTION SCREENS

        public static string TravelerInfo(Traveler gameTraveler, SpaceTimeLocation currentLocation)
        {
            string messageBoxText =
                $"\tTraveler Name: {gameTraveler.Name}\n" +
                $"\tTraveler Age: {gameTraveler.Age}\n" +
                $"\tTraveler Race: {gameTraveler.Race}\n" +
                " \n" +
                $"\tCurrent Location: {currentLocation.CommonName}\n" +
                " \n";

            return messageBoxText;
        }

        public static string CurrentLocationInfo(SpaceTimeLocation spaceTimeLocation)
        {
            string messageBoxText =
                $"Current Location: {spaceTimeLocation.CommonName}\n" +
                " \n" +
                spaceTimeLocation.Description;

            return messageBoxText;
        }

        public static string LookAround(SpaceTimeLocation spaceTimeLocation)
        {
            string messageBoxText =
                $"Current Location: {spaceTimeLocation.CommonName}\n" +
                " \n" +
                spaceTimeLocation.Description;

            return messageBoxText;
        }

        /// <summary>
        /// list all locations other than the current location
        /// </summary>
        /// <param name="gametraveler">game traveler object</param>
        /// <param name="spaceTimeLocations">list of all space time locations</param>
        /// <returns></returns>
        public static string Travel(Traveler gametraveler, List<SpaceTimeLocation> spaceTimeLocations)
        {
            string messageBoxText =
                $"{gametraveler.Name}, We will need to know the name of the new location.\n" +
                " \n" +
                "Enter the ID number of your desired location from the table below.\n" +
                " \n" +

                //
                // display table header
                //
                "ID".PadRight(10) + "Name".PadRight(30) + "Accessible".PadRight(10) + "\n" +
                "---".PadRight(10) + "----------------------".PadRight(30) + "-------".PadRight(10) + "\n";

            //
            // display all locations except the current location
            //
            string spaceTimeLocationList = null;
            foreach (SpaceTimeLocation spaceTimeLocation in spaceTimeLocations)
            {
                if (spaceTimeLocation.SpaceTimeLocationID != gametraveler.SpaceTimeLocationId)
                {
                    spaceTimeLocationList +=
                        $"{spaceTimeLocation.SpaceTimeLocationID}".PadRight(10) +
                        $"{spaceTimeLocation.CommonName}".PadRight(30) +
                        $"{spaceTimeLocation.Accessible}".PadRight(10) +
                        Environment.NewLine;
                }
            }

            messageBoxText += spaceTimeLocationList;

            return messageBoxText;
        }

        public static string VisitedLocations(IEnumerable<SpaceTimeLocation> spaceTimeLocations)
        {
            string messageBoxText =
                "Locations Visited\n" +
                " \n" +

                //
                // display table header
                //
                "ID".PadRight(10) + "Name".PadRight(30) + "\n" +
                "---".PadRight(10) + "----------------------".PadRight(30) + "\n";

            //
            // display all locations
            //
            string spaceTimeLocationList = null;
            foreach (SpaceTimeLocation spaceTimeLocation in spaceTimeLocations)
            {
                spaceTimeLocationList +=
                    $"{spaceTimeLocation.SpaceTimeLocationID}".PadRight(10) +
                    $"{spaceTimeLocation.CommonName}".PadRight(30) +
                    Environment.NewLine;
            }

            messageBoxText += spaceTimeLocationList;

            return messageBoxText;
        }

        public static string ListAllSpaceTimeLocations(IEnumerable<SpaceTimeLocation> spaceTimeLocations)
        {
            string messageBoxText =
                "Locations\n" +
                " \n" +

                //
                // display table header
                //
                "ID".PadRight(10) + "Name".PadRight(30) + "\n" +
                "---".PadRight(10) + "----------------------".PadRight(30) + "\n";

            //
            // display all locations
            //
            string spaceTimeLocationList = null;
            foreach (SpaceTimeLocation spaceTimeLocation in spaceTimeLocations)
            {
                spaceTimeLocationList +=
                    $"{spaceTimeLocation.SpaceTimeLocationID}".PadRight(10) +
                    $"{spaceTimeLocation.CommonName}".PadRight(30) +
                    Environment.NewLine;
            }

            messageBoxText += spaceTimeLocationList;

            return messageBoxText;
        }

        public static string ListAllGameObjects(IEnumerable<GameObject> gameObjects)
        {
            //
            // display table name and column headers
            //
            string messageBoxText =
                "Game Objects\n" +
                " \n" +

                //
                // display table header
                //
                "ID".PadRight(10) +
                "Name".PadRight(30) +
                "Space-Time Location Id".PadRight(10) + "\n" +
                "---".PadRight(10) +
                "----------------------".PadRight(30) +
                "----------------------".PadRight(10) + "\n";

            //
            // display all traveler objects in rows
            //
            string gameObjectRows = null;
            foreach (GameObject gameObject in gameObjects)
            {
                gameObjectRows +=
                    $"{gameObject.Id}".PadRight(10) +
                    $"{gameObject.Name}".PadRight(30) +
                    $"{gameObject.SpaceTimeLocationId}".PadRight(10) +
                    Environment.NewLine;
            }

            messageBoxText += gameObjectRows;

            return messageBoxText;
        }

        public static string ListAllNpcObjects(IEnumerable<Npc> npcObjects)
        {
            //
            // display table name and column headers
            //
            string messageBoxText =
                "NPC Objects\n" +
                " \n" +

                //
                // display table header
                //
                "ID".PadRight(10) +
                "Name".PadRight(30) +
                "Space-Time Location Id".PadRight(10) + "\n" +
                "---".PadRight(10) +
                "----------------------".PadRight(30) +
                "----------------------".PadRight(10) + "\n";

            //
            // display all npc objects in rows
            //
            string npcObjectRows = null;
            foreach (Npc npcObject in npcObjects)
            {
                npcObjectRows +=
                    $"{npcObject.Id}".PadRight(10) +
                    $"{npcObject.Name}".PadRight(30) +
                    $"{npcObject.SpaceTimeLocationId}".PadRight(10) +
                    Environment.NewLine;
            }

            messageBoxText += npcObjectRows;

            return messageBoxText;
        }

        public static string GameObjectsChooseList(IEnumerable<GameObject> gameObjects)
        {
            //
            // display table name and column headers
            //
            string messageBoxText =
                "Game Objects\n" +
                " \n" +

                //
                // display table header
                //
                "ID".PadRight(10) +
                "Name".PadRight(30) + "\n" +
                "---".PadRight(10) +
                "----------------------".PadRight(30) + "\n";

            //
            // display all traveler objects in rows
            //
            string gameObjectRows = null;
            foreach (GameObject gameObject in gameObjects)
            {
                gameObjectRows +=
                    $"{gameObject.Id}".PadRight(10) +
                    $"{gameObject.Name}".PadRight(30) +
                    Environment.NewLine;
            }

            messageBoxText += gameObjectRows;

            return messageBoxText;
        }


        public static string ListSpaceTimeLocationObjectsBySpaceTimeLocation(int spaceTimeLocationId, IEnumerable<GameObject> gameObjects)
        {
            //
            // generate a list of traveler objects from the game object list with the current space-time location id
            //
            List<SpaceTimeLocationObject> spaceTimeLocationObjects = new List<SpaceTimeLocationObject>();
            foreach (var gameObject in gameObjects)
            {
                if (gameObject is TravelerObject &&
                    gameObject.SpaceTimeLocationId == spaceTimeLocationId)
                {
                    spaceTimeLocationObjects.Add(gameObject as SpaceTimeLocationObject);
                }
            }

            //
            // display table name and column headers
            //
            string messageBoxText =
                "Location Objects\n" +
                " \n" +

                //
                // display table header
                //
                "ID".PadRight(10) + "Name".PadRight(30) + "Type".PadRight(20) + "\n" +
                "---".PadRight(10) + "----------------------".PadRight(30) +
                "----------------------".PadRight(20) + "\n";

            //
            // display all traveler objects in rows
            //
            string spaceTimeLocationObjectRows = null;
            foreach (SpaceTimeLocationObject spaceTimeLocationObject in spaceTimeLocationObjects)
            {
                spaceTimeLocationObjectRows +=
                    $"{spaceTimeLocationObject.Id}".PadRight(10) +
                    $"{spaceTimeLocationObject.Name}".PadRight(30) +
                    Environment.NewLine;
            }

            messageBoxText += spaceTimeLocationObjectRows;

            return messageBoxText;
        }

        public static string LookAt(GameObject gameObject)
        {
            string messageBoxText = "";

            messageBoxText =
                $"{gameObject.Name}\n" +
                " \n" +
                gameObject.Description + " \n" +
                " \n";

            if (gameObject is TravelerObject)
            {
                TravelerObject travelerObject = gameObject as TravelerObject;

                messageBoxText += $"The {travelerObject.Name} has a value of {travelerObject.Value} and ";

                if (travelerObject.CanInventory)
                {
                    messageBoxText += "may be added to your inventory.";
                }
                else
                {
                    messageBoxText += "may not be added to your inventory.";
                }
            }
            else
            {
                messageBoxText += $"The {gameObject.Name} may not be added to your inventory.";
            }

            return messageBoxText;
        }

        public static string CurrentInventory(IEnumerable<TravelerObject> inventory)
        {
            string messageBoxText = "";

            //
            // display table header
            //
            messageBoxText =
            "ID".PadRight(10) +
            "Name".PadRight(30) +
            "Type".PadRight(10) +
            "\n" +
            "---".PadRight(10) +
            "----------------------------".PadRight(30) +
            "----------------------".PadRight(10) +
            "\n";

            //
            // display all traveler objects in rows
            //
            string inventoryObjectRows = null;
            foreach (TravelerObject inventoryObject in inventory)
            {
                inventoryObjectRows +=
                    $"{inventoryObject.Id}".PadRight(10) +
                    $"{inventoryObject.Name}".PadRight(30) +
                    $"{inventoryObject.Type}".PadRight(10) +
                    Environment.NewLine;
            }

            messageBoxText += inventoryObjectRows;

            return messageBoxText;
        }

        public static string NpcsChooseList(IEnumerable<Npc> npcs)
        {
            //
            // display table name and column headers
            //
            string messageBoxText =
                "NPCs\n" +
                " \n" +

                //
                // display table header
                //
                "ID".PadRight(10) +
                "Name".PadRight(30) + "\n" +
                "---".PadRight(10) +
                "----------------------".PadRight(30) + "\n";

            //
            // display all NPCs in rows
            //
            string npcRows = null;
            foreach (Npc npc in npcs)
            {
                npcRows +=
                    $"{npc.Id}".PadRight(10) +
                    $"{npc.Name}".PadRight(30) +
                    Environment.NewLine;
            }

            messageBoxText += npcRows;

            return messageBoxText;
        }

        #endregion

        public static List<string> StatusBox(Traveler traveler, Universe universe)
        {
            List<string> statusBoxText = new List<string>();

            statusBoxText.Add($"Experience Points: {traveler.ExperiencePoints}\n");
            statusBoxText.Add($"Health: {traveler.Health}\n");
            statusBoxText.Add($"Lives: {traveler.Lives}\n");

            return statusBoxText;
        }
    }
}
