using YSC_Server.DaoModels;

namespace YSC_Server.Interfaces
{
    public interface ILeetcodeManagerService
    {
        Leetcode Create(Leetcode body);
        Leetcode Read(int id);
        Leetcode UpdateAndReplace(int id, Leetcode body);
        
        // TODO: Dependens on what to update 
        Leetcode UpdateAndModify(int id, Leetcode body);
        Leetcode Delete(int id);
    }
}