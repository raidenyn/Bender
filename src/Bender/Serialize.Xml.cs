﻿using System;
using System.IO;
using System.Text;
using System.Xml.Linq;
using Bender.Configuration;
using Bender.Nodes.Xml;

namespace Bender
{
    public static partial class Serialize
    {
        // XElement

        public static XElement XmlElement(object source, Options options)
        {
            return Serializer.Create(options).SerializeXmlElement(source);
        }

        public static XElement XmlElement(object source, Action<OptionsDsl> configure = null)
        {
            return Serializer.Create(configure).SerializeXmlElement(source);
        }

        public static XElement XmlElement<T>(T source, Options options)
        {
            return Serializer.Create(options).SerializeXmlElement(source);
        }

        public static XElement XmlElement<T>(T source, Action<OptionsDsl> configure = null)
        {
            return Serializer.Create(configure).SerializeXmlElement(source);
        }

        public static XElement XmlElement(object source, Type type, Options options)
        {
            return Serializer.Create(options).SerializeXmlElement(source, type);
        }

        public static XElement XmlElement(object source, Type type, Action<OptionsDsl> configure = null)
        {
            return Serializer.Create(configure).SerializeXmlElement(source, type);
        }

        // XDocument

        public static XDocument XmlDocument(object source, Options options)
        {
            return Serializer.Create(options).SerializeXmlDocument(source);
        }

        public static XDocument XmlDocument(object source, Action<OptionsDsl> configure = null)
        {
            return Serializer.Create(configure).SerializeXmlDocument(source);
        }

        public static XDocument XmlDocument<T>(T source, Options options)
        {
            return Serializer.Create(options).SerializeXmlDocument(source);
        }

        public static XDocument XmlDocument<T>(T source, Action<OptionsDsl> configure = null)
        {
            return Serializer.Create(configure).SerializeXmlDocument(source);
        }

        public static XDocument XmlDocument(object source, Type type, Options options)
        {
            return Serializer.Create(options).SerializeXmlDocument(source, type);
        }

        public static XDocument XmlDocument(object source, Type type, Action<OptionsDsl> configure = null)
        {
            return Serializer.Create(configure).SerializeXmlDocument(source, type);
        }

        // String

        public static string Xml(object source, Options options)
        {
            return Serializer.Create(options).SerializeXml(source);
        }

        public static string Xml(object source, Action<OptionsDsl> configure = null)
        {
            return Serializer.Create(configure).SerializeXml(source);
        }

        public static string Xml<T>(T source, Options options)
        {
            return Serializer.Create(options).SerializeXml(source);
        }

        public static string Xml<T>(T source, Action<OptionsDsl> configure = null)
        {
            return Serializer.Create(configure).SerializeXml(source);
        }

        public static string Xml(object source, Type type, Options options)
        {
            return Serializer.Create(options).SerializeXml(source, type);
        }

        public static string Xml(object source, Type type, Action<OptionsDsl> configure = null)
        {
            return Serializer.Create(configure).SerializeXml(source, type);
        }

        // Bytes

        public static byte[] XmlBytes(object source, Options options)
        {
            return Serializer.Create(options).SerializeXmlBytes(source);
        }

        public static byte[] XmlBytes(object source, Action<OptionsDsl> configure = null)
        {
            return Serializer.Create(configure).SerializeXmlBytes(source);
        }

        public static byte[] XmlBytes(object source, Encoding encoding, Options options)
        {
            return Serializer.Create(options).SerializeXmlBytes(source, encoding);
        }

        public static byte[] XmlBytes(object source, Encoding encoding, Action<OptionsDsl> configure = null)
        {
            return Serializer.Create(configure).SerializeXmlBytes(source, encoding);
        }

        public static byte[] XmlBytes<T>(T source, Options options)
        {
            return Serializer.Create(options).SerializeXmlBytes(source);
        }

        public static byte[] XmlBytes<T>(T source, Action<OptionsDsl> configure = null)
        {
            return Serializer.Create(configure).SerializeXmlBytes(source);
        }

        public static byte[] XmlBytes<T>(T source, Encoding encoding, Options options)
        {
            return Serializer.Create(options).SerializeXmlBytes(source, encoding);
        }

