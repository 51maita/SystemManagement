﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SystemManagement.Dto
{
	/// <summary>
	/// 菜单-角色关联
	/// </summary>
	public class SysRelationDto
	{
		/// <summary>
		/// 关联ID
		/// </summary>
		public long ID { get; set; }

		/// <summary>
		/// 菜单ID
		/// </summary>
		public long? MenuId { get; set; }

		/// <summary>
		/// 角色ID
		/// </summary>
		public long? RoleId { get; set; }
	}
}
