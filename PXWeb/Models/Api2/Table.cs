/*
 * PxApi
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2.0
 * 
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

namespace PxWeb.Models.Api2
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Table : FolderContentItem, IEquatable<Table>
    {
        /// <summary>
        /// Gets or Sets Tags
        /// </summary>

        [DataMember(Name = "tags")]
        public List<string> Tags { get; set; }

        /// <summary>
        /// For treeNodeType \&quot;table\&quot;
        /// </summary>
        /// <value>For treeNodeType \&quot;table\&quot;</value>

        [DataMember(Name = "updated")]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// Mostly for internal use. Which category table belongs to. internal, official, private or section. I, O, P, S
        /// </summary>
        /// <value>Mostly for internal use. Which category table belongs to. internal, official, private or section. I, O, P, S</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum CategoryEnum
        {
            /// <summary>
            /// Enum InternalEnum for internal
            /// </summary>
            [EnumMember(Value = "internal")]
            InternalEnum = 0,
            /// <summary>
            /// Enum OfficialEnum for official
            /// </summary>
            [EnumMember(Value = "official")]
            OfficialEnum = 1,
            /// <summary>
            /// Enum PrivateEnum for private
            /// </summary>
            [EnumMember(Value = "private")]
            PrivateEnum = 2,
            /// <summary>
            /// Enum SectionEnum for section
            /// </summary>
            [EnumMember(Value = "section")]
            SectionEnum = 3
        }

        /// <summary>
        /// Mostly for internal use. Which category table belongs to. internal, official, private or section. I, O, P, S
        /// </summary>
        /// <value>Mostly for internal use. Which category table belongs to. internal, official, private or section. I, O, P, S</value>

        [DataMember(Name = "category")]
        public CategoryEnum? Category { get; set; }

        /// <summary>
        /// Links to ...
        /// </summary>
        /// <value>Links to ...</value>

        [DataMember(Name = "links")]
        public List<Link> Links { get; set; }

        /// <summary>
        /// List of varibles name
        /// </summary>
        /// <value>List of varibles name</value>

        [DataMember(Name = "variablesName")]
        public List<string> VariablesName { get; set; }

        /// <summary>
        /// First period
        /// </summary>
        /// <value>First period</value>

        [DataMember(Name = "firstPeriod")]
        public string FirstPeriod { get; set; }

        /// <summary>
        /// Last period
        /// </summary>
        /// <value>Last period</value>

        [DataMember(Name = "lastPeriod")]
        public string LastPeriod { get; set; }

        /// <summary>
        /// Gets or Sets Discontinued
        /// </summary>

        [DataMember(Name = "discontinued")]
        public bool? Discontinued { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Table {\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  VariablesName: ").Append(VariablesName).Append("\n");
            sb.Append("  FirstPeriod: ").Append(FirstPeriod).Append("\n");
            sb.Append("  LastPeriod: ").Append(LastPeriod).Append("\n");
            sb.Append("  Discontinued: ").Append(Discontinued).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public new string ToJson()
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
            return obj.GetType() == GetType() && Equals((Table)obj);
        }

        /// <summary>
        /// Returns true if Table instances are equal
        /// </summary>
        /// <param name="other">Instance of Table to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Table other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Tags == other.Tags ||
                    Tags != null &&
                    Tags.SequenceEqual(other.Tags)
                ) &&
                (
                    Updated == other.Updated ||
                    Updated != null &&
                    Updated.Equals(other.Updated)
                ) &&
                (
                    Category == other.Category ||
                    Category != null &&
                    Category.Equals(other.Category)
                ) &&
                (
                    Links == other.Links ||
                    Links != null &&
                    Links.SequenceEqual(other.Links)
                ) &&
                (
                    VariablesName == other.VariablesName ||
                    VariablesName != null &&
                    VariablesName.SequenceEqual(other.VariablesName)
                ) &&
                (
                    FirstPeriod == other.FirstPeriod ||
                    FirstPeriod != null &&
                    FirstPeriod.Equals(other.FirstPeriod)
                ) &&
                (
                    LastPeriod == other.LastPeriod ||
                    LastPeriod != null &&
                    LastPeriod.Equals(other.LastPeriod)
                ) &&
                (
                    Discontinued == other.Discontinued ||
                    Discontinued != null &&
                    Discontinued.Equals(other.Discontinued)
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
                if (Tags != null)
                    hashCode = hashCode * 59 + Tags.GetHashCode();
                if (Updated != null)
                    hashCode = hashCode * 59 + Updated.GetHashCode();
                if (Category != null)
                    hashCode = hashCode * 59 + Category.GetHashCode();
                if (Links != null)
                    hashCode = hashCode * 59 + Links.GetHashCode();
                if (VariablesName != null)
                    hashCode = hashCode * 59 + VariablesName.GetHashCode();
                if (FirstPeriod != null)
                    hashCode = hashCode * 59 + FirstPeriod.GetHashCode();
                if (LastPeriod != null)
                    hashCode = hashCode * 59 + LastPeriod.GetHashCode();
                if (Discontinued != null)
                    hashCode = hashCode * 59 + Discontinued.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(Table left, Table right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Table left, Table right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
