using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WeightCollect.Models
{
    /// <summary>
    /// 记录体重信息
    /// </summary>
    public class Record
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
        /// 今日体重
        /// </summary>
        public double TodayWeight { get; set; }

        /// <summary>
        /// 打卡日期
        /// </summary>
        public DateTime RecordDate { get; set; }

        /// <summary>
        /// 打卡感言
        /// </summary>
        public string RecordThought { get; set; }

        /// <summary>
        /// 早饭
        /// </summary>
        public string Breakfast { get; set; }

        /// <summary>
        /// 午饭
        /// </summary>
        public string Lunch { get; set; }

        /// <summary>
        /// 晚饭
        /// </summary>
        public string Dinner { get; set; }

        /// <summary>
        /// 加餐1
        /// </summary>
        public string ExtraMeal1 { get; set; }

        /// <summary>
        /// 加餐2
        /// </summary>
        public string ExtraMeal2 { get; set; }

        /// <summary>
        /// 加餐3
        /// </summary>
        public string ExtraMeal3 { get; set; }

        /// <summary>
        /// 加餐4
        /// </summary>
        public string ExtraMeal4 { get; set; }

        /// <summary>
        /// 加餐5
        /// </summary>
        public string ExtraMeal5 { get; set; }
    }
}
