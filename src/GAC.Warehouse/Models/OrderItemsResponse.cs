/*
 * Warehouse API
 *
 * Warehouse API
 *
 * OpenAPI spec version: 1.0.0
 * Contact: you@your-company.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class OrderItemsResponse : IEquatable<OrderItemsResponse>
    { 
        /// <summary>
        /// Gets or Sets OrderItemList
        /// </summary>
        [Required]
        [DataMember(Name="OrderItemList")]
        public OrderItemList OrderItemList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderItemsResponse {\n");
            sb.Append("  OrderItemList: ").Append(OrderItemList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((OrderItemsResponse)obj);
        }

        /// <summary>
        /// Returns true if OrderItemsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderItemsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderItemsResponse other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    OrderItemList == other.OrderItemList ||
                    OrderItemList != null &&
                    OrderItemList.Equals(other.OrderItemList)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (OrderItemList != null)
                    hashCode = hashCode * 59 + OrderItemList.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(OrderItemsResponse left, OrderItemsResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(OrderItemsResponse left, OrderItemsResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
