using Inventory.Application.Contracts;

namespace Inventory.Application.Models
{
    public abstract class FullAuditableModel : IIdentityModel, IAuditedModel, IActivateableModel
    {
        public  int Id { get; set; }
        public  string CreatedByUserId { get; set; }
        public  DateTime CreatedDate { get; set; }
        public  string LastModifiedUserId { get; set; }
        public  DateTime? LastModifiedDate { get; set; }
        public  bool isActive { get; set; }
    }
}
