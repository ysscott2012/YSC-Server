namespace YSC_Server.DaoModels
{
    public class Leetcode: EntityBase
    {
        
        // Leetcode number
        public int Number { get; set; }
        
        // Leetcode description
        public string Description { get; set; }

        // Leetcode name
        public string Name { get; set; }
        
        // Leetcode Difficultity
        public string Difficultly { get; set; }
        
        // User notes
        public string Note { get; set; }
        
        // Jiuzhang algorithms
        public string Chapter { get; set; }
        
        // User alogiruthms
        public int AlgorithmId { get; set; }
    }
}