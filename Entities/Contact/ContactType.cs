using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    /// <summary>
    /// کلاس برای تیبل 
    /// </summary>
    public class ContactType : BaseEntity<ContactTypeEnum>, IEntityApp
    {
        public string Value { get; set; }
        public IEnumerable<Contact> Contacts { get; set; }
    }

    public enum ContactTypeEnum
    {
        [Display(Name = "تلفن ثابت")]
        Tel = 1,
        [Display(Name = "موبایل")]
        Mobile = 2,
        [Display(Name = "آدرس")]
        Address = 3,
        [Display(Name = "مکان سیستمی")]
        LocationSystem = 4,
        [Display(Name = "شغل")]
        Job = 5,
        [Display(Name = "مکان دستی")]
        LocationManual = 6,
        [Display(Name = "شهر")]
        City = 7,
        [Display(Name = "استان")]
        State = 8,
        [Display(Name = "کد پستی")]
        ZipCode = 9
    }

    internal class ContactTypeConfiguration : IEntityTypeConfiguration<ContactType>
    {
        public void Configure(EntityTypeBuilder<ContactType> builder)
        {
            builder.ToTable(nameof(ContactType), nameof(SchemaEnum.profile));
            builder.Property(p => p.Value).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Id).ValueGeneratedNever();
            builder.HasMany(z => z.Contacts).WithOne(z => z.ContactType).HasForeignKey(z => z.ContactTypeId);
        }
    }
}