﻿using System;
using System.Collections.Generic;
using System.Reflection;

namespace Bender
{
    public class Options
    {
        public Options()
        {
            ExcludedTypes = new List<Func<Type, bool>>();
            DefaultGenericTypeNameFormat = "{0}Of{1}";
            DefaultGenericListNameFormat = "ArrayOf{0}";
            ValueNode = NodeType.Element;

            Readers = new Dictionary<Type, Func<Options, PropertyInfo, Node, object>>();
            AddReader((o, p, e) => Convert.FromBase64String(e.Value));
            AddReader((o, p, e) => new Uri(o.DefaultNonNullableTypesWhenEmpty && e.Value.IsNullOrEmpty() ? "http://tempuri.org/" : e.Value));

            Writers = new Dictionary<Type, Action<Options, PropertyInfo, object, Node>>();
            AddWriter<byte[]>((o, p, v, e) => e.Value = Convert.ToBase64String(v));
            AddWriter<Uri>((o, p, v, e) => e.Value = v != null ? v.ToString() : "");
            AddWriter<bool>((o, p, v, e) => e.Value = v.ToString().ToLower(), true);
        }
        
        public List<Func<Type, bool>> ExcludedTypes { get; set; }
        public string DefaultGenericTypeNameFormat { get; set; }
        public string DefaultGenericListNameFormat { get; set; }

        // Deserialization specific
        public bool DefaultNonNullableTypesWhenEmpty { get; set; }
        public bool IgnoreUnmatchedElements { get; set; }
        public bool IgnoreTypeElementNames { get; set; }
        public bool IgnoreCase { get; set; }

        public Dictionary<Type, Func<Options, PropertyInfo, Node, object>> Readers { get; private set; }

        public void AddReader<T>(Func<Options, PropertyInfo, Node, T> reader)
        {
            Readers.Add(typeof(T), (o, p, e) => reader(o, p, e));
        }

        public void AddReader<T>(Func<Options, PropertyInfo, Node, T> reader, bool handleNullable) where T : struct
        {
            Readers.Add(typeof(T), (o, p, e) => reader(o, p, e));
            if (handleNullable) Readers.Add(typeof(T?), (o, p, e) => !string.IsNullOrEmpty(e.Value) ? reader(o, p, e) : (T?)null);
        } 

        // Serialization specific
        public bool PrettyPrint { get; set; }
        public bool ExcludeNullValues { get; set; }
        public NodeType ValueNode { get; set; }
        public Dictionary<Type, Action<Options, PropertyInfo, object, Node>> Writers { get; private set; }

        public void AddWriter<T>(Action<Options, PropertyInfo, T, Node> writer)
        {
            Writers.Add(typeof(T), (o, p, v, e) => writer(o, p, (T)v, e));
        }

        public void AddWriter<T>(Action<Options, PropertyInfo, T, Node> writer, bool handleNullable) where T : struct
        {
            Writers.Add(typeof(T), (o, p, v, e) => writer(o, p, (T)v, e));
            if (handleNullable) Writers.Add(typeof(T?), (o, p, v, e) => { if (((T?)v).HasValue) writer(o, p, ((T?)v).Value, e); });
        } 
    }
}