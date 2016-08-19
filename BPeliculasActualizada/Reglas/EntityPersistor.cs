﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Reglas
{
    class EntityPersistor
    {
          public class EntityPersistor<T>
    {
        private string _nombreArchivo;

        public EntityPersistor()
        {
            var path = System.Windows.Forms.Application.StartupPath;
            var nombreTipo = typeof(T).FullName;
            _nombreArchivo = path + "\\" + nombreTipo + ".json";
        }

        public void Grabar(T entidad)
        {
            var lista = new List<T>();
            lista.Add(entidad);
            Grabar(lista);
        }

        public void Grabar(IEnumerable<T> lista)
        {
            var listaSerializa = JsonConvert.SerializeObject(lista);
            System.IO.File.WriteAllText(_nombreArchivo, listaSerializa);
        }


        public IEnumerable<T> Recuperar()
        {
            var contenido = System.IO.File.ReadAllText(_nombreArchivo);
            var lista = JsonConvert.DeserializeObject<List<T>>(contenido);
            return lista;
        }

    }
}
