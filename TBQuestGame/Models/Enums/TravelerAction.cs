using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame
{
    public enum TravelerAction
    {
        None,
        MissionSetup,
        LookAround,
        Travel,

        TravelerMenu,
        TravelerInfo,
        Inventory,
        TravelerLocationsVisited,

        ObjectMenu,
        LookAt,
        PickUp,
        PutDown,

        NonplayerCharacterMenu,
        TalkTo,

        AdminMenu,
        ListSpaceTimeLocations,
        ListGameObjects,
        ListNonplayerCharacters,

        ReturnToMainMenu,
        Exit
    }
}
