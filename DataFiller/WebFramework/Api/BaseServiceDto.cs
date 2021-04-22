using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ViewModels.AutoMapepr;

namespace WebFramework.Api
{
 
    public abstract class BaseServiceDto<TDto, TEntity, TKey> : IHaveCustomMapping
    where TDto : class, new()
    where TEntity :class, new()
    {
        [Display(Name = "ردیف")]
        public TKey Id { get; set; }

        public TEntity ToEntity()
        {
            return Mapper.Map<TEntity>(CastToDerivedClass(this));
        }
        public string ToJson(TEntity entity)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(entity);
        }
        public string ToJson(TDto model)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(model);
        }
        public TEntity ToEntity(TEntity entity)
        {
            return Mapper.Map(CastToDerivedClass(this), entity);
        }


        public static TDto FromEntity(TEntity model)
        {
            return Mapper.Map<TDto>(model);
        }
        public static TDto FromJson(string json)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<TDto>(json);
        }
        protected TDto CastToDerivedClass(BaseServiceDto<TDto, TEntity, TKey> baseInstance)
        {
            return Mapper.Map<TDto>(baseInstance);
        }

        public void CreateMappings(Profile profile)
        {
            var mappingExpression = profile.CreateMap<TDto, TEntity>();
            var mappingExpressionReverse = profile.CreateMap<TEntity, TDto>();

            var dtoType = typeof(TDto);
            var entityType = typeof(TEntity);
            //Ignore any property of source (like Post.Author) that dose not contains in destination 
            foreach (var property in entityType.GetProperties())
            {
                if (dtoType.GetProperty(property.Name) == null)
                    mappingExpression.ForMember(property.Name, opt => opt.Ignore());
            }
            //foreach (var property in dtoType.GetProperties())
            //{
            //    if (entityType.GetProperty(property.Name) == null)
            //        mappingExpression.ForMember(property.Name, opt => opt.Ignore());
            //}

            CustomMappings(mappingExpression.ReverseMap());
            CustomMappingsReverse(mappingExpressionReverse.ReverseMap());
        }

        public virtual void CustomMappings(IMappingExpression<TEntity, TDto> mapping)
        {
        }
        public virtual void CustomMappingsReverse(IMappingExpression<TDto, TEntity> mapping)
        {
        }
    }

    

    //public abstract class BaseServiceDto<TDto, TEntity, TKey> : BaseDto<TDto, TEntity, TKey>
    //where TDto : class, new()
    //where TEntity : class, new()
    //    where TKey:int

    //{

    //}
}
