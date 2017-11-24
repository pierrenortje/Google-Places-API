using Google.Places.API.Models;
using RestSharp;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Google.Places.API.Requests
{
    public class RequestBase
    {
        #region Protected Fields
        protected readonly IRestClient restClient;
        protected readonly string apiKey;
        #endregion

        #region Constructor
        public RequestBase(IRestClient restClient, string apiKey)
        {
            this.restClient = restClient;
            this.apiKey = apiKey;
        }
        #endregion

        #region Public Properties
        public HttpStatusCode StatusCode { get; set; }
        public string StatusDescription { get; set; }
        #endregion

        #region Protected Methods
        protected async Task<TResponseType> Execute<TResponseType>(IRestRequest request)
        {
            request.AddParameter("key", this.apiKey);

            var response = await restClient.ExecuteTaskAsync<TResponseType>(request);

            StatusDescription = response.StatusDescription;
            StatusCode = response.StatusCode;

            return response.Data;
        }
        #endregion

        #region Protected Methods
        protected string GetPlaceType(PlaceType placeType)
        {
            switch (placeType)
            {
                case PlaceType.Accounting:
                    return "accounting";
                case PlaceType.Airport:
                    return "airport";
                case PlaceType.AmusementPark:
                    return "amusement_park";
                case PlaceType.Aquarium:
                    return "aquarium";
                case PlaceType.ArtGallery:
                    return "art_gallery";
                case PlaceType.Atm:
                    return "atm";
                case PlaceType.Bakery:
                    return "bakery";
                case PlaceType.Bank:
                    return "bank";
                case PlaceType.Bar:
                    return "bar";
                case PlaceType.BeautySalon:
                    return "beauty_salon";
                case PlaceType.BicycleStore:
                    return "bicycle_store";
                case PlaceType.BookStore:
                    return "book_store";
                case PlaceType.BowlingAlley:
                    return "bowling_alley";
                case PlaceType.BusStation:
                    return "bus_station";
                case PlaceType.Cafe:
                    return "cafe";
                case PlaceType.Campground:
                    return "campground";
                case PlaceType.CarDealer:
                    return "car_dealer";
                case PlaceType.CarRental:
                    return "car_rental";
                case PlaceType.CarRepair:
                    return "car_repair";
                case PlaceType.CarWash:
                    return "car_wash";
                case PlaceType.Casino:
                    return "casino";
                case PlaceType.Cemetery:
                    return "cemetery";
                case PlaceType.Church:
                    return "church";
                case PlaceType.CityHall:
                    return "city_hall";
                case PlaceType.ClothingStore:
                    return "clothing_store";
                case PlaceType.ConvenienceStore:
                    return "convenience_store";
                case PlaceType.Courthouse:
                    return "courthouse";
                case PlaceType.Dentist:
                    return "dentist";
                case PlaceType.DepartmentStore:
                    return "department_store";
                case PlaceType.Doctor:
                    return "doctor";
                case PlaceType.Electrician:
                    return "electrician";
                case PlaceType.ElectronicsStore:
                    return "electronics_store";
                case PlaceType.Embassy:
                    return "embassy";
                case PlaceType.FireStation:
                    return "fire_station";
                case PlaceType.Florist:
                    return "florist";
                case PlaceType.FuneralHome:
                    return "funeral_home";
                case PlaceType.FurnitureStore:
                    return "furniture_store";
                case PlaceType.GasStation:
                    return "gas_station";
                case PlaceType.Gym:
                    return "gym";
                case PlaceType.HairCare:
                    return "hair_care";
                case PlaceType.HardwareStore:
                    return "hardware_store";
                case PlaceType.HinduTemple:
                    return "hindu_temple";
                case PlaceType.HomeGoodsStore:
                    return "home_goods_store";
                case PlaceType.Hospital:
                    return "hospital";
                case PlaceType.InsuranceAgency:
                    return "insurance_agency";
                case PlaceType.JewelryStore:
                    return "jewelry_store";
                case PlaceType.Laundry:
                    return "laundry";
                case PlaceType.Lawyer:
                    return "lawyer";
                case PlaceType.Library:
                    return "library";
                case PlaceType.LiquorStore:
                    return "liquor_store";
                case PlaceType.LocalGovernmentOffice:
                    return "local_government_office";
                case PlaceType.Locksmith:
                    return "locksmith";
                case PlaceType.Lodging:
                    return "lodging";
                case PlaceType.MealDelivery:
                    return "meal_delivery";
                case PlaceType.MealTakeaway:
                    return "meal_takeaway";
                case PlaceType.Mosque:
                    return "mosque";
                case PlaceType.MovieRental:
                    return "movie_rental";
                case PlaceType.MovieTheater:
                    return "movie_theater";
                case PlaceType.MovingCompany:
                    return "moving_company";
                case PlaceType.Museum:
                    return "museum";
                case PlaceType.NightClub:
                    return "night_club";
                case PlaceType.Painter:
                    return "painter";
                case PlaceType.Park:
                    return "park";
                case PlaceType.Parking:
                    return "parking";
                case PlaceType.PetStore:
                    return "pet_store";
                case PlaceType.Pharmacy:
                    return "pharmacy";
                case PlaceType.Physiotherapist:
                    return "physiotherapist";
                case PlaceType.Plumber:
                    return "plumber";
                case PlaceType.Police:
                    return "police";
                case PlaceType.PostOffice:
                    return "post_office";
                case PlaceType.RealEstateAgency:
                    return "real_estate_agency";
                case PlaceType.Restaurant:
                    return "restaurant";
                case PlaceType.RoofingContractor:
                    return "roofing_contractor";
                case PlaceType.RvPark:
                    return "rv_park";
                case PlaceType.School:
                    return "school";
                case PlaceType.ShoeStore:
                    return "shoe_store";
                case PlaceType.ShoppingMall:
                    return "shopping_mall";
                case PlaceType.Spa:
                    return "spa";
                case PlaceType.Stadium:
                    return "stadium";
                case PlaceType.Storage:
                    return "storage";
                case PlaceType.Store:
                    return "store";
                case PlaceType.SubwayStation:
                    return "subway_station";
                case PlaceType.Synagogue:
                    return "synagogue";
                case PlaceType.TaxiStand:
                    return "taxi_stand";
                case PlaceType.TrainStation:
                    return "train_station";
                case PlaceType.TransitStation:
                    return "transit_station";
                case PlaceType.TravelAgency:
                    return "travel_agency";
                case PlaceType.University:
                    return "university";
                case PlaceType.VeterinaryCare:
                    return "veterinary_care";
                case PlaceType.Zoo:
                    return "zoo";
                default:
                    throw new Exception("Unsupported exception");
            }
        }

        protected string GetLanguageCode(Language language)
        {
            switch (language)
            {
                case Language.Arabic:
                    return "ar";
                case Language.Bulgarian:
                    return "bg";
                case Language.Bengali:
                    return "bn";
                case Language.Catalan:
                    return "ca";
                case Language.Czech:
                    return "cs";
                case Language.Danish:
                    return "da";
                case Language.German:
                    return "de";
                case Language.Greek:
                    return "el";
                case Language.English:
                    return "en";
                case Language.English_Australian:
                    return "en-AU";
                case Language.English_Great_Britain:
                    return "en-GB";
                case Language.Spanish:
                    return "es";
                case Language.Basque:
                    return "eu";
                case Language.Farsi:
                    return "fa";
                case Language.Finnish:
                    return "fi";
                case Language.Filipino:
                    return "fil";
                case Language.French:
                    return "fr";
                case Language.Galician:
                    return "gl";
                case Language.Gujarati:
                    return "gu";
                case Language.Hindi:
                    return "hi";
                case Language.Croatian:
                    return "hr";
                case Language.Hungarian:
                    return "hu";
                case Language.Indonesian:
                    return "id";
                case Language.Italian:
                    return "it";
                case Language.Hebrew:
                    return "iw";
                case Language.Japanese:
                    return "ja";
                case Language.Kannada:
                    return "kn";
                case Language.Korean:
                    return "ko";
                case Language.Lithuanian:
                    return "lt";
                case Language.Latvian:
                    return "lv";
                case Language.Malayalam:
                    return "ml";
                case Language.Marathi:
                    return "mr";
                case Language.Dutch:
                    return "nl";
                case Language.Norwegian:
                    return "no";
                case Language.Polish:
                    return "pl";
                case Language.Portuguese:
                    return "pt";
                case Language.Portuguese_Brazil:
                    return "pt-BR";
                case Language.Portuguese_Portugal:
                    return "pt-PT";
                case Language.Romanian:
                    return "ro";
                case Language.Russian:
                    return "ru";
                case Language.Slovak:
                    return "sk";
                case Language.Slovenian:
                    return "sl";
                case Language.Serbian:
                    return "sr";
                case Language.Swedish:
                    return "sv";
                case Language.Tamil:
                    return "ta";
                case Language.Telugu:
                    return "te";
                case Language.Thai:
                    return "th";
                case Language.Tagalog:
                    return "tl";
                case Language.Turkish:
                    return "tr";
                case Language.Ukrainian:
                    return "uk";
                case Language.Vietnamese:
                    return "vi";
                case Language.Chinese_Simplified:
                    return "zh-CN";
                case Language.Chinese_Traditional:
                    return "zh-TW";
                default:
                    throw new NotImplementedException("Language not supported.");
            }
        }

        protected string GetRankByValue(RankBy rankBy)
        {
            switch (rankBy)
            {
                case RankBy.Distance:
                    return "distance";
                default:
                    return "prominence";
            }
        }
        #endregion
    }
}
