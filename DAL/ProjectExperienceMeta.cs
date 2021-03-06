﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Langben.DAL
{
    [MetadataType(typeof(ProjectExperienceMetadata))]//使用ProjectExperienceMetadata对ProjectExperience进行数据验证
    public partial class ProjectExperience 
    {
      
        #region 自定义属性，即由数据实体扩展的实体
        
        [Display(Name = "简历管理Id")]
        public string ResumeIdOld { get; set; }
        
        #endregion

    }
    public partial class ProjectExperienceMetadata
    {
			[ScaffoldColumn(false)]
			[Display(Name = "项目经验编号", Order = 1)]
			public object Id { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "简历管理Id", Order = 2)]
			[StringLength(36, ErrorMessage = "长度不可超过36")]
			public object ResumeId { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "开始日期", Order = 3)]
			[Required(ErrorMessage = "不能为空")]
			[DataType(System.ComponentModel.DataAnnotations.DataType.DateTime,ErrorMessage="时间格式不正确")]
			[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]

			public DateTime? BeginDate { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "结束日期", Order = 4)]
			[DataType(System.ComponentModel.DataAnnotations.DataType.DateTime,ErrorMessage="时间格式不正确")]
			[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]

			public DateTime? EndDate { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "结束日期是否至今", Order = 5)]
			[StringLength(1, ErrorMessage = "长度不可超过1")]
			public object IsNow { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "项目名称", Order = 6)]
			[Required(ErrorMessage = "不能为空")]
			[StringLength(200, ErrorMessage = "长度不可超过200")]
			public object ProjectName { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "职务", Order = 7)]
			[StringLength(200, ErrorMessage = "长度不可超过200")]
			public object Job { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "项目简述", Order = 8)]
			[StringLength(4000, ErrorMessage = "长度不可超过4000")]
			public object ProjectDescription { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "排序", Order = 9)]
			[Range(0,2147483646, ErrorMessage="数值超出范围")]
			public int? Sort { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "状态", Order = 10)]
			[StringLength(200, ErrorMessage = "长度不可超过200")]
			public object State { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "创建时间", Order = 11)]
			[DataType(System.ComponentModel.DataAnnotations.DataType.DateTime,ErrorMessage="时间格式不正确")]
			public DateTime? CreateTime { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "创建人", Order = 12)]
			[StringLength(200, ErrorMessage = "长度不可超过200")]
			public object CreatePerson { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "编辑时间", Order = 13)]
			[DataType(System.ComponentModel.DataAnnotations.DataType.DateTime,ErrorMessage="时间格式不正确")]
			public DateTime? UpdateTime { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "编辑人", Order = 14)]
			[StringLength(200, ErrorMessage = "长度不可超过200")]
			public object UpdatePerson { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "时间戳", Order = 15)]
			public object Version { get; set; }


    }
}
 

