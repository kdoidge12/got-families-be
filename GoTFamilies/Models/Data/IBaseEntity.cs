using System;

namespace GoTFamilies.Models.Data
{
    public interface IBaseEntity
    {
        Guid Id { get; set; }
    }
}