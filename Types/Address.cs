using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;
using MemberSuite.SDK.Utilities;

namespace MemberSuite.SDK.Types
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [DataContract]
    public class Address : IComparable 
    {


        /// <summary>
        /// Gets or sets the company, if this address belongs to an individual.
        /// </summary>
        /// <value>The company.</value>
        [DataMember]
        public virtual string Company { get; set; }

        /// <summary>
        /// Gets or sets Line 1 of the address
        /// </summary>
        /// <value>The line1.</value>
        [DataMember]
        public virtual string Line1 { get; set; }

        /// <summary>
        /// Gets or sets Line 2 of the address
        /// </summary>
        /// <value>The line2.</value>
        [DataMember]
        public virtual string Line2 { get; set; }

        /// <summary>
        /// Gets or sets Line 3 of the address
        /// </summary>
        /// <value>The line3.</value>
      //  public virtual  string Line3 { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>The city.</value>
        [DataMember]
        public virtual string City { get; set; }
        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>The state.</value>
        [DataMember]
        public virtual string State { get; set; }

        /// <summary>
        /// Gets or sets the postal code.
        /// </summary>
        /// <value>The postal code.</value>
        [DataMember]
        public virtual string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>The country.</value>
        [DataMember]
        public virtual string Country { get; set; }

        [DataMember]
        public virtual string County { get; set; }

        /// <summary>
        /// Gets or sets the congressional district.
        /// </summary>
        /// <value>The congressional district.</value>
        [DataMember]
        public virtual string CongressionalDistrict { get; set; }

        [DataMember]
        public DateTime? CASSCertificationDate { get; set; }

        [DataMember]
        public string CASSCertificationErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets the carrier route.
        /// </summary>
        /// <value>The carrier route.</value>
        [DataMember]
        public string CarrierRoute { get; set; }

        /// <summary>
        /// Gets or sets the delivery point code.
        /// </summary>
        /// <value>The delivery point code.</value>
        [DataMember]
        public string DeliveryPointCode { get; set; }

        /// <summary>
        /// Gets or sets the delivery point check digit.
        /// </summary>
        /// <value>The delivery point check digit.</value>
        [DataMember]
        public string DeliveryPointCheckDigit { get; set; }

        /// <summary>
        /// Gets or sets the Geocode Lat value.
        /// </summary>
        /// <value>The Geocode Lat value.</value>
        [DataMember]
        public decimal? GeocodeLat { get; set; }

        /// <summary>
        /// Gets or sets the Geocode Long value.
        /// </summary>
        /// <value>The Geocode Long value.</value>
        [DataMember]
        public decimal? GeocodeLong { get; set; }

        /// <summary>
        /// Gets or sets the date address was last geocoded.
        /// </summary>
        /// <value>The date address was last geocoded.</value>
        [DataMember]
        public DateTime? LastGeocodeDate { get; set; }


        /// <summary>
        /// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
        /// </summary>
        /// <param name="obj">The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>.</param>
        /// <returns>
        /// true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
        /// </returns>
        /// <exception cref="T:System.NullReferenceException">
        /// The <paramref name="obj"/> parameter is null.
        /// </exception>
        public override bool Equals(object obj)
        {
            Address a2 = obj as Address;

            if ( a2 == null ) // either it's null or not an address
                return false;

            return
                Company == a2.Company &&
                Line1 == a2.Line1 &&
                Line2 == a2.Line2 &&
                
                City == a2.City &&
                State == a2.State &&
                Country == a2.Country &&
                PostalCode == a2.PostalCode;

        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        
        /// <summary>
        /// Generates an HTMl friendly address
        /// </summary>
        /// <returns></returns>
        public string ToHtmlString()
        {
            StringBuilder sb = new StringBuilder();

            if (!String.IsNullOrEmpty(Company ))
                sb.AppendFormat("{0}<BR/>", Company );

            if ( ! String.IsNullOrEmpty( Line1 ) )
                sb.AppendFormat( "{0}<BR/>", Line1 );

            if (!String.IsNullOrEmpty(Line2))
                sb.AppendFormat("{0}<BR/>", Line2);

            //if (!String.IsNullOrEmpty(Line3))
            //    sb.AppendFormat("{0}<BR/>", Line3);

            if (!String.IsNullOrEmpty(City))
                sb.AppendFormat("{0}, ", City );

            if (!String.IsNullOrEmpty(State ))
                sb.AppendFormat("{0} ", State );

            if (!String.IsNullOrEmpty(PostalCode ))
                sb.AppendFormat("{0} ", PostalCode  );

            if (!String.IsNullOrEmpty(Country ))
                sb.AppendFormat("{0} ", Country );

            return sb.ToString();
        }

        /// <summary>
        /// Generates an HTMl friendly address
        /// </summary>
        /// <returns></returns>
        public string ToNonHtmlString()
        {
            StringBuilder sb = new StringBuilder();

            if (!String.IsNullOrEmpty(Company))
                sb.AppendFormat("{0}\r\n", Company);

            if (!String.IsNullOrEmpty(Line1))
                sb.AppendFormat("{0}\r\n", Line1);

            if (!String.IsNullOrEmpty(Line2))
                sb.AppendFormat("{0}\r\n", Line2);

            //if (!String.IsNullOrEmpty(Line3))
            //    sb.AppendFormat("{0}\r\n", Line3);

            if (!String.IsNullOrEmpty(City))
                sb.AppendFormat("{0}, ", City);

            if (!String.IsNullOrEmpty(State))
                sb.AppendFormat("{0} ", State);

            if (!String.IsNullOrEmpty(PostalCode))
                sb.AppendFormat("{0} ", PostalCode);

            if (!String.IsNullOrEmpty(Country))
                sb.AppendFormat("{0} ", Country);

            return sb.ToString();
        }

        public string ToRawPropertyString()
        {
            StringBuilder sb = new StringBuilder();
            List<PropertyInfo> props = new List<PropertyInfo>( GetType().GetProperties() );

            // important - properties need to be sorted, b/c GetProperties don't always return properties in the same order
            props.Sort((x, y) => x.Name.CompareTo(y.Name));
            
            foreach (var pi in props)
                sb.AppendLine(string.Format("{0}: {1}", pi.Name, pi.GetValue(this, null)));

            return sb.ToString();
        }
        /// <summary>
        /// Gets the values.
        /// </summary>
        /// <returns></returns>
        public Dictionary<string,string> GetValues()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            foreach (var pi in GetType().GetProperties())
            {
                dic.Add(pi.Name, Convert.ToString(pi.GetValue(this, null)));
            }

            return dic;
        }





        public bool IsEmpty()
        {
            return
                string.IsNullOrWhiteSpace(Line1) &&
               string.IsNullOrWhiteSpace(Line2) &&
                string.IsNullOrWhiteSpace(City) &&
                string.IsNullOrWhiteSpace(State) &&
                string.IsNullOrWhiteSpace(PostalCode);   // deliberately leaving out the country here
        }

        #region IComparable Members

        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;

            return ToRawPropertyString().CompareTo(((Address)obj).ToRawPropertyString());
        }

        #endregion
    }
}