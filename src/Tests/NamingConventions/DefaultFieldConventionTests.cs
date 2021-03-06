﻿using System.Reflection;
using System.Xml.Serialization;
using Bender.Configuration;
using Bender.NamingConventions;
using Bender.Nodes;
using Bender.Nodes.Object;
using Bender.Reflection;
using NUnit.Framework;
using Should;

namespace Tests.NamingConventions
{
    [TestFixture]
    public class DefaultFieldConventionTests
    {
        public string GetName<T>(string field, Options options = null)
        {
            return MemberNamingConventions.Create()
                .GetName(new MemberContext(new CachedMember(typeof(T).GetField(field, 
                    BindingFlags.NonPublic | BindingFlags.Instance)), 
                    new Context(options ?? Options.Create(), Mode.Deserialize, "xml")));
        }

        public class FieldNameConventions
        {
            [XmlAttribute]
            private string _noNameAttributeProperty;
            [XmlAttribute("SomeAttribute")]
            private string _attributeProperty;
            [XmlElement]
            private string _noNameElementProperty;
            [XmlElement("SomeElement")]
            private string _elementProperty;
            [XmlArray]
            private string[] _noNameArrayProperty;
            [XmlArray("SomeArray")]
            private string[] _arrayProperty;
            [XmlArray("SomeArray")]
            private string _notAnArrayProperty;
        }

        [Test]
        public void should_use_field_name_if_name_not_set_in_xml_attribute()
        {
            GetName<FieldNameConventions>("_noNameAttributeProperty")
                .ShouldEqual("_noNameAttributeProperty");
        }

        [Test]
        public void should_use_field_xml_attribute_name()
        {
            GetName<FieldNameConventions>("_attributeProperty")
                .ShouldEqual("SomeAttribute");
        }

        [Test]
        public void should_use_field_name_if_name_not_set_in_xml_element()
        {
            GetName<FieldNameConventions>("_noNameElementProperty")
                .ShouldEqual("_noNameElementProperty");
        }

        [Test]
        public void should_use_field_xml_element_name()
        {
            GetName<FieldNameConventions>("_elementProperty")
                .ShouldEqual("SomeElement");
        }

        [Test]
        public void should_use_field_name_if_name_not_set_in_xml_array()
        {
            GetName<FieldNameConventions>("_noNameArrayProperty")
                .ShouldEqual("_noNameArrayProperty");
        }

        [Test]
        public void should_use_fieldxml_array_name()
        {
            GetName<FieldNameConventions>("_arrayProperty")
                .ShouldEqual("SomeArray");
        }

        [Test]
        public void should_use_field_name_if_xml_array_not_on_an_enumerable_property()
        {
            GetName<FieldNameConventions>("_notAnArrayProperty")
                .ShouldEqual("_notAnArrayProperty");
        }
    }
}
