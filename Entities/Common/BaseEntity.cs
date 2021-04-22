using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public interface IEntityApp
    {
    }
    public interface IEntityDinawin
    {
    }

    public interface IEntity
    {
    }

    public abstract class BaseEntityWithoutPK : IEntity
    {
        public BaseEntityWithoutPK()
        {
        }

        public DateTime CreateDm { get; set; }
        [StringLength(10)]
        public string CreateDs { get; set; }
        public DateTime? LastUpdateDm { get; set; }
        [StringLength(100)]
        public string LastUpdateDs { get; set; }
    }

    public abstract class BaseEntity<TKey> : BaseEntityWithoutPK, IEntity
    {
        public BaseEntity()
        {
        }
        public TKey Id { get; set; }
    }

    public abstract class BaseEntity : BaseEntity<int>
    {
    }

    public abstract class DinawinBaseEntity : IEntity
    {
        public DinawinBaseEntity()
        {
        }
    }
}