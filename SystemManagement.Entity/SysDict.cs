﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SystemManagement.Entity
{
	/// <summary>
	/// 字典
	/// </summary>
	[Table("SysDict")]
	[Description("字典")]
	public class SysDict : BaseEntity<long>
	{		
		[StringLength(255)]
		[Column("Name")]
		public string Name { get; set; }

		[StringLength(255)]
		[Column("Num")]
		public string Num { get; set; }

		[Column("Pid")]
		public long? Pid { get; set; }

		[StringLength(255)]
		[Column("Tips")]
		public string Tips { get; set; }
	}
}
