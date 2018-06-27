using System.Linq;
using YSC_Server.DaoModels;
using YSC_Server.DbContext;
using YSC_Server.Interfaces;

namespace YSC_Server.Services
{
    public class LeetcodeManagerService: ILeetcodeManagerService
    {
        private readonly IYscContext _yscContext;

        public LeetcodeManagerService(IYscContext yscContext)
        {
            _yscContext = yscContext;
        }

        public Leetcode Create(Leetcode body)
        {
            //_yscContext.Leetcodes.Add(body);
            _yscContext.Leetcodes.Attach(body);
            _yscContext.SaveChanges();
            return body;
        }

        public Leetcode Read(int id)
        {
            var leetcode = _yscContext.Leetcodes.ToList();
            return leetcode[1];
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