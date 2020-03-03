﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SystemManagement.Common
{
    /// <summary>
    /// 当前用户上下文
    /// </summary>
    public class UserContext
    {
        public long ID { get; set; }

        public string Account { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string RoleId { get; set; }
    }
}
