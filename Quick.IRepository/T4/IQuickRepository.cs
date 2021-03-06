﻿/* ==============================================================================
* 命名空间：Quick.IRepository
* 类 名 称：IQuickRepository
* 创 建 者：Qing
* 创建时间：2018-05-28 15:07:43
* CLR 版本：4.0.30319.42000
* 保存的文件名：IQuickRepository
* 文件版本：V1.0.0.0
*
* 功能描述：N/A 
*
* 修改历史：
*
*
* ==============================================================================
*         CopyRight @ 班纳工作室 2018. All rights reserved
* ==============================================================================*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quick.Data.Entities.Sys;

namespace Quick.IRepository
{
    /// <summary>
    /// Interview数据库访问接口
    /// </summary>
	public partial interface IInterviewRepository : IBaseRepository<Interview>
	{
		
	}

    /// <summary>
    /// InterviewDetail数据库访问接口
    /// </summary>
	public partial interface IInterviewDetailRepository : IBaseRepository<InterviewDetail>
	{
		
	}

    /// <summary>
    /// LoginRecord数据库访问接口
    /// </summary>
	public partial interface ILoginRecordRepository : IBaseRepository<LoginRecord>
	{
		
	}

    /// <summary>
    /// SystemSetting数据库访问接口
    /// </summary>
	public partial interface ISystemSettingRepository : IBaseRepository<SystemSetting>
	{
		
	}

    /// <summary>
    /// UserInfo数据库访问接口
    /// </summary>
	public partial interface IUserInfoRepository : IBaseRepository<UserInfo>
	{
		
	}

}