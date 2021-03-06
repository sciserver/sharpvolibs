﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Jhu.VO.VoTable.Common;

namespace Jhu.VO.VoTable.V1_1
{
    [XmlType(Namespace = Constants.NamespaceVoTableV1_1)]
    [XmlRoot(Constants.TagParam, Namespace = Constants.NamespaceVoTableV1_1)]
    public class Param : IField, IParam
    {
        [XmlElement(Constants.TagDescription)]
        public AnyText Description { get; set; }

        [XmlIgnore]
        IAnyText IField.Description
        {
            get { return Description; }
            set { Description = (AnyText)value; }
        }

        [XmlElement(Constants.TagValues)]
        public Values Values { get; set; }

        [XmlIgnore]
        IValues IField.Values
        {
            get { return Values; }
            set { Values = (Values)value; }
        }

        [XmlElement(Constants.TagLink)]
        public List<Link> LinkList { get; set; }

        [XmlAttribute(Constants.AttributeID)]
        public string ID { get; set; }

        [XmlAttribute(Constants.AttributeUnit)]
        public string Unit { get; set; }

        [XmlAttribute(Constants.AttributeDatatype)]
        public string Datatype { get; set; }

        [XmlAttribute(Constants.AttributePrecision)]
        public string Precision { get; set; }

        [XmlAttribute(Constants.AttributeWidth)]
        public string Width { get; set; }

        [XmlAttribute(Constants.AttributeRef)]
        public string Ref { get; set; }

        [XmlAttribute(Constants.AttributeName)]
        public string Name { get; set; }

        [XmlAttribute(Constants.AttributeUcd)]
        public string Ucd { get; set; }

        [XmlAttribute(Constants.AttributeUType)]
        public string UType { get; set; }
        
        [XmlAttribute(Constants.AttributeValue)]
        public string Value { get; set; }

        [XmlAttribute(Constants.AttributeArraySize)]
        public string Arraysize { get; set; }
    }
}
