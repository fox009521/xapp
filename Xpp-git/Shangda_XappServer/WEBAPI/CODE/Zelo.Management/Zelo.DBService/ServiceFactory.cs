using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zelo.DBModel;

namespace Zelo.DBService
{
    /// <summary>
    /// 服务工厂类
    /// </summary>
    public static class ServiceFactory
    {
        private static Dictionary<TokenType, IUserService> userServiceDictionary = new Dictionary<TokenType, IUserService>();
        
        
        /// <summary>
        /// 通过TokenType来获取不同的UserService
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static IUserService GetUserService(TokenType type)
        {

            IUserService service = null;
            if (!userServiceDictionary.ContainsKey(type))
            {
                switch (type)
                {
                    case TokenType.Doctor:
                        {
                            service = new DoctorService();
                        }; break;
                    case TokenType.Patient:
                        {
                            service = new PatientService();
                        }; break;
                }
                userServiceDictionary.Add(type, service);

            }
         
            return userServiceDictionary[type];
        }



        private static Dictionary<Type, BaseService> serviceDictionary = new Dictionary<Type, BaseService>();


        /// <summary>
        /// 获取Service
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T GetService<T>()
            where T:BaseService
        {
            Type typeParameterType = typeof(T);
            if (!serviceDictionary.ContainsKey(typeParameterType))
            {

                serviceDictionary[typeParameterType]= (T)Activator.CreateInstance(typeParameterType, null);
            }

            return (T)serviceDictionary[typeParameterType];
        }

        /// <summary>
        /// 获取Service
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T GetService<T>(User user)
            where T : BaseService
        {
            Type typeParameterType = typeof(T);
            if (!serviceDictionary.ContainsKey(typeParameterType))
            {

                serviceDictionary[typeParameterType] = (T)Activator.CreateInstance(typeParameterType, null);
            }
            serviceDictionary[typeParameterType].CurrentUser = user;
            return (T)serviceDictionary[typeParameterType];
        }




    }
}
