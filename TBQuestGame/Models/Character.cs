﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame
{
    public class Character
    {
        #region ENUMERABLES

        public enum RaceType
        {
            None,
            Human,
            Elf,
            Dracon
        }

        #endregion

        #region FIELDS

        protected string _name;
        protected int _spaceTimeLocationId;
        protected int _age;
        protected RaceType _race;

        #endregion

        #region PROPERTIES

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int SpaceTimeLocationId
        {
            get { return _spaceTimeLocationId; }
            set { _spaceTimeLocationId = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public RaceType Race
        {
            get { return _race; }
            set { _race = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public Character()
        {

        }

        public Character(string name, RaceType race, int spaceTimeLocationID)
        {
            _name = name;
            _race = race;
            _spaceTimeLocationId = spaceTimeLocationID;
        }

        #endregion

        #region METHODS



        #endregion
    }
}
