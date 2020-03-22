﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SystemManagement.Dto
{
    /// <summary>
    /// 业务节点
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T>
    {
        /// <summary>
        /// 节点ID
        /// </summary>
        public T ID { get; set; }

        /// <summary>
        /// 父级ID
        /// </summary>
        public T PID { get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 是否选中
        /// </summary>
        public bool Checked { get; set; }

        /// <summary>
        /// 子节点
        /// </summary>
        public List<Node<T>> Children { get; private set; } = new List<Node<T>>();
    }
}
