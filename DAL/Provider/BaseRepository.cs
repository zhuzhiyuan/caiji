using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Data;
using System.Linq.Expressions;

using ServiceStack.OrmLite;


namespace DAL.Provider
{
    public class BaseRepository<T>
    {
        static BaseRepository()
        {
            OrmLiteConfig.DialectProvider = SqlServerDialect.Provider;
        }

        /// <summary>
        /// 数据库连接
        /// </summary>
        protected string DbConnection;
        protected IDbConnection OpenDbConnection()
        {
            if (DbConnection == null)
            {
                throw new Exception("Connection string \"DbConnection\" can not be null.");
            }

            return DbConnection.OpenDbConnection();
        }

        #region Select封装

        /// <summary>
        /// 通过lambda表达式返回数据
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="async">默认异步</param>
        /// <returns></returns>
        protected List<T> Select(Expression<Func<T, bool>> predicate)
        {
            try
            {
                using (var db = OpenDbConnection())
                {
                    return db.Select(predicate);
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }

  


        

        #endregion

        #region Single封装

        /// <summary>
        /// 通过lambda表达式返回单条数据
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="async">默认异步</param>
        /// <returns></returns>
        protected T Single(Expression<Func<T, bool>> predicate)
        {
            using (var db = OpenDbConnection())
            {
                return db.Single(predicate);
            }
        }
        /// <summary>
        /// 通过SqlExpression lambda表达式返回单条数据
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="async">默认异步</param>
        /// <returns></returns>
        protected T Single(SqlExpression<T> expression)
        {
            using (var db = OpenDbConnection())
            {
                return db.Single(expression);
            }
        }

        protected T SingleById(object idValue)
        {
            using (var db = OpenDbConnection())
            {
                return db.SingleById<T>(idValue);
            }
        }

        protected T SingleWhere(string name, object value)
        {
            using (var db = OpenDbConnection())
            {
                return db.SingleWhere<T>(name, value);
            }
        }

        #endregion

        #region Scalar封装
        
        

        #endregion

        #region Insert封装

        protected long Insert(T entity)
        {
            try
            {
                using (var db = OpenDbConnection())
                {
                    return db.Insert(entity);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        protected void Insert(IEnumerable<T> entities)
        {
            try
            {
                using (var db = OpenDbConnection())
                {
                   
                        foreach (var entity in entities)
                        {
                            db.Insert(entity);
                        }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        #endregion

        #region Update封装

        /// <summary>
        /// 更新所有的字段，未赋值字段则为默认值
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        protected int Update(T entity)
        {
            try
            {
                using (var db = OpenDbConnection())
                {
                    return db.Update(entity);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }



      
        /// <summary>
        /// 更新所提供的字段，对象的int，bool必须设置为可空，否则设置int=0会失败
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="where"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        protected int UpdateNonDefaults(T entity, Expression<Func<T, bool>> where)
        {
            try
            {
                using (var db = OpenDbConnection())
                {
                    return db.UpdateNonDefaults(entity, where);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    

        protected int Update(object updateOnly, Expression<Func<T, bool>> where = null)
        {
            try
            {
                using (var db = OpenDbConnection())
                {
                    return db.Update(updateOnly, where);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        #endregion

        #region Delete封装

        protected int Delete(T entity)
        {
            try
            {
                using (var db = OpenDbConnection())
                {
                    return db.Delete(entity);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        protected int Delete(Expression<Func<T, bool>> expression)
        {
            try
            {
                using (var db = OpenDbConnection())
                {
                    return db.Delete(expression);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        protected int DeleteById(object id)
        {
            try
            {
                using (var db = OpenDbConnection())
                {
                    return db.DeleteById<T>(id);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        protected int DeleteByIds(IEnumerable idValues)
        {
            try
            {
                using (var db = OpenDbConnection())
                {
                    return db.DeleteByIds<T>(idValues);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }

        #endregion

        #region sql支持

        protected int ExecuteSql(string sql)
        {
            try
            {
                using (var db = OpenDbConnection())
                {
                    return db.ExecuteSql(sql);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        protected int ExecuteNonQuery(string sql)
        {
            try
            {
                using (var db = OpenDbConnection())
                {
                    return db.ExecuteNonQuery(sql);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        protected void ExcuteProcedure(T entity)
        {
            try
            {
                using (var db = OpenDbConnection())
                {
                    
                        db.ExecuteProcedure(entity);
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// 执行存储过程包含一个返回值
        /// </summary>
        /// <param name="sql">sp的名称</param>
        /// <param name="inParams">参数</param>
        /// <param name="outputParam">返回的参数</param>
        /// <returns></returns>
        protected object ExecuteProcedureWithOutput(string sqlName, object inParams, string outParam)
        {
            try
            { 
                using (var db = OpenDbConnection())
                {
                    var cmd = db.SqlProc(sqlName, inParams);
                    var result = cmd.AddParam(outParam, direction: ParameterDirection.Output);
                    cmd.ExecuteNonQuery();
                    return result.Value;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="sqlName"></param>
        /// <param name="inParams"></param>
        /// <returns></returns>
        protected int ExecuteProcedureNonQuery(string sqlName, object inParams)
        {
            try
            {
                using (var db = OpenDbConnection())
                {
                    var cmd = db.SqlProc(sqlName, inParams);
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #endregion

        #region 功能函数

        /// <summary>
        /// 获取行计数
        /// </summary>
        /// <param name="async">默认异步</param>
        /// <returns></returns>
        protected long Count()
        {
            try
            {
                using (var db = OpenDbConnection())
                {
                    return db.Count<T>();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// 通过lambda表达式，获取行计数
        /// </summary>
        /// <param name="expression">默认异步</param>
        /// <param name="async"></param>
        /// <returns></returns>
        protected long Count(Expression<Func<T, bool>> expression)
        {
            try
            {
                using (var db = OpenDbConnection())
                {
                    return db.Count(expression);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        /// <summary>
        /// 通过SqlExpression lambda表达式，获取行计数
        /// </summary>
        /// <param name="expression">表达式</param>
        /// <param name="async">默认异步</param>
        /// <returns></returns>
        protected long Count(SqlExpression<T> expression)
        {
            try
            {
                using (var db = OpenDbConnection())
                {
                    return db.Count(expression);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// 通过SqlExpression lambda表达式返回行数
        /// </summary>
        /// <param name="expression">表达式</param>
        /// <param name="async">默认异步</param>
        /// <returns></returns>
        protected long RowCount(SqlExpression<T> expression)
        {
            try
            {
                using (var db = OpenDbConnection())
                {
                    return db.RowCount(expression);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// 通过sql语句返回行数
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="async">默认异步</param>
        /// <returns></returns>
        protected long RowCount(string sql)
        {
            try
            {
                using (var db = OpenDbConnection())
                {
                    return db.RowCount(sql);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        protected bool Exists(Expression<Func<T, bool>> expression)
        {
            try
            {
                using (var db = OpenDbConnection())
                {
                    return db.Exists(expression);
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        
        protected bool Exists(SqlExpression<T> expression)
        {
            try
            {
                using (var db = OpenDbConnection())
                {
                    return db.Exists(expression);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        protected bool Exists(object anonType)
        {
            try
            {
                using (var db = OpenDbConnection())
                {
                    return db.Exists<T>(anonType);
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        protected bool Exists(string sql, object anonType = null)
        {
            try
            {
                using (var db = OpenDbConnection())
                {
                    return db.Exists<T>(sql, anonType);
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }
        #endregion
    }
}
