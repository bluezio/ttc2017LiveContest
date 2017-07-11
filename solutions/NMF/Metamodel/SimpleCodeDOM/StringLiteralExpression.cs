//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Models.Meta;
using NMF.Models.Repository;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace TTC2017.LiveContest.SimpleCodeDOM
{
    
    
    /// <summary>
    /// The default implementation of the StringLiteralExpression class
    /// </summary>
    [XmlNamespaceAttribute("http://www.transformation-tool-contest.eu/2017/LiveContest/SimpleCodeDOM")]
    [XmlNamespacePrefixAttribute("codeDom")]
    [ModelRepresentationClassAttribute("http://www.transformation-tool-contest.eu/2017/LiveContest/SimpleCodeDOM#//String" +
        "LiteralExpression")]
    public partial class StringLiteralExpression : Expression, IStringLiteralExpression, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Value property
        /// </summary>
        private string _value;
        
        private static Lazy<ITypedElement> _valueAttribute = new Lazy<ITypedElement>(RetrieveValueAttribute);
        
        private static NMF.Models.Meta.IClass _classInstance;
        
        /// <summary>
        /// The Value property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                if ((this._value != value))
                {
                    string old = this._value;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnValueChanging(e);
                    this.OnPropertyChanging("Value", e, _valueAttribute);
                    this._value = value;
                    this.OnValueChanged(e);
                    this.OnPropertyChanged("Value", e, _valueAttribute);
                }
            }
        }
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/LiveContest/SimpleCodeDOM#//String" +
                            "LiteralExpression")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Value property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ValueChanging;
        
        /// <summary>
        /// Gets fired when the Value property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ValueChanged;
        
        private static ITypedElement RetrieveValueAttribute()
        {
            return ((ITypedElement)(((ModelElement)(TTC2017.LiveContest.SimpleCodeDOM.StringLiteralExpression.ClassInstance)).Resolve("Value")));
        }
        
        /// <summary>
        /// Raises the ValueChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnValueChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ValueChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ValueChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnValueChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ValueChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "VALUE"))
            {
                return this.Value;
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "VALUE"))
            {
                this.Value = ((string)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override NMF.Models.Meta.IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://www.transformation-tool-contest.eu/2017/LiveContest/SimpleCodeDOM#//String" +
                        "LiteralExpression")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Value property
        /// </summary>
        private sealed class ValueProxy : ModelPropertyChange<IStringLiteralExpression, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ValueProxy(IStringLiteralExpression modelElement) : 
                    base(modelElement, "Value")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.Value;
                }
                set
                {
                    this.ModelElement.Value = value;
                }
            }
        }
    }
}
