﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CSMEntity.Entitys
{
    public class Cookbook
    {
        [Key]
        public Guid CookbookId { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Desc { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 库存
        /// </summary>
        public int Inventory { get; set; }
        /// <summary>
        /// 食材
        /// </summary>
        [JsonIgnore]
        public List<CookbookAndFood> CookbookAndFoods { get; set; }
        /// <summary>
        /// 菜谱
        /// </summary>
        [JsonIgnore]
        public List<PackageAndCookbook> PackageAndCookbooks { get; set; }
        /// <summary>
        /// 分类
        /// </summary>
        [JsonIgnore]
        public List<CookbookAndCategory> CookbookAndCategorys { get; set; }
    }

    /// <summary>
    /// 食材用量
    /// </summary>
    public class CookbookAndFood
    {
        public Guid FoodId { get; set; }
        public Food Food { get; set; }

        public Guid CookbookId { get; set; }
        public Cookbook Cookbook { get; set; }
        /// <summary>
        /// 使用量
        /// </summary>
        public int Dose { get; set; }
    }
    /// <summary>
    /// 分类
    /// </summary>
    public class CookbookAndCategory
    {
        public Guid CookbookId { get; set; }
        public Cookbook Cookbook { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
    public class CookbookImages : Images
    {
        [Key]
        public int CookbookImagesId { get; set; }

        [ForeignKey("Cookbook")]
        public Guid CookbookId { get; set; }
        [JsonIgnore]
        public Cookbook Cookbook{ get; set; }
    }


}