        public static byte[] XmlBytes<T>(T source, Encoding encoding, Action<OptionsDsl> configure = null)
        {
            return Serializer.Create(configure).SerializeXmlBytes(source, encoding);
        }

        public static byte[] XmlBytes(object source, Type type, Options options)
        {
            return Serializer.Create(options).SerializeXmlBytes(source, type);
        }

        public static byte[] XmlBytes(object source, Type type, Action<OptionsDsl> configure = null)
        {
            return Serializer.Create(configure).SerializeXmlBytes(source, type);
        }

        public static byte[] XmlBytes(object source, Type type, Encoding encoding, Options options)
        {
            return Serializer.Create(options).SerializeXmlBytes(source, type, encoding);
        }

        public static byte[] XmlBytes(object source, Type type, Encoding encoding, Action<OptionsDsl> configure = null)
        {
            return Serializer.Create(configure).SerializeXmlBytes(source, type, encoding);
        }

        // Return Stream

        public static Stream XmlStream(object source, Options options)
        {
            return Serializer.Create(options).SerializeXmlStream(source);
        }

        public static Stream XmlStream(object source, Action<OptionsDsl> configure = null)
        {
            return Serializer.Create(configure).SerializeXmlStream(source);
        }

        public static Stream XmlStream(object source, Encoding encoding, Options options)
        {
            return Serializer.Create(options).SerializeXmlStream(source, encoding);
        }

        public static Stream XmlStream(object source, Encoding encoding, Action<OptionsDsl> configure = null)
        {
            return Serializer.Create(configure).SerializeXmlStream(source, encoding);
        }

        public static Stream XmlStream<T>(T source, Options options)
        {
            return Serializer.Create(options).SerializeXmlStream(source);
        }

        public static Stream XmlStream<T>(T source, Action<OptionsDsl> configure = null)
        {
            return Serializer.Create(configure).SerializeXmlStream(source);
        }

        public static Stream XmlStream<T>(T source, Encoding encoding, Options options)
        {
            return Serializer.Create(options).SerializeXmlStream(source, encoding);
        }

        public static Stream XmlStream<T>(T source, Encoding encoding, Action<OptionsDsl> configure = null)
        {
            return Serializer.Create(configure).SerializeXmlStream(source, encoding);
        }

        public static Stream XmlStream(object source, Type type, Options options)
        {
            return Serializer.Create(options).SerializeXmlStream(source, type);
        }

        public static Stream XmlStream(object source, Type type, Action<OptionsDsl> configure = null)
        {
            return Serializer.Create(configure).SerializeXmlStream(source, type);
        }

        public static Stream XmlStream(object source, Type type, Encoding encoding, Options options)
        {
            return Serializer.Create(options).SerializeXmlStream(source, type, encoding);
        }

        public static Stream XmlStream(object source, Type type, Encoding encoding, Action<OptionsDsl> configure = null)
        {
            return Serializer.Create(configure).SerializeXmlStream(source, type, encoding);
        }

        // To Stream

        public static void XmlStream(object source, Stream stream, Options options)
        {
            Serializer.Create(options).SerializeXmlStream(source, stream);
        }

        public static void XmlStream(object source, Stream stream, Action<OptionsDsl> configure = null)
        {
            Serializer.Create(configure).SerializeXmlStream(source, stream);
        }

        public static void XmlStream(object source, Stream stream, Encoding encoding, Options options)
        {
            Serializer.Create(options).SerializeXmlStream(source, stream, encoding);
        }

        public static void XmlStream(object source, Stream stream, Encoding encoding, Action<OptionsDsl> configure = null)
        {
            Serializer.Create(configure).SerializeXmlStream(source, stream, encoding);
        }

        public static void XmlStream<T>(T source, Stream stream, Options options)
        {
            Serializer.Create(options).SerializeXmlStream(source, stream);
        }

        public static void XmlStream<T>(T source, Stream stream, Action<OptionsDsl> configure = null)
        {
            Serializer.Create(configure).SerializeXmlStream(source, stream);
        }

        public static void XmlStream<T>(T source, Stream stream, Encoding encoding, Options options)
        {
            Serializer.Create(options).SerializeXmlStream(source, stream, encoding);
        }

        public static void XmlStream<T>(T source, Stream stream, Encoding encoding, Action<OptionsDsl> configure = null)
        {
            Serializer.Create(configure).SerializeXmlStream(source, stream, encoding);
        }

        public static void XmlStream(object source, Type type, Stream stream, Options options)
        {
            Serializer.Create(options).SerializeXmlStream(source, type, stream);
        }

        public static void XmlStream(object source, Type type, Stream stream, Action<OptionsDsl> configure = null)
        {
            Serializer.Create(configure).SerializeXmlStream(source, type, stream);
        }

        public static void XmlStream(object source, Type type, Stream stream, Encoding encoding, Options options)
        {
            Serializer.Create(options).SerializeXmlStream(source, type, stream, encoding);
        }

        public static void XmlStream(object source, Type type, Stream stream, Encoding encoding, Action<OptionsDsl> configure = null)
        {
            Serializer.Create(configure).SerializeXmlStream(source, type, stream, encoding);
        }

        // File

        public static void XmlFile(object source, string path, Options options)
        {
            Serializer.Create(options).SerializeXmlFile(source, path);
        }

        public static void XmlFile(object source, string path, Action<OptionsDsl> configure = null)
        {
            Serializer.Create(configure).SerializeXmlFile(source, path);
        }

        public static void XmlFile(object source, string path, Encoding encoding, Options options)
        {
            Serializer.Create(options).SerializeXmlFile(source, path, encoding);
        }

        public static void XmlFile(object source, string path, Encoding encoding, Action<OptionsDsl> configure = null)
        {
            Serializer.Create(configure).SerializeXmlFile(source, path, encoding);
        }

        public static void XmlFile<T>(T source, string path, Options options)
        {
            Serializer.Create(options).SerializeXmlFile(source, path);
        }

        public static void XmlFile<T>(T source, string path, Action<OptionsDsl> configure = null)
        {
            Serializer.Create(configure).SerializeXmlFile(source, path);
        }

        public static void XmlFile<T>(T source, string path, Encoding encoding, Options options)
        {
            Serializer.Create(options).SerializeXmlFile(source, path, encoding);
        }

        public static void XmlFile<T>(T source, string path, Encoding encoding, Action<OptionsDsl> configure = null)
        {
            Serializer.Create(configure).SerializeXmlFile(source, path, encoding);
        }

        public static void XmlFile(object source, Type type, string path, Options options)
        {
            Serializer.Create(options).SerializeXmlFile(source, type, path);
        }

        public static void XmlFile(object source, Type type, string path, Action<OptionsDsl> configure = null)
        {
            Serializer.Create(configure).SerializeXmlFile(source, type, path);
        }

        public static void XmlFile(object source, Type type, string path, Encoding encoding, Options options)
        {
            Serializer.Create(options).SerializeXmlFile(source, type, path, encoding);
        }

        public static void XmlFile(object source, Type type, string path, Encoding encoding, Action<OptionsDsl> configure = null)
        {
            Serializer.Create(configure).SerializeXmlFile(source, type, path, encoding);
        }

        // Nodes

        public static ElementNode XmlNodes(object source, Options options)
        {
            return Serializer.Create(options).SerializeXmlNodes(source);
        }

        public static ElementNode XmlNodes(object source, Action<OptionsDsl> configure = null)
        {
            return Serializer.Create(configure).SerializeXmlNodes(source);
        }

        public static ElementNode XmlNodes<T>(T source, Options options)
        {
            return Serializer.Create(options).SerializeXmlNodes(source);
        }

        public static ElementNode XmlNodes<T>(T source, Action<OptionsDsl> configure = null)
        {
            return Serializer.Create(configure).SerializeXmlNodes(source);
        }

        public static ElementNode XmlNodes(object source, Type type, Options options)
        {
            return Serializer.Create(options).SerializeXmlNodes(source, type);
        }

        public static ElementNode XmlNodes(object source, Type type, Action<OptionsDsl> configure = null)
        {
            return Serializer.Create(configure).SerializeXmlNodes(source, type);
        }
    }
}
