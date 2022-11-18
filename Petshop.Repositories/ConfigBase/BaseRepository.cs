using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Petshop.Entities.Config;
using Petshop.Shared.Configurations;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Repositories.ConfigBase
{
    public class BaseRepository : DbContext
    {
        public BaseRepository()
        {
            this._contexto = new PetshopContext();
            Command = new SqlCommand();
        }

        public BaseRepository(PetshopContext database)
        {
            this._contexto = database;
            Command = new SqlCommand();
        }

        public BaseRepository(Type type)
        {
            this._contexto = new PetshopContext();
            this._TypeEntity = type;
            Command = new SqlCommand();
        }

        protected static int PageSize = 20;

        protected static Semaphore? semaphore;

        public PetshopContext Contexto
        {
            get
            {
                return this._contexto;
            }
            private set
            {
                this._contexto = value;
            }
        }
        private PetshopContext _contexto;

        public Type TypeEntity
        {
            get
            {
                return this._TypeEntity;
            }
            set
            {
                this._TypeEntity = value;
            }
        }
        private Type? _TypeEntity;


        public static SqlCommand? Command;

        public virtual int GetQtdeRegistroPagina()
        {
            return 20;
        }

        protected dynamic? GetById<T>(int Id) where T : class
        {
            return Contexto.Find<T>(new object[1] { Id });
        }

        protected void Create<T>(T model) where T : class
        {
            Contexto.Entry(Convert.ChangeType(model, model.GetType())).State = EntityState.Added;
            Contexto.SaveChanges();
        }

        protected void Edit<T>(T model) where T : class
        {
            Contexto.Entry(Convert.ChangeType(model, model.GetType())).State = EntityState.Modified;
            Contexto.SaveChanges();
        }

        protected void Delete<T>(T model) where T : class
        {
            Contexto.Entry(Convert.ChangeType(model, model.GetType())).State = EntityState.Deleted;
            Contexto.SaveChanges();
        }

        public dynamic CustomSelect<T>(string Query, bool isList) where T : class, new()
        {
            string connectionString = ConnectionStrings.DBConnection;
            SqlConnection Conection = new SqlConnection(connectionString);

            try
            {
                Conection.Open();

                Command!.Connection = Conection;
                Command.CommandText = Query;

                SqlDataAdapter DA = new SqlDataAdapter(Command);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                List<T> List = DataTableToList<T>(DS.Tables[0]);

                if (isList)
                    return List;
                else if (!isList)
                    return List.FirstOrDefault();

                return null;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                Conection.Close();
                Conection.Dispose();
            }
        }

        public List<T> DataTableToList<T>(DataTable table) where T : class, new()
        {
            try
            {
                List<T> list = new List<T>();

                foreach (var row in table.AsEnumerable())
                {
                    T obj = new T();

                    PropertyInfo propertyInfo = null;
                    foreach (var prop in obj.GetType().GetProperties())
                    {
                        try
                        {
                            propertyInfo = obj.GetType().GetProperty(prop.Name);
                            propertyInfo.SetValue(obj, Convert.ChangeType(row[prop.Name], propertyInfo.PropertyType), null);
                        }
                        catch
                        {
                            if (propertyInfo.PropertyType == typeof(DateTime?) && row[prop.Name].GetType() == typeof(DateTime))
                            {
                                string Date = row[prop.Name].ToString();
                                if (string.IsNullOrEmpty(Date))
                                    propertyInfo.SetValue(obj, null);
                                else
                                    propertyInfo.SetValue(obj, DateTime.Parse(Date));
                            }
                            else if (propertyInfo.PropertyType == typeof(int?) && row[prop.Name].GetType() == typeof(int))
                            {
                                int? newDate = int.Parse(row[prop.Name].ToString());
                                propertyInfo.SetValue(obj, newDate);
                            }

                            continue;
                        }
                    }

                    list.Add(obj);
                }

                return list;
            }
            catch
            {
                return null;
            }
        }

        public virtual void BeforeSave(List<string> erros, object model)
        {
            if (erros != null && erros.Count() > 0)
                throw new Exception(string.Join(" - ", erros));
        }

        public virtual void AfterSave(List<string> erros, object model)
        {
            if (erros != null && erros.Count() > 0)
                throw new Exception(string.Join(" - ", erros));
        }
    }
}
