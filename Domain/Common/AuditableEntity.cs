namespace Domain.Common
{
    public class AuditableEntity<TPrimaryKey> : BaseEntity<TPrimaryKey>
    {
        public DateTime CreateAt { get ; set ; }
        public string CreateBy { get; set; } = string.Empty;
        public DateTime LastModifiedAt { get ; set ; }
        public string LastModifiedBy { get; set; } = string.Empty;
    }
}
