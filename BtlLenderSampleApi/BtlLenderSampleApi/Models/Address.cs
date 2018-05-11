namespace BtlLenderSampleApi.Models
{
    public class Address
    {
        public string SubBuildingName { get; set; }

        public string HouseName { get; set; }

        public string HouseNumber { get; set; }

        public string DependentThoroughFareName { get; set; }

        public string Street { get; set; }

        public string DoubleDependentLocality { get; set; }
        
        public string DependentLocality { get; set; }

        public string Town { get; set; }

        public string County { get; set; }

        public string Postcode { get; set; }

        public string ParentUprn { get; set; }

        public string Udprn { get; set; }

        public float? Longitude { get; set; }

        public float? Latitude { get; set; }

        public string Uprn { get; set; }

        public string Umrrn { get; set; }

        public bool IsVerified { get; set; }

        public string AddressSingleLine { get; set; }

        public bool IsVerifiedOrManuallyAdded { get; set; }
}
}
