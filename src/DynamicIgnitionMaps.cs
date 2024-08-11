//  Authors:    Robert M. Scheller

using Landis.Utilities;

namespace Landis.Extension.SocialClimateFire
{

    public interface IDynamicIgnitionMap
    {
        int Year {get;set;}
        string MapName{get;set;}
    }
}

namespace Landis.Extension.SocialClimateFire
{
    public class DynamicIgnitionMap
    : IDynamicIgnitionMap
    {
        private string mapName;
        private int year;
        
        //---------------------------------------------------------------------
        public string MapName
        {
            get {
                return mapName;
            }

            set {
                mapName = value;
            }
        }

        //---------------------------------------------------------------------
        public int Year
        {
            get {
                return year;
            }
            set
            {
                if (value < 0)
                    throw new InputValueException(value.ToString(),
                        "Value must be > 0 ");
                year = value;
            }

        }
        //---------------------------------------------------------------------

        public DynamicIgnitionMap()
        {
        }
        //---------------------------------------------------------------------
/*
        public DynamicFireRegion(
            string mapName,
            int year
            )
        {
            this.mapName = mapName;
            this.year = year;
        }

        //---------------------------------------------------------------------

        public DynamicFireRegion()
        {
            this.mapName = "";
            this.year = 0;
        }*/


    }
}
