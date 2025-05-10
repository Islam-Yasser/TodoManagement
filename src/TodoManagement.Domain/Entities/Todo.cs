using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoManagement.Enums;
using Volo.Abp.Domain.Entities.Auditing;

namespace TodoManagement.Entities;

public class Todo  : AuditedEntity<Guid>
{
    public string Title { get; set; }
    public string Description { get; set; }
    public Status Status { get; set; }
    public Priority Priority { get; set; }
    public DateTime DueDate { get; set; }
}
