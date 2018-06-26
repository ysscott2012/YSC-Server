using YSC_Server.DaoModels;
using YSC_Server.DbContext;
using YSC_Server.Interfaces;

namespace YSC_Server.Services
{
    public class LeetcodeManagerService: ILeetcodeManagerService
    {
        private readonly IYscContext _YscContext;

        public LeetcodeManagerService(IYscContext yscContext)
        {
            _YscContext = yscContext;
        }

        public Leetcode Create(Leetcode body)
        {
            throw new System.NotImplementedException();
        }

        public Leetcode Read(int id)
        {
            throw new System.NotImplementedException();
        }

        public Leetcode UpdateAndReplace(int id, Leetcode body)
        {
            throw new System.NotImplementedException();
        }

        public Leetcode UpdateAndModify(int id, Leetcode body)
        {
            throw new System.NotImplementedException();
        }

        public Leetcode Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}