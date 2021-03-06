﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jhu.VO.Vosi
{
    [TestClass]
    public class VosiElementsTest : TestClassBase
    {
        private T ReadElementHelper<T>(string xml)
        {
            var s = new XmlSerializer(typeof(T));
            s.UnknownNode += S_UnknownNode;

            var settings = new XmlReaderSettings()
            {
                
            };
            var r = new VoXmlReader(XmlReader.Create(new StringReader(xml)));
            return (T)s.Deserialize(r);
        }

        private void S_UnknownNode(object sender, XmlNodeEventArgs e)
        {
        }
        
        [TestMethod]
        public void AvailabilityVizierTest()
        {
            string path = GetTestFilePath(@"test\files\vosi\vizier_availability.xml");
            var xml = File.ReadAllText(path);
            var e = ReadElementHelper<VO.Vosi.Availability.V1_0.Availability>(xml);

            Assert.IsTrue(e.Available);
        }

        [TestMethod]
        public void AvailabilityGaiaTest()
        {
            string path = GetTestFilePath(@"test\files\vosi\gaia_availability.xml");
            var xml = File.ReadAllText(path);
            var e = ReadElementHelper<VO.Vosi.Availability.V1_0.Availability>(xml);

            Assert.IsTrue(e.Available);
        }

        [TestMethod]
        public void AvailabilityCadcrTest()
        {
            string path = GetTestFilePath(@"test\files\vosi\cadc_availability.xml");
            var xml = File.ReadAllText(path);
            var e = ReadElementHelper<VO.Vosi.Availability.V1_0.Availability>(xml);

            Assert.IsTrue(e.Available);
        }

        [TestMethod]
        public void CapabilitiesVizierTest()
        {
            string path = GetTestFilePath(@"test\files\vosi\vizier_capabilities.xml");
            var xml = File.ReadAllText(path);
            var e = ReadElementHelper<VO.Vosi.Capabilities.V1_0.Capabilities>(xml);
        }

        [TestMethod]
        public void CapabilitiesGaiaTest()
        {
            string path = GetTestFilePath(@"test\files\vosi\gaia_capabilities.xml");
            var xml = File.ReadAllText(path);
            var e = ReadElementHelper<VO.Vosi.Capabilities.V1_0.Capabilities>(xml);
        }

        [TestMethod]
        public void CapabilitiesCadcTest()
        {
            string path = GetTestFilePath(@"test\files\vosi\cadc_capabilities.xml");
            var xml = File.ReadAllText(path);
            var e = ReadElementHelper<VO.Vosi.Capabilities.V1_0.Capabilities>(xml);
        }

        [TestMethod]
        public void TablesVizierTest()
        {
            string path = GetTestFilePath(@"test\files\vosi\vizier_tables.xml");
            var xml = File.ReadAllText(path);
            var e = ReadElementHelper<VO.Vosi.Tables.V1_0.TableSet>(xml);
        }

        [TestMethod]
        public void TablesGaiaTest()
        {
            string path = GetTestFilePath(@"test\files\vosi\gaia_tables.xml");
            var xml = File.ReadAllText(path);
            var e = ReadElementHelper<VO.Vosi.Tables.V1_0.TableSet>(xml);
        }
    }
}
