using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WeightCollect.Models.UtilModel;

namespace WeightCollect.Models
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class UserInfo
    {
        /// <summary>
        /// Id
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 打卡用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 真实姓名
        /// </summary>
        public string ReamName { get; set; }

        /// <summary>
        /// 微信昵称
        /// </summary>
        public string WxNickName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 等级
        /// </summary>
        public Rank Rank { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 初始体重
        /// </summary>
        public double InitialWeight { get; set; }

        /// <summary>
        /// 目标体重
        /// </summary>
        public double TargetWeight { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// 入群时间
        /// </summary>
        public DateTime AddDate { get; set; }
    }
}
