using YSC_Server.DaoModels;

namespace YSC_Server.Models
{
    public class LeetcodeResponse: PayloadResponse<Leetcode>
    {
        public LeetcodeResponse(Leetcode data)
        {
            Payload = data;
        }
    }
}