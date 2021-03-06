﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gnome.DataAccess
{
    public interface IEntity<TEntity>
        where TEntity : class, new()
    {
        void Map(EntityTypeBuilder<TEntity> entity);
    }
}
