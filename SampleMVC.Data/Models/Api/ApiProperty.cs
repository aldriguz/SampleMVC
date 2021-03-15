using System;
using System.Collections.Generic;

namespace SampleMVC.Infraestructure.Models.Api
{
    public class ApiProperty
    {
        public int? id { get; set; }
        public int? accountId { get; set; }
        public int? buyerAccountId { get; set; }
        public int? buyerUserId { get; set; }
        public int? externalId { get; set; }
        public int? programId { get; set; }
        public bool? isDwellCertified { get; set; }
        public bool? isAllowOffer { get; set; }
        public bool? isAllowPreview { get; set; }
        public bool? isFeatured { get; set; }
        public bool? isRentGuaranteed { get; set; }
        public bool? allowRentGuaranteedOptout { get; set; }
        public bool? isSecuritized { get; set; }
        public bool? isHot { get; set; }
        public bool? isNew { get; set; }
        public bool? isBargain { get; set; }
        public bool? isDiligenceVaultUnlocked { get; set; }
        public bool? isPropertyManagerOfferRetain { get; set; }
        public bool? isHoa { get; set; }
        public bool? hasAudio { get; set; }
        public bool? hasDiligenceVaultDocuments { get; set; }
        public int? market { get; set; }
        public int? daysOnMarket { get; set; }
        public double? latitude { get; set; }
        public double? longitude { get; set; }
        public string propertyName { get; set; }
        public string description { get; set; }
        public object highlights { get; set; }
        public string mainImageUrl { get; set; }
        public object personalProperties { get; set; }
        public string diligenceVaultSummary { get; set; }
        public object featuredReason { get; set; }
        public string status { get; set; }
        public string allowedFundingTypes { get; set; }
        public string allowableSaleTypes { get; set; }
        public string visibility { get; set; }
        public string priceVisibility { get; set; }
        public string propertyType { get; set; }
        public string certificationLevel { get; set; }
        public DateTime? escrowClosingDate { get; set; }
        public ApiAddress address { get; set; }
        public ApiFinancial financial { get; set; }
        public ApiPhysical physical { get; set; }
        public ApiScore score { get; set; }
        public ApiValuation valuation { get; set; }
        public ApiResources resources { get; set; }
        public object manager { get; set; }
        public object seller { get; set; }
        public object sellerBroker { get; set; }
        public object hoa { get; set; }
        public ApiLease lease { get; set; }
        public List<object> diligences { get; set; }
        public ApiGoogleMapOption googleMapOption { get; set; }
        public object inspectionType { get; set; }
    }
}
