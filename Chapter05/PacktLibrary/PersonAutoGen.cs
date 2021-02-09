using System;

namespace Packt.Shared
{
    public partial class Person
    {

        /*--------------------------------*/
        //Access control
        //Getters
        public string Origin
        {
            get
            {
                return ($"{szFirstName} was born on the planet: {szHomePlanet}");
            }
        }
        //Lambda expression
        public string greeting (string name) => ($"Hello {name}, said {szFirstName}.");
        public int szAge => (DateTime.Today.Year - dtDateofBirth.Year);


        //Setters
        public string szFavouriteIcecream 
        { 
            get; 
            set; 
        }

        //Complex setters: 

        private string szFavouritePrimaryColour;

        public string FavouritePrimaryColour
        {
            get
            {
                return (szFavouritePrimaryColour);
            }
            set
            {
                switch (value.ToLower())
                {
                    case "red":
                    case "blue":
                    case "green":
                        szFavouritePrimaryColour = value.ToLower();
                        break;
                    default:
                        throw new System.ArgumentException
                        (
                            $"{value} is not a primary colour, we're looking at additive primaries here!"
                        );

                }
            }
        
        }

        /*--------------------------------*/
        
        


        /*--------------------------------*/





        /*--------------------------------*/





        /*--------------------------------*/





        /*--------------------------------*/

















    }
}