using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailWmsBatchinventoryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsBatchinventoryQueryModel : AlipayObject
    {
        /// <summary>
        /// 货品编码列表
        /// </summary>
        [JsonProperty("goods_code_list")]
        [XmlArray("goods_code_list")]
        [XmlArrayItem("string")]
        public List<string> GoodsCodeList { get; set; }

        /// <summary>
        /// 货品类型，ZP("正品"),CC("残次"),JS("机损"), XS("箱损"),ZT("在途库存")
        /// </summary>
        [JsonProperty("inventory_type")]
        [XmlElement("inventory_type")]
        public string InventoryType { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [JsonProperty("warehouse_code")]
        [XmlElement("warehouse_code")]
        public string WarehouseCode { get; set; }
    }
}
