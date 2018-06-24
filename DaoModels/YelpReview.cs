namespace YSC_Server.DaoModels
{
    public class YelpReview: EntityBase
    {
        public string ReviewId { get; set; }
        public string UserId { get; set; }
        public string BusinessId { get; set; }
        public string text { get; set; }
        public string date { get; set; }
        public int stars { get; set; }
        public int cool { get; set; }
        public int funny { get; set; }
        public int type { get; set; }
        public int useful { get; set; }
    }
}