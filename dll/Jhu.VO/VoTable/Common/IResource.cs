﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Jhu.VO.VoTable.Common
{
    public interface IResource
    {
        IAnyText Description { get; set; }
        ElementList<IInfo> InfoList1 { get; }
        ElementList<ICoordinateSystem> CoosysList { get; }
        ElementList<IGroup> GroupList { get; }
        ElementList<IParam> ParamList { get; }
        ElementList<ILink> LinkList { get; }
        ElementList<IInfo> InfoList2 { get; }

        string Name { get; set; }
        string ID { get; set; }
        string Utype { get; set; }
        string Type { get; set; }
        List<XmlAttribute> Attributes { get; }
    }
}