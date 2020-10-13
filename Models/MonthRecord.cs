using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WeightCollect.Models
{
    /// <summary>
    /// 月打卡目标记录，每个用户每月只能有一条生效的目标记录
    /// </summary>
    public class MonthRecord
    {
        /// <summary>
        /// Id
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 用户Id
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// 年
        /// </summary>
        public string Year { get; set; }

        /// <summary>
        /// 月
        /// </summary>
        public string Month { get; set; }

        /// <summary>
        /// 本月目标
        /// </summary>
        public string Goal { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 要记录的年月日记录
        /// </summary>
        public DateTime RecordTime { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 是否生效。true生效，false不生效
        /// </summary>
        public bool IsEffect { get; set; }
    }
}
