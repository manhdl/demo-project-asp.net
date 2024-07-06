namespace Domain.Common
{
    public abstract class BaseEntity<TPrimaryKey>
    {
        public TPrimaryKey Id { get; set; }
    }
}
