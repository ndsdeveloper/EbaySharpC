namespace EbaySharp.Entities.Develop.SellingApps.SellingMetadata.Metadata.Marketplace
{
    public class ItemConditionsResponse
    {
        public List<ItemConditionPolicy> ItemConditionPolicies { get; set; }
    }

    public class ItemConditionPolicy
    {
        public string CategoryId { get; set; }
        public bool ItemConditionRequired { get; set; }
        public List<ItemCondition> ItemConditions { get; set; }
    }

    public class ItemCondition
    {
        public string ConditionId { get; set; }
        public string ConditionDescription { get; set; }
    }
}
