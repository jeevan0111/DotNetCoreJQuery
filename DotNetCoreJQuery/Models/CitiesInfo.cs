using System;
namespace DotNetCoreJQuery.Models
{
	public class CitiesInfo
	{
		private List<CountryInfo> countryInfos = new List<CountryInfo>();
		public List<CountryInfo> CountryInfosList
		{
			get { return countryInfos; }
			set { countryInfos = value; }
		}

        private List<StateInfo> stateInfos = new List<StateInfo>();
        public List<StateInfo> StateInfosList
        {
            get { return stateInfos; }
            set { stateInfos = value; }
        }

        /*
        private List<CityInfo> cityInfos = new List<CityInfo>();
        public List<CityInfo> CityInfosList
        {
            get { return cityInfos; }
            set { cityInfos = value; }
        }
		*/

        public List<CityInfo> CityInfosList { get; set; }

    }

	public class CountryInfo
	{
		public int CId { get; set; }
		public string CName { get; set; } = string.Empty;
	}

	public class StateInfo
	{
		public int SId { get; set; }
        public int CId { get; set; }
        public string SName { get; set; } = string.Empty;
	}

	public class CityInfo
	{
		public int CityId { get; set; }
        public int SId { get; set; }
        public string CityName { get; set; } = string.Empty;
	}
}

