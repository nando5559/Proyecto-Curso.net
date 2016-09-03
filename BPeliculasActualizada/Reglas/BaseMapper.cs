﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace Reglas
{
    public abstract class BaseMapper<T> where T: IEntidad
    {
        public virtual void Grabar(T entidad)
        {
            var lista = new List<T> { entidad };
            Grabar(lista);
        }

        public virtual void Grabar(List<T> entidades)
        {
            var itemsAGrabar = new List<T>();
            itemsAGrabar.AddRange(entidades);

            var itemsExistentes = ObtenerTodas().ToList();
            foreach (var itemExist in itemsExistentes)
            {
                var existe = false;
                foreach (var item in entidades)
                {
                    if (item.Id.Equals(itemExist.Id))
                    {
                        existe = true;
                    }
                }
                if (!existe)
                {
                    itemsAGrabar.Add(itemExist);
                }
            }

            var persistor = new EntityPersistor<T>();
            persistor.Grabar(itemsAGrabar);
        }


        public virtual IEnumerable<T> ObtenerTodas()
        {
            var persistor = new EntityPersistor<T>();
            return persistor.Recuperar();
        }

        public virtual T ObtenerUna(Guid id)
        {
            var todas = ObtenerTodas();

            return todas.
                FirstOrDefault(p => p.Id.Equals(id));
        }


    }
}
