namespace CloudSuite.BackBonne.Domain.models.Accounts_Context
{
    public class Branch : Entity, IAggregateRoot
    {
        public string? BranchNumber { get; private set; }
        
    }
}