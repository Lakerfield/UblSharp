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
    /// A document used to initiate a return of goods. The producer is requesting the return of products that are not selling well, either to use in other places or to free up rack or shelf space.
    /// <para />ComponentType: ABIE
    /// <para />DictionaryEntryName: Instruction For Returns. Details
    /// <para />ObjectClass: Instruction For Returns
    /// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("InstructionForReturns", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:InstructionForReturns-2")]
    [System.Xml.Serialization.XmlRootAttribute("InstructionForReturns", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:InstructionForReturns-2", IsNullable=false)]
    public partial class InstructionForReturnsType : BaseDocument
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
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public System.Collections.Generic.List<DocumentReferenceType> @__DocumentReference;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("SellerSupplierParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SupplierPartyType @__SellerSupplierParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("RetailerCustomerParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerPartyType @__RetailerCustomerParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ManufacturerParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType @__ManufacturerParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Shipment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ShipmentType @__Shipment;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("InstructionForReturnsLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public System.Collections.Generic.List<InstructionForReturnsLineType> @__InstructionForReturnsLine;
        
        /// <summary>
        /// Indicates whether this document is a copy (true) or not (false).
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Instruction For Returns. Copy_ Indicator. Indicator
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Instruction For Returns
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
        /// <para />DictionaryEntryName: Instruction For Returns. Issue Date. Date
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Instruction For Returns
        /// <para />PropertyTerm: Issue Date
        /// <para />RepresentationTerm: Date
        /// <para />DataType: Date. Type
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
        /// <para />DictionaryEntryName: Instruction For Returns. Issue Time. Time
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Instruction For Returns
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
        /// <para />DictionaryEntryName: Instruction For Returns. Note. Text
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Instruction For Returns
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
        /// A reference to another document associated with this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Instruction For Returns. Document Reference
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Instruction For Returns
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
        /// The seller.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Instruction For Returns. Seller_ Supplier Party. Supplier Party
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Instruction For Returns
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
        /// The retailer.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Instruction For Returns. Retailer_ Customer Party. Customer Party
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Instruction For Returns
        /// <para />PropertyTermQualifier: Retailer
        /// <para />PropertyTerm: Customer Party
        /// <para />AssociatedObjectClass: Customer Party
        /// <para />RepresentationTerm: Customer Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public CustomerPartyType RetailerCustomerParty
        {
            get
            {
                if (__RetailerCustomerParty == null) { __RetailerCustomerParty = new CustomerPartyType(); }
                return __RetailerCustomerParty;
            }
            set
            {
                __RetailerCustomerParty = value;
            }
        }

        /// <summary>
        /// The manufacturer.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Instruction For Returns. Manufacturer_ Party. Party
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Instruction For Returns
        /// <para />PropertyTermQualifier: Manufacturer
        /// <para />PropertyTerm: Party
        /// <para />AssociatedObjectClass: Party
        /// <para />RepresentationTerm: Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public PartyType ManufacturerParty
        {
            get
            {
                if (__ManufacturerParty == null) { __ManufacturerParty = new PartyType(); }
                return __ManufacturerParty;
            }
            set
            {
                __ManufacturerParty = value;
            }
        }

        /// <summary>
        /// The shipment.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Instruction For Returns. Shipment
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Instruction For Returns
        /// <para />PropertyTerm: Shipment
        /// <para />AssociatedObjectClass: Shipment
        /// <para />RepresentationTerm: Shipment
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public ShipmentType Shipment
        {
            get
            {
                if (__Shipment == null) { __Shipment = new ShipmentType(); }
                return __Shipment;
            }
            set
            {
                __Shipment = value;
            }
        }

        /// <summary>
        /// A line providing details about one type of article to be returned.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Instruction For Returns. Instruction For Returns Line
        /// <para />Cardinality: 1..n
        /// <para />ObjectClass: Instruction For Returns
        /// <para />PropertyTerm: Instruction For Returns Line
        /// <para />AssociatedObjectClass: Instruction For Returns Line
        /// <para />RepresentationTerm: Instruction For Returns Line
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<InstructionForReturnsLineType> InstructionForReturnsLine
        {
            get
            {
                if (__InstructionForReturnsLine == null) { __InstructionForReturnsLine = new System.Collections.Generic.List<InstructionForReturnsLineType>(); }
                return __InstructionForReturnsLine;
            }
            set
            {
                __InstructionForReturnsLine = value;
            }
        }

    }
}