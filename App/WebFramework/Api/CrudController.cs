using AutoMapper.QueryableExtensions;
using Data.Repositories;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ViewModels.AutoMapepr;
using WebFramework.Filters;

namespace WebFramework.Api
{
    [ApiVersion("2")]
    public class CrudController<TDto, TSelectDto, TEntity, TKey> : BaseController
        where TDto : BaseDto<TDto, TEntity, TKey>, new()
        where TSelectDto : BaseDto<TSelectDto, TEntity, TKey>, new()
        where TEntity : BaseEntity<TKey>, new()
    {
        private readonly IRepository<TEntity> _repository;

        public CrudController(IRepository<TEntity> repository)
        {
            _repository = repository;
        }
        /// <summary>
        /// گرفتن اطلاعات شعب بدون عکس
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpGet]
        public virtual async Task<ActionResult<List<TSelectDto>>> Get(CancellationToken cancellationToken)
        {

            var list = await _repository.TableNoTracking.ProjectTo<TSelectDto>()
                .ToListAsync(cancellationToken);

            return Ok(list);
        }
        /// <summary>
        /// اپدیت کردن شعبه 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpGet("{id:int}")]
        public virtual async Task<ApiResult<TSelectDto>> Get(TKey id, CancellationToken cancellationToken)
        {
            var dto = await _repository.TableNoTracking.ProjectTo<TSelectDto>()
                .SingleOrDefaultAsync(p => p.Id.Equals(id), cancellationToken);

            if (dto == null)
                return NotFound();

            return dto;
        }
        /// <summary>
        /// ایجاد یک شعبه
        /// </summary>
        /// <param name="dto"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns> \

        [HttpPost]
        public virtual async Task<ApiResult<TSelectDto>> Create(TDto dto, CancellationToken cancellationToken)
        {
            try
            {

                var model = dto.ToEntity();

                await _repository.AddAsync(model, cancellationToken);

                var resultDto = await _repository.TableNoTracking.ProjectTo<TSelectDto>().SingleOrDefaultAsync(p => p.Id.Equals(model.Id), cancellationToken);

                return resultDto;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dto"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPut]
        public virtual async Task<ApiResult<TSelectDto>> Update(TKey id, TDto dto, CancellationToken cancellationToken)
        {
            var model = await _repository.GetByIdAsync(cancellationToken, id);

            model = dto.ToEntity(model);

            await _repository.UpdateAsync(model, cancellationToken);

            var resultDto = await _repository.TableNoTracking.ProjectTo<TSelectDto>().SingleOrDefaultAsync(p => p.Id.Equals(model.Id), cancellationToken);

            return resultDto;
        }
        /// <summary>
        /// حذف کردن یک شعبه
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpDelete("{id:int}")]
        public virtual async Task<ApiResult> Delete(TKey id, CancellationToken cancellationToken)
        {
            var model = await _repository.GetByIdAsync(cancellationToken, id);

            await _repository.DeleteAsync(model, cancellationToken);

            return Ok();
        }
    }

    public class CrudController<TDto, TSelectDto, TEntity> : CrudController<TDto, TSelectDto, TEntity, int>
        where TDto : BaseDto<TDto, TEntity, int>, new()
        where TSelectDto : BaseDto<TSelectDto, TEntity, int>, new()
        where TEntity : BaseEntity<int>, new()
    {
        public CrudController(IRepository<TEntity> repository)
            : base(repository)
        {
        }
    }

    public class CrudController<TDto, TEntity> : CrudController<TDto, TDto, TEntity, int>
        where TDto : BaseDto<TDto, TEntity, int>, new()
        where TEntity : BaseEntity<int>, new()
    {
        public CrudController(IRepository<TEntity> repository)
            : base(repository)
        {
        }
    }
}
