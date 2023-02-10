using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace UniversityManagementPortal.Mapper
{
    public static class MapperExtension
    {
        public static T CopyTo<S, T>(this S obj)
        {
            try
            {
                return AutoMapper.Mapper.Map<S, T>(obj);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// Copies to.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">The object.</param>
        /// <returns>T.</returns>
        public static T CopyTo<T>(this object obj)
        {
            try
            {
                //var mapper = cfg.CreateMapper();
                return AutoMapper.Mapper.Map<T>(obj);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
