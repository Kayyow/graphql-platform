﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotChocolate.Subscriptions.RabbitMQ {
    using System;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class RabbitMQResources {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal RabbitMQResources() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("HotChocolate.Subscriptions.RabbitMQ.Properties.RabbitMQResources", typeof(RabbitMQResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        internal static string RabbitMQPubSubExtensions_AddRabbitMQSubscriptions_PrefixInvalid {
            get {
                return ResourceManager.GetString("RabbitMQPubSubExtensions_AddRabbitMQSubscriptions_PrefixInvalid", resourceCulture);
            }
        }
        
        internal static string RabbitMQPubSub_RabbitMQPubSub_PrefixCannotBeNull {
            get {
                return ResourceManager.GetString("RabbitMQPubSub_RabbitMQPubSub_PrefixCannotBeNull", resourceCulture);
            }
        }
        
        internal static string Subscription_Unsubscribe_UnsubscribedFromRabbitMQ {
            get {
                return ResourceManager.GetString("Subscription_Unsubscribe_UnsubscribedFromRabbitMQ", resourceCulture);
            }
        }
        
        internal static string RabbitMQTopic_ConnectAsync_SubscribedToRabbitMQ {
            get {
                return ResourceManager.GetString("RabbitMQTopic_ConnectAsync_SubscribedToRabbitMQ", resourceCulture);
            }
        }
        
        internal static string RabbitMQConnection_InitializeConnection_ConnectionSucceededButFailedUnexpectedly {
            get {
                return ResourceManager.GetString("RabbitMQConnection_InitializeConnection_ConnectionSucceededButFailedUnexpectedly", resourceCulture);
            }
        }
        
        internal static string RabbitMQConnection_InitializeConnection_ConnectionAttemptFailed {
            get {
                return ResourceManager.GetString("RabbitMQConnection_InitializeConnection_ConnectionAttemptFailed", resourceCulture);
            }
        }
        
        internal static string RabbitMQConnection_InitializeConnection_ConnectionFailedAfterRetry {
            get {
                return ResourceManager.GetString("RabbitMQConnection_InitializeConnection_ConnectionFailedAfterRetry", resourceCulture);
            }
        }
        
        internal static string RabbitMQConnection_InitializeConnection_ConnectionFailedUnexpectedly {
            get {
                return ResourceManager.GetString("RabbitMQConnection_InitializeConnection_ConnectionFailedUnexpectedly", resourceCulture);
            }
        }
        
        internal static string RabbitMQConnectionFailedException_RabbitMQConnectionFailedException_ConnectionFailed {
            get {
                return ResourceManager.GetString("RabbitMQConnectionFailedException_RabbitMQConnectionFailedException_ConnectionFai" +
                        "led", resourceCulture);
            }
        }
    }
}
