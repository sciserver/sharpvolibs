﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Jhu.VO.VoTable.V1_3
{
    [XmlType(Namespace = Constants.VOTableNamespaceV1_3)]
    public class Binary
    {
        [XmlElement(Constants.TagStream, Form = XmlSchemaForm.Unqualified)]
        public Stream Stream { get; set; }
    }
}
