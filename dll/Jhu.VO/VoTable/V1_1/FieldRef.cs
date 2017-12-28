﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Jhu.VO.VoTable.V1_1
{
    [XmlType(Namespace = Constants.NamespaceVoTableV1_1)]
    [XmlRoot(Constants.TagFieldRef, Namespace = Constants.NamespaceVoTableV1_1)]
    public class FieldRef
    {
        [XmlAttribute(Constants.AttributeRef)]
        public string Ref { get; set; }
    }
}