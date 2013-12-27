using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarathonSolution.Models.EnumType
{
    public enum RaceType
    {
        /// <summary>
        /// 马拉松
        /// </summary>
        Marathon=0,
        /// <summary>
        /// 越野
        /// </summary>
        CrossCountry=1,
        /// <summary>
        /// 超级马拉松
        /// </summary>
        SuperMarathon=2,
        /// <summary>
        /// 铁人三项
        /// </summary>
        Trithlon=3,
        /// <summary>
        /// 其他类型
        /// </summary>
        Other=4
    }
}