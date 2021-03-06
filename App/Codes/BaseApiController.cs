﻿using System.Web.Http;

using System.Web;

namespace Models
{
    public class BaseApiController : ApiController
    {
        /// <summary>
        /// 获取当前登陆人的ID
        /// </summary>
        /// <returns></returns>
        public string CurrentPersonId
        {
            get
            {
                var account = AccountModel.GetCurrentAccount();              
                if (account != null && !string.IsNullOrWhiteSpace(account.Id))
                {  return account.Id;
                  
                }
                return string.Empty;
            }
        }
        /// <summary>
        /// 获取当前登陆人的名称
        /// </summary>
        /// <returns></returns>
        public string CurrentPerson
        {
            get
            {
                var account = AccountModel.GetCurrentAccount();
                if (account != null && !string.IsNullOrWhiteSpace(account.Name))
                {
                    return account.Name;

                }
                return string.Empty;                
            }
        } 

        
        public class GetDataParam
        {
            public string sort { get; set; }
            public string order { get; set; }
            public int page { get; set; }
            public int rows { get; set; }
            public string id { get; set; }
            public string search { get; set; }
        }
      
    }
}
