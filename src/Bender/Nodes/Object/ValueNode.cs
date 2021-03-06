using System;
using System.Collections.Generic;
using Bender.Collections;
using Bender.Extensions;
using Bender.Nodes.Object.Values;
using Bender.Reflection;

namespace Bender.Nodes.Object
{
    public class ValueCannotBeNullDeserializationException : FriendlyBenderException
    {
        public ValueCannotBeNullDeserializationException() : base("Value cannot be null.") { }
    }

    public class ValueParseException : FriendlyBenderException
    {
        public ValueParseException(Exception exception, object value, string friendlyMessage) : 
            base(exception, "Error parsing '{0}'. {1}".ToFormat(value.Truncate(50), exception.Message), friendlyMessage) { }
    }

    public class ValueConversionException : BenderException
    {
        public ValueConversionException(Exception exception, object value, 
                CachedType source, CachedType target) : 
            base(exception, "Value '{0}' of type '{1}' cannot be converted to type '{2}': {3}",
                value.Truncate(50), source.FriendlyFullName, target.FriendlyFullName, exception.Message) { }
    }

    public class ValueNode : ObjectNodeBase
    {
        private readonly Dictionary<Type, string> _friendlyParseMessages;

        public ValueNode(
            Context context,
            string name,
            IValue source,
            CachedMember member,
            INode parent)
            : base(name, source, member, parent, context)
        {
            _friendlyParseMessages = Context.Options.Deserialization.FriendlyParseErrorMessages;
        }

        public override string Type { get { return "value"; } }

        protected override NodeType GetNodeType()
        {
            return NodeType.Value;
        }

        public override object Value
        {
            set
            {
                var type = SpecifiedType.UnderlyingType;
                if (value != null && !type.IsTypeOf(value))
                {
                    if (type.Is<string>()) Source.Instance = value.ToString();
                    else if (value is string && !type.Is<string>() && type.IsSimpleType)
                    {
                        try
                        {
                            Source.Instance = value.As<string>().ParseSimpleType(SpecifiedType);
                        }
                        catch (Exception exception)
                        {
                            throw new ValueParseException(exception, value, _friendlyParseMessages[
                                type.IsEnum ? typeof(Enum) : type.Type].ToFormat(value.Truncate(50)));
                        }
                    }
                    else
                    {
                        try
                        {
                            Source.Instance = type.IsEnum ?
                                value.ConvertToEnum(type.Type) : 
                                Convert.ChangeType(value, type.Type);
                        }
                        catch (Exception exception)
                        {
                            throw new ValueConversionException(exception, value, value.ToCachedType(), type);
                        }
                    }
                }
                else if (value == null && SpecifiedType.IsValueType && !SpecifiedType.IsNullable) 
                    throw new ValueCannotBeNullDeserializationException();
                else Source.Instance = value;
            }
        }
    }
}