namespace CustomerSupportSystem.Models
{
    public class Query
    {
        public enum ComplexityLevel
        {
            Basic,
            Intermediate,
            Advanced,
            Unknown
        }

        public ComplexityLevel Complexity { get; set; }
        public string Description { get; set; }

        public Query(ComplexityLevel complexity, string description)
        {
            Complexity = complexity;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Description} (Complexity: {Complexity})";
        }
    }
}
