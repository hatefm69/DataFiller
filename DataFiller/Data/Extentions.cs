using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Common.Utilities;
using Entities;

namespace Microsoft.EntityFrameworkCore
{



    public static class Extentions
    {
        public static TEntity myAdd<TEntity>(this DbSet<TEntity> dbset, TEntity entity) where TEntity : class, IEntity
        {
            //int Result = 0;

            Assert.NotNull(entity, nameof(entity));

            //entity = FixPersianText(entity);

            //entity = SetCreationTime(entity);

            //if (IsDeletedOrNotActiveEntity(entity))
            //    return null;


            //entity.CreateDm = DateTime.Now;
            //entity.CreateDs = DateTime.Now.ToPersian();


            dbset.Add(entity);

            //if (saveNow)
            //    Result = await DbContext.SaveChangesAsync(cancellationToken).ConfigureAwait(false);

            return entity;



        }



        public static DbContext GetContext<TEntity>(this DbSet<TEntity> dbSet)
     where TEntity : class
        {
            object internalSet = dbSet
                .GetType()
                .GetField("_internalSet", BindingFlags.NonPublic | BindingFlags.Instance)
                .GetValue(dbSet);
            object internalContext = internalSet
                .GetType()
                .BaseType
                .GetField("_internalContext", BindingFlags.NonPublic | BindingFlags.Instance)
                .GetValue(internalSet);
            return (DbContext)internalContext
                .GetType()
                .GetProperty("Owner", BindingFlags.Instance | BindingFlags.Public)
                .GetValue(internalContext, null);
        }
        #region JalalTools
        #region JalalToolsDB
        public static async Task<TEntity> AddAsync<TEntity>(this DbSet<TEntity> dbset, TEntity entity, CancellationToken cancellationToken) where TEntity : class, IEntity
        {
            int Result = 0;

            Assert.NotNull(entity, nameof(entity));

            entity = FixPersianText(entity);

            entity = SetCreationTime(entity);

            if (IsDeletedOrNotActiveEntity(entity))
                return null;


            await dbset.AddAsync(entity, cancellationToken).ConfigureAwait(false);

            //if (saveNow)
            //    Result = await DbContext.SaveChangesAsync(cancellationToken).ConfigureAwait(false);

            if (Result > 0)
                return entity;

            return null;
        }
        public static async Task<IEnumerable<TEntity>> AddRangeAsync<TEntity>(this DbSet<TEntity> dbset, IEnumerable<TEntity> entities, CancellationToken cancellationToken) where TEntity : BaseEntity, IEntity
        {
            int Result = 0;

            Assert.NotNull(entities, nameof(entities));

            entities = FixPersianText(entities);

            entities = SetCreationTimes(entities);

            await dbset.AddRangeAsync(entities, cancellationToken).ConfigureAwait(false);

            if (Result > 0)
                return SetOrder(entities);

            return null;
        }
        public static async Task<TEntity> UpdateAsync<TEntity>(this DbSet<TEntity> dbset, TEntity entity) where TEntity : class, IEntity
        {
            int Result = 0;

            Assert.NotNull(entity, nameof(entity));

            entity = FixPersianText(entity);

            entity = SetModifiedTime(entity);

            dbset.Update(entity);

            if (Result > 0)
                return entity;

            return null;
        }
        public static async Task<IEnumerable<TEntity>> UpdateRangeAsync<TEntity>(this DbSet<TEntity> dbset, IEnumerable<TEntity> entities, CancellationToken cancellationToken) where TEntity : BaseEntity, IEntity
        {
            int Result = 0;

            dbset.Local.Clear();

            entities.ToList().ForEach(delegate (TEntity entity)
            {
                Assert.NotNull(entity, nameof(entity));
                dbset.Attach(entity).State = EntityState.Modified;
            });

            entities = FixPersianText(entities);

            entities = SetModifiedTimes(entities);


            await dbset.UpdateRangeAsync(entities, cancellationToken);


            if (Result > 0)
                return SetOrder(entities);

            return null;
        }
        #endregion

        #region JalalQuery
        public static async Task<IEnumerable<TEntity>> FilterRangeAsync<TEntity>(this DbSet<TEntity> dbset, TEntity entity, CancellationToken cancel, int total = 0, int more = int.MaxValue) where TEntity : BaseEntity, IEntity
        {
            var deletedProp = entity.GetType().GetProperty("Deleted");
            if (deletedProp != null)
                deletedProp.SetValue(entity, null);

            var properties = entity.GetType()
                .GetProperties()
                .Where(x => x.GetValue(entity) != null
                && (x.PropertyType != typeof(DateTime) || (x.PropertyType == typeof(DateTime) && ((DateTime)x.GetValue(entity)).Year > 10))
                && (x.PropertyType != typeof(DateTime?) || (x.PropertyType == typeof(DateTime?) && ((DateTime)x.GetValue(entity)).Year > 10))
                && (x.PropertyType != typeof(TimeSpan) || (x.PropertyType == typeof(TimeSpan) && ((TimeSpan)x.GetValue(entity)).Hours > 0))
                && (x.PropertyType != typeof(TimeSpan?) || (x.PropertyType == typeof(TimeSpan?) && ((TimeSpan)x.GetValue(entity)).Hours > 0))
                && (x.PropertyType != typeof(Int32) || (x.PropertyType == typeof(Int32) && ((Int32)x.GetValue(entity)) > 0))
                && (x.PropertyType != typeof(long) || (x.PropertyType == typeof(long) && ((long)x.GetValue(entity)) > 0))
                && (x.PropertyType != typeof(string) || (x.PropertyType == typeof(string) && !string.IsNullOrEmpty((string)x.GetValue(entity))))
                && !x.PropertyType.IsGenericType
                && x.PropertyType != typeof(DayOfWeek)
                && x.PropertyType != typeof(DayOfWeek?))
                .ToList();

            //var mapping = DbContext.Model.FindEntityType(typeof(TEntity)).Relational();
            var entityType = dbset.GetContext().Model.FindEntityType(typeof(TEntity));
            //var attsss = (TableAttribute)typeof(TEntity).GetCustomAttributes();
            //var atts = (TableAttribute)typeof(TEntity).GetCustomAttributes().Where(w => w.GetType() == typeof(TableAttribute)).FirstOrDefault();
            var schema = entityType.GetSchema();
            var tableName = entityType.GetTableName();
            var sql = $"select * from {schema}.{tableName} ";

            if (!properties.Equals(null) && properties.Count() > 0)
            {
                sql += "where ";
                properties.ForEach(delegate (PropertyInfo info)
                {
                    // check and deactivate default numbers like 0 into search and filter action
                    if (info.PropertyType == typeof(bool))
                        sql += $" {info.Name} = {Convert.ToInt32(info.GetValue(entity))} and";
                    else if (info.PropertyType == typeof(string))
                        sql += $" {info.Name} = '{info.GetValue(entity)}' and";
                    else if (info.PropertyType == typeof(DateTime) || info.PropertyType == typeof(DateTime?))
                        sql += $" datediff(day, {info.Name}, '{Convert.ToDateTime(info.GetValue(entity)).ToString("yyyy/MM/dd")}') = 0 and";
                    else
                        sql += $" {info.Name} = {info.GetValue(entity)} and";
                });

                sql += FixedSqlQueryParameters<TEntity>();

                sql = sql.Substring(0, sql.Length - 3);
                //sql += ";";
            }

            IEnumerable<TEntity> data = await dbset.FromSqlRaw(sql)
                .Skip(total)
                .Take(more)
                .ToListAsync();

            return SetOrder(data);
        }
        public static async Task<IEnumerable<TEntity>> SearchRangeAsync<TEntity>(this DbSet<TEntity> dbset, TEntity entity, string text, CancellationToken cancel, int total = 0, int more = int.MaxValue) where TEntity : BaseEntity, IEntity
        {
            var deletedProp = entity.GetType().GetProperty("Deleted");
            if (deletedProp != null)
                deletedProp.SetValue(entity, null);

            var properties = entity.GetType()
                .GetProperties()
                .Where(x => x.PropertyType == typeof(string))
                .ToList();

            var entityType = dbset.GetContext().Model.FindEntityType(typeof(TEntity));
            var schema = entityType.GetSchema();
            var tableName = entityType.GetTableName();
            var sql = $"select * from {schema}.{tableName} ";

            if (!properties.Equals(null) && properties.Count() > 0)
            {
                sql += "where (";
                properties.ForEach(delegate (PropertyInfo info)
                {
                    // check and deactivate default numbers like 0 into search and filter action
                    //if (info.PropertyType == typeof(string))
                    sql += $" [{info.Name}] like N'%{text}%' or";
                });

                sql = sql.Substring(0, sql.Length - 2);

                sql = sql + ") and ";

                sql += FixedSqlQueryParameters<TEntity>();

                sql = sql.Substring(0, sql.Length - 3);
                //sql += ";";
            }

            IEnumerable<TEntity> data = await dbset.FromSqlRaw(sql)
                .Skip(total)
                .Take(more)
                .ToListAsync();

            return SetOrder(data);
        }
        public static async Task<TEntity> UpdateFieldRangeAsync<TEntity>(this DbSet<TEntity> dbset, CancellationToken cancellation, TEntity entity, params string[] fields) where TEntity : BaseEntity, IEntity
        {
            bool saveNow = true;
            if (entity != null && entity.Id > 0 && fields.Length > 0)
            {
                var properties = entity.GetType().GetProperties();

                if (properties != null && properties.Length > 0)
                {
                    var data = await dbset
                        .Where(w => w.Id == entity.Id)
                        .FirstOrDefaultAsync();

                    if (data != null)
                    {
                        foreach (var field in fields)
                        {
                            var prop = properties.Where(w => w.Name == field).FirstOrDefault();
                            if (prop != null)
                            {
                                prop.SetValue(data, prop.GetValue(entity));
                            }
                        }
                    }

                    var result = -1;

                    dbset.Update(data);


                    if (result > 0)
                        return data;

                    return null;
                }
            }
            return null;
        }
        public static async Task<TEntity> UpdateFieldRangeAsync<TEntity>(this DbSet<TEntity> dbset, CancellationToken cancellation, int Id, params KeyValuePair<string, dynamic>[] fields) where TEntity : BaseEntity, IEntity
        {
            bool saveNow = true;
            if (fields != null && Id > 0 && fields.Length > 0)
            {
                var data = await dbset
                    .Where(w => w.Id == Id)
                    .FirstOrDefaultAsync();

                var properties = data.GetType().GetProperties();

                if (properties != null && properties.Length > 0)
                {
                    if (data != null)
                    {
                        foreach (var field in fields)
                        {
                            var prop = properties.Where(w => w.Name == field.Key).FirstOrDefault();
                            if (prop != null)
                            {
                                prop.SetValue(data, prop.GetValue(field.Value));
                            }
                        }
                    }

                    var result = -1;

                    dbset.Update(data);

                    if (result > 0)
                        return data;

                    return null;
                }
            }
            return null;
        }
        #endregion JalalQuery


        public static async Task<TEntity> ItemSync<TEntity>(this DbSet<TEntity> dbset, TEntity Target, TEntity Origin, CancellationToken cancel) where TEntity : class, IEntity
        {
            try
            {
                var Properties = typeof(TEntity).GetProperties()
                    .Where(x => x.GetValue(Target) != null)
                    .ToList();

                Properties.ForEach(delegate (PropertyInfo info)
                {
                    if (info.PropertyType == typeof(Int64) || info.PropertyType == typeof(Int64?))
                    {
                        if ((long)info.GetValue(Target) > 0 && info.GetValue(Target) != info.GetValue(Origin))
                            info.SetValue(Origin, info.GetValue(Target));
                    }
                    else if (info.PropertyType == typeof(bool) || info.PropertyType == typeof(bool?))
                    {
                        if (info.GetValue(Target) != null && info.GetValue(Target) != info.GetValue(Origin))
                            info.SetValue(Origin, info.GetValue(Target));
                    }
                    else if (info.PropertyType == typeof(Int32) || info.PropertyType == typeof(Int32?))
                    {
                        if ((int)info.GetValue(Target) > 0 && info.GetValue(Target) != info.GetValue(Origin))
                            info.SetValue(Origin, info.GetValue(Target));
                    }
                    else if (info.PropertyType == typeof(float) || info.PropertyType == typeof(float?))
                    {
                        if ((float)info.GetValue(Target) > 0 && info.GetValue(Target) != info.GetValue(Origin))
                            info.SetValue(Origin, info.GetValue(Target));
                    }
                    else if (info.PropertyType == typeof(string))
                    {
                        var value = info.GetValue(Target);
                        if (!string.IsNullOrEmpty(Convert.ToString(value)) && info.GetValue(Target) != info.GetValue(Origin))
                            info.SetValue(Origin, info.GetValue(Target));
                    }
                    else if (info.PropertyType == typeof(DateTime) || info.PropertyType == typeof(DateTime?))
                    {
                        if (((DateTime)info.GetValue(Target)).Year > DateTime.MinValue.Year && info.GetValue(Target) != info.GetValue(Origin))
                            info.SetValue(Origin, info.GetValue(Target));
                    }
                    else if (info.PropertyType == typeof(TimeSpan) || info.PropertyType == typeof(TimeSpan?))
                    {
                        if (((TimeSpan)info.GetValue(Target)).TotalSeconds > 0 && info.GetValue(Target) != info.GetValue(Origin))
                            info.SetValue(Origin, info.GetValue(Target));
                    }
                    else if (info.PropertyType == typeof(double) || info.PropertyType == typeof(double?))
                    {
                        if (((double)info.GetValue(Target)) > 0 && info.GetValue(Target) != info.GetValue(Origin))
                            info.SetValue(Origin, info.GetValue(Target));
                    }
                    else if (info.PropertyType == typeof(decimal) || info.PropertyType == typeof(decimal?))
                    {
                        if (((decimal)info.GetValue(Target)) > 0 && info.GetValue(Target) != info.GetValue(Origin))
                            info.SetValue(Origin, info.GetValue(Target));
                    }
                    else if (info.PropertyType == typeof(byte) || info.PropertyType == typeof(byte?))
                    {
                        if (((byte)info.GetValue(Target)) > 0 && info.GetValue(Target) != info.GetValue(Origin))
                            info.SetValue(Origin, info.GetValue(Target));
                    }
                });

                return Origin;
            }
            catch (Exception Ex)
            {
                return null;
            }
        }
        private static TEntity FixPersianText<TEntity>(TEntity entity) where TEntity : class, IEntity
        {
            var properties = entity.GetType()
                .GetProperties()
                .Where(x => x.GetValue(entity) != null && x.PropertyType == typeof(string))
                .ToList();

            properties.ForEach(delegate (PropertyInfo info)
            {
                info.SetValue(entity, info.GetValue(entity).ToString().FixPersianChars());
            });

            return entity;
        }
        private static IEnumerable<TEntity> FixPersianText<TEntity>(IEnumerable<TEntity> entities) where TEntity : class, IEntity
        {
            List<TEntity> persianEntities = new List<TEntity>();
            entities.ToList().ForEach(delegate (TEntity entity)
            {
                entity = FixPersianText(entity);
                persianEntities.Add(entity);
            });
            return persianEntities;
        }
        private static bool IsDeletedOrNotActiveEntity<TEntity>(TEntity entity) where TEntity : class, IEntity
        {
            try
            {
                var info = entity.GetType().GetProperty("deleted");
                var infoActivation = entity.GetType().GetProperty("isActive");

                if (info.GetValue(entity) == null)
                {
                    return false;
                }

                if (infoActivation.GetValue(entity) == null)
                {
                    return false;
                }

                if ((info != null && (bool)info.GetValue(entity) == true) || (infoActivation != null && (infoActivation.GetValue(entity) == null || (bool)infoActivation.GetValue(entity) == false)))
                    return true;
            }
            catch (Exception Ex)
            {

            }

            return false;
        }
        private static IEnumerable<TEntity> GetUnDeleteds<TEntity>(IEnumerable<TEntity> entities) where TEntity : class, IEntity
        {
            List<TEntity> undeleteds = new List<TEntity>();
            if (entities != null && entities.Count() > 0)
            {
                foreach (var entity in entities)
                {
                    if (!IsDeletedOrNotActiveEntity(entity))
                        undeleteds.Add(entity);
                }
            }

            return undeleteds;
        }
        private static string FixedSqlQueryParameters<TEntity>(bool or = false) where TEntity : class, IEntity
        {
            if (or)
            {
                return $" ([Deleted] is null or [Deleted] = 0) or ([isActive] is null or [isActive] = 1) or";
            }

            return $" ([deleted] is null or [deleted] = 0) and ([isActive] is null or [isActive] = 1) and";
        }
        private static TEntity SetCreationTime<TEntity>(TEntity entity) where TEntity : class, IEntity
        {
            var nowDT = DateTime.Now;
            var propertyCreate = entity.GetType().GetProperty("creationDateTime");
            if (propertyCreate != null)
            {
                propertyCreate.SetValue(entity, nowDT);
            }

            var propertyPersianCreate = entity.GetType().GetProperty("creationPersianDateTime");
            if (propertyPersianCreate != null)
            {
                var dt = nowDT.ToPersianWithTime();
                propertyPersianCreate.SetValue(entity, dt);
            }

            return entity;
        }
        private static IEnumerable<TEntity> SetCreationTimes<TEntity>(IEnumerable<TEntity> entities) where TEntity : class, IEntity
        {
            IEnumerable<TEntity> newEntities = new List<TEntity>();

            foreach (var entity in entities)
            {
                var nowDT = DateTime.Now;
                var propertyCreate = entity.GetType().GetProperty("creationDateTime");
                if (propertyCreate != null)
                {
                    propertyCreate.SetValue(entity, nowDT);
                }

                var propertyPersianCreate = entity.GetType().GetProperty("creationPersianDateTime");
                if (propertyPersianCreate != null)
                {
                    var dt = nowDT.ToPersianWithTime();
                    propertyPersianCreate.SetValue(entity, dt);
                }

                newEntities = newEntities.Append(entity);
            }

            return newEntities;
        }
        private static TEntity SetModifiedTime<TEntity>(TEntity entity) where TEntity : class, IEntity
        {
            var nowDT = DateTime.Now;
            var propertyCreate = entity.GetType().GetProperty("modifiedDateTime");
            if (propertyCreate != null)
            {
                propertyCreate.SetValue(entity, nowDT);
            }

            var propertyPersianCreate = entity.GetType().GetProperty("modifiedPersianDateTime");
            if (propertyPersianCreate != null)
            {
                var dt = nowDT.ToPersianWithTime();
                propertyPersianCreate.SetValue(entity, dt);
            }

            return entity;
        }
        private static IEnumerable<TEntity> SetModifiedTimes<TEntity>(IEnumerable<TEntity> entities) where TEntity : class, IEntity
        {
            IEnumerable<TEntity> newEntities = new List<TEntity>();

            foreach (var entity in entities)
            {
                var nowDT = DateTime.Now;
                var propertyCreate = entity.GetType().GetProperty("modifiedDateTime");
                if (propertyCreate != null)
                {
                    propertyCreate.SetValue(entity, nowDT);
                }

                var propertyPersianCreate = entity.GetType().GetProperty("modifiedPersianDateTime");
                if (propertyPersianCreate != null)
                {
                    var dt = nowDT.ToPersianWithTime();
                    propertyPersianCreate.SetValue(entity, dt);
                }

                newEntities = newEntities.Append(entity);
            }

            return newEntities;
        }
        private static TEntity SetDeletedTime<TEntity>(TEntity entity) where TEntity : class, IEntity
        {
            var nowDT = DateTime.Now;
            var propertyCreate = entity.GetType().GetProperty("deletedDateTime");
            if (propertyCreate != null)
            {
                propertyCreate.SetValue(entity, nowDT);
            }

            var propertyPersianCreate = entity.GetType().GetProperty("deletedPersianDateTime");
            if (propertyPersianCreate != null)
            {
                var dt = nowDT.ToPersianWithTime();
                propertyPersianCreate.SetValue(entity, dt);
            }

            return entity;
        }
        private static IEnumerable<TEntity> SetDeletedTimes<TEntity>(IEnumerable<TEntity> entities) where TEntity : class, IEntity
        {
            IEnumerable<TEntity> newEntities = new List<TEntity>();

            foreach (var entity in entities)
            {
                var nowDT = DateTime.Now;
                var propertyCreate = entity.GetType().GetProperty("deletedDateTime");
                if (propertyCreate != null)
                {
                    propertyCreate.SetValue(entity, nowDT);
                }

                var propertyPersianCreate = entity.GetType().GetProperty("deletedPersianDateTime");
                if (propertyPersianCreate != null)
                {
                    var dt = nowDT.ToPersianWithTime();
                    propertyPersianCreate.SetValue(entity, dt);
                }
                newEntities = newEntities.Append(entity);
            }

            return newEntities;
        }
        private static IEnumerable<TEntity> SetOrder<TEntity>(IEnumerable<TEntity> entities) where TEntity : BaseEntity, IEntity
        {
            try
            {
                return entities//.OrderByDescending(item => item.Important)
                               //.ThenByDescending(item => item.Priority)
                               // .ThenByDescending(item => item.UserCreatedId)
                    .OrderByDescending(item => item.Id);
            }
            catch (Exception Ex)
            {
                return null;
            }
        }
        #endregion JalalTools
    }
}
