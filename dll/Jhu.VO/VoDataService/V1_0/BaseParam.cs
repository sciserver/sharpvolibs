﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Jhu.VO.VoDataService.Common;

namespace Jhu.VO.VoDataService.V1_0
{
    [XmlType(Namespace = Constants.VoDataServiceNamespaceV1_0)]
    [XmlInclude(typeof(InputParam))]
    [XmlInclude(typeof(TableParam))]
    public class BaseParam : IBaseParam
    {
        [XmlElement(Constants.TagName, Form = XmlSchemaForm.Unqualified)]
        public string Name { get; set; }

        [XmlElement(Constants.TagDescription, Form = XmlSchemaForm.Unqualified)]
        public string Description { get; set; }

        [XmlElement(Constants.TagUnit, Form = XmlSchemaForm.Unqualified)]
        public string Unit { get; set; }

        [XmlElement(Constants.TagUcd, Form = XmlSchemaForm.Unqualified)]
        public string Ucd { get; set; }
    }
}
