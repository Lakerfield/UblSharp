// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Manual changes to this file will be overwritten if the code is regenerated.
//
// </auto-generated>
//------------------------------------------------------------------------------
namespace UblSharp
{
    using UnqualifiedDataTypes;
    using CommonAggregateComponents;
    using CommonExtensionComponents;
    
    
    /// <summary>
    /// A document used to request product activity, forecast, or performance data.
    /// <para />ComponentType: ABIE
    /// <para />DictionaryEntryName: Item Information Request. Details
    /// <para />ObjectClass: Item Information Request
    /// <para />AlternativeBusinessTerms: Item Information Request
    /// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ItemInformationRequest", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:ItemInformationRequest-2")]
    [System.Xml.Serialization.XmlRootAttribute("ItemInformationRequest", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:ItemInformationRequest-2", IsNullable=false)]
    public partial class ItemInformationRequestType : BaseDocument
    {
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("CopyIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType @__CopyIndicator;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("IssueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType @__IssueDate;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("IssueTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeType @__IssueTime;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public System.Collections.Generic.List<TextType> @__Note;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Period", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PeriodType @__Period;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public System.Collections.Generic.List<DocumentReferenceType> @__DocumentReference;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("SenderParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType @__SenderParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ReceiverParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType @__ReceiverParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("BuyerCustomerParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerPartyType @__BuyerCustomerParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("SellerSupplierParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SupplierPartyType @__SellerSupplierParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ItemInformationRequestLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public System.Collections.Generic.List<ItemInformationRequestLineType> @__ItemInformationRequestLine;
        
        /// <summary>
        /// Indicates whether this document is a copy (true) or not (false).
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Item Information Request. Copy_ Indicator. Indicator
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Item Information Request
        /// <para />PropertyTermQualifier: Copy
        /// <para />PropertyTerm: Indicator
        /// <para />RepresentationTerm: Indicator
        /// <para />DataType: Indicator. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public IndicatorType CopyIndicator
        {
            get
            {
                if (__CopyIndicator == null) { __CopyIndicator = new IndicatorType(); }
                return __CopyIndicator;
            }
            set
            {
                __CopyIndicator = value;
            }
        }

        /// <summary>
        /// The date, assigned by the sender, on which this document was issued.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Item Information Request. Issue Date. Date
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Item Information Request
        /// <para />PropertyTerm: Issue Date
        /// <para />RepresentationTerm: Date
        /// <para />DataType: Date. Type
        /// <para />AlternativeBusinessTerms: Item Information Request Date
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public DateType IssueDate
        {
            get
            {
                if (__IssueDate == null) { __IssueDate = new DateType(); }
                return __IssueDate;
            }
            set
            {
                __IssueDate = value;
            }
        }

        /// <summary>
        /// The time, assigned by the sender, at which this document was issued.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Item Information Request. Issue Time. Time
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Item Information Request
        /// <para />PropertyTerm: Issue Time
        /// <para />RepresentationTerm: Time
        /// <para />DataType: Time. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public TimeType IssueTime
        {
            get
            {
                if (__IssueTime == null) { __IssueTime = new TimeType(); }
                return __IssueTime;
            }
            set
            {
                __IssueTime = value;
            }
        }

        /// <summary>
        /// Free-form text pertinent to this document, conveying information that is not contained explicitly in other structures.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Item Information Request. Note. Text
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Item Information Request
        /// <para />PropertyTerm: Note
        /// <para />RepresentationTerm: Text
        /// <para />DataType: Text. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<TextType> Note
        {
            get
            {
                if (__Note == null) { __Note = new System.Collections.Generic.List<TextType>(); }
                return __Note;
            }
            set
            {
                __Note = value;
            }
        }

        /// <summary>
        /// The period of time to which the Item Information Request applies.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Item Information Request. Period
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Item Information Request
        /// <para />PropertyTerm: Period
        /// <para />AssociatedObjectClass: Period
        /// <para />RepresentationTerm: Period
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public PeriodType Period
        {
            get
            {
                if (__Period == null) { __Period = new PeriodType(); }
                return __Period;
            }
            set
            {
                __Period = value;
            }
        }

        /// <summary>
        /// A reference to another document associated with this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Item Information Request. Document Reference
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Item Information Request
        /// <para />PropertyTerm: Document Reference
        /// <para />AssociatedObjectClass: Document Reference
        /// <para />RepresentationTerm: Document Reference
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<DocumentReferenceType> DocumentReference
        {
            get
            {
                if (__DocumentReference == null) { __DocumentReference = new System.Collections.Generic.List<DocumentReferenceType>(); }
                return __DocumentReference;
            }
            set
            {
                __DocumentReference = value;
            }
        }

        /// <summary>
        /// The buyer.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Item Information Request. Sender_ Party. Party
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Item Information Request
        /// <para />PropertyTermQualifier: Sender
        /// <para />PropertyTerm: Party
        /// <para />AssociatedObjectClass: Party
        /// <para />RepresentationTerm: Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public PartyType SenderParty
        {
            get
            {
                if (__SenderParty == null) { __SenderParty = new PartyType(); }
                return __SenderParty;
            }
            set
            {
                __SenderParty = value;
            }
        }

        /// <summary>
        /// The seller.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Item Information Request. Receiver_ Party. Party
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Item Information Request
        /// <para />PropertyTermQualifier: Receiver
        /// <para />PropertyTerm: Party
        /// <para />AssociatedObjectClass: Party
        /// <para />RepresentationTerm: Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public PartyType ReceiverParty
        {
            get
            {
                if (__ReceiverParty == null) { __ReceiverParty = new PartyType(); }
                return __ReceiverParty;
            }
            set
            {
                __ReceiverParty = value;
            }
        }

        /// <summary>
        /// The buyer.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Item Information Request. Buyer_ Customer Party. Customer Party
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Item Information Request
        /// <para />PropertyTermQualifier: Buyer
        /// <para />PropertyTerm: Customer Party
        /// <para />AssociatedObjectClass: Customer Party
        /// <para />RepresentationTerm: Customer Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public CustomerPartyType BuyerCustomerParty
        {
            get
            {
                if (__BuyerCustomerParty == null) { __BuyerCustomerParty = new CustomerPartyType(); }
                return __BuyerCustomerParty;
            }
            set
            {
                __BuyerCustomerParty = value;
            }
        }

        /// <summary>
        /// The seller.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Item Information Request. Seller_ Supplier Party. Supplier Party
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Item Information Request
        /// <para />PropertyTermQualifier: Seller
        /// <para />PropertyTerm: Supplier Party
        /// <para />AssociatedObjectClass: Supplier Party
        /// <para />RepresentationTerm: Supplier Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public SupplierPartyType SellerSupplierParty
        {
            get
            {
                if (__SellerSupplierParty == null) { __SellerSupplierParty = new SupplierPartyType(); }
                return __SellerSupplierParty;
            }
            set
            {
                __SellerSupplierParty = value;
            }
        }

        /// <summary>
        /// A line requesting information regarding an item of sale.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Item Information Request. Item Information Request Line
        /// <para />Cardinality: 1..n
        /// <para />ObjectClass: Item Information Request
        /// <para />PropertyTerm: Item Information Request Line
        /// <para />AssociatedObjectClass: Item Information Request Line
        /// <para />RepresentationTerm: Item Information Request Line
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<ItemInformationRequestLineType> ItemInformationRequestLine
        {
            get
            {
                if (__ItemInformationRequestLine == null) { __ItemInformationRequestLine = new System.Collections.Generic.List<ItemInformationRequestLineType>(); }
                return __ItemInformationRequestLine;
            }
            set
            {
                __ItemInformationRequestLine = value;
            }
        }

    }
}