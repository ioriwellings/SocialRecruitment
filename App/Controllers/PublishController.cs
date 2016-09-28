﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Text;
using System.EnterpriseServices;
using System.Configuration;
using Models;
using Common;
using Langben.DAL;
using Langben.BLL;
using Langben.App.Models;
 
namespace Langben.App.Controllers
{
    /// <summary>
    /// 发布博客
    /// </summary>
    public class PublishController : BaseController
    {
        public ActionResult Edit(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return  RedirectToAction("/Acount");
            }
            else
            {
                Blog item = m_BLL.GetById(id);

                return View(item);
            }

        }
        /// <summary>
        /// 第一次加载
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
           
                return View();
           
        }
        [HttpPost]
        public string HDpic()//头像上传
        { 
            string upfile = Request.Form["name"]; //取得上传的对象名称
            System.Web.HttpPostedFileBase pstFile = Request.Files["file"];
            UploadFiles upFiles = new UploadFiles();
            string msg = upFiles.fileSaveAs(pstFile, upfile);
            return msg;
        }
        IBLL.IBlogBLL m_BLL;

        ValidationErrors validationErrors = new ValidationErrors();

        public PublishController()
            : this(new BlogBLL()) { }

        public PublishController(BlogBLL bll)
        {
            m_BLL = bll;
        }
    }
}


