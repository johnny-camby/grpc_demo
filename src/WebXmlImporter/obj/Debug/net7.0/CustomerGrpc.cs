// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: customer.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace XmlData.GrpcServices {
  public static partial class CustomerData
  {
    static readonly string __ServiceName = "CustomerData";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::XmlData.GrpcServices.CustomersRequest> __Marshaller_CustomersRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::XmlData.GrpcServices.CustomersRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::XmlData.GrpcServices.CustomersResponse> __Marshaller_CustomersResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::XmlData.GrpcServices.CustomersResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::XmlData.GrpcServices.GetCustomerByIdRequest> __Marshaller_GetCustomerByIdRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::XmlData.GrpcServices.GetCustomerByIdRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::XmlData.GrpcServices.GetCustomerByIdResponse> __Marshaller_GetCustomerByIdResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::XmlData.GrpcServices.GetCustomerByIdResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::XmlData.GrpcServices.CreateCustomerRequest> __Marshaller_CreateCustomerRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::XmlData.GrpcServices.CreateCustomerRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::XmlData.GrpcServices.CreateCustomerResponse> __Marshaller_CreateCustomerResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::XmlData.GrpcServices.CreateCustomerResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::XmlData.GrpcServices.PutCustomerRequest> __Marshaller_PutCustomerRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::XmlData.GrpcServices.PutCustomerRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::XmlData.GrpcServices.PutCustomerResponse> __Marshaller_PutCustomerResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::XmlData.GrpcServices.PutCustomerResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::XmlData.GrpcServices.DeleteCustomerRequest> __Marshaller_DeleteCustomerRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::XmlData.GrpcServices.DeleteCustomerRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::XmlData.GrpcServices.DeleteCustomerResponse> __Marshaller_DeleteCustomerResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::XmlData.GrpcServices.DeleteCustomerResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::XmlData.GrpcServices.SaveCustomerRequest> __Marshaller_SaveCustomerRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::XmlData.GrpcServices.SaveCustomerRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::XmlData.GrpcServices.SaveCustomerResponse> __Marshaller_SaveCustomerResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::XmlData.GrpcServices.SaveCustomerResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::XmlData.GrpcServices.UploadXmlRequest> __Marshaller_UploadXmlRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::XmlData.GrpcServices.UploadXmlRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::XmlData.GrpcServices.UploadXmlResponse> __Marshaller_UploadXmlResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::XmlData.GrpcServices.UploadXmlResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::XmlData.GrpcServices.CustomersRequest, global::XmlData.GrpcServices.CustomersResponse> __Method_GetCustomers = new grpc::Method<global::XmlData.GrpcServices.CustomersRequest, global::XmlData.GrpcServices.CustomersResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCustomers",
        __Marshaller_CustomersRequest,
        __Marshaller_CustomersResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::XmlData.GrpcServices.GetCustomerByIdRequest, global::XmlData.GrpcServices.GetCustomerByIdResponse> __Method_GetCustomerById = new grpc::Method<global::XmlData.GrpcServices.GetCustomerByIdRequest, global::XmlData.GrpcServices.GetCustomerByIdResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCustomerById",
        __Marshaller_GetCustomerByIdRequest,
        __Marshaller_GetCustomerByIdResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::XmlData.GrpcServices.CreateCustomerRequest, global::XmlData.GrpcServices.CreateCustomerResponse> __Method_CreateNew = new grpc::Method<global::XmlData.GrpcServices.CreateCustomerRequest, global::XmlData.GrpcServices.CreateCustomerResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateNew",
        __Marshaller_CreateCustomerRequest,
        __Marshaller_CreateCustomerResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::XmlData.GrpcServices.PutCustomerRequest, global::XmlData.GrpcServices.PutCustomerResponse> __Method_PutCustomer = new grpc::Method<global::XmlData.GrpcServices.PutCustomerRequest, global::XmlData.GrpcServices.PutCustomerResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "PutCustomer",
        __Marshaller_PutCustomerRequest,
        __Marshaller_PutCustomerResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::XmlData.GrpcServices.DeleteCustomerRequest, global::XmlData.GrpcServices.DeleteCustomerResponse> __Method_DeleteCustomer = new grpc::Method<global::XmlData.GrpcServices.DeleteCustomerRequest, global::XmlData.GrpcServices.DeleteCustomerResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteCustomer",
        __Marshaller_DeleteCustomerRequest,
        __Marshaller_DeleteCustomerResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::XmlData.GrpcServices.SaveCustomerRequest, global::XmlData.GrpcServices.SaveCustomerResponse> __Method_SaveCustomer = new grpc::Method<global::XmlData.GrpcServices.SaveCustomerRequest, global::XmlData.GrpcServices.SaveCustomerResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SaveCustomer",
        __Marshaller_SaveCustomerRequest,
        __Marshaller_SaveCustomerResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::XmlData.GrpcServices.UploadXmlRequest, global::XmlData.GrpcServices.UploadXmlResponse> __Method_UploadXml = new grpc::Method<global::XmlData.GrpcServices.UploadXmlRequest, global::XmlData.GrpcServices.UploadXmlResponse>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "UploadXml",
        __Marshaller_UploadXmlRequest,
        __Marshaller_UploadXmlResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::XmlData.GrpcServices.CustomerReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for CustomerData</summary>
    public partial class CustomerDataClient : grpc::ClientBase<CustomerDataClient>
    {
      /// <summary>Creates a new client for CustomerData</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public CustomerDataClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CustomerData that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public CustomerDataClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected CustomerDataClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected CustomerDataClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::XmlData.GrpcServices.CustomersResponse GetCustomers(global::XmlData.GrpcServices.CustomersRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCustomers(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::XmlData.GrpcServices.CustomersResponse GetCustomers(global::XmlData.GrpcServices.CustomersRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetCustomers, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::XmlData.GrpcServices.CustomersResponse> GetCustomersAsync(global::XmlData.GrpcServices.CustomersRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCustomersAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::XmlData.GrpcServices.CustomersResponse> GetCustomersAsync(global::XmlData.GrpcServices.CustomersRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetCustomers, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::XmlData.GrpcServices.GetCustomerByIdResponse GetCustomerById(global::XmlData.GrpcServices.GetCustomerByIdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCustomerById(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::XmlData.GrpcServices.GetCustomerByIdResponse GetCustomerById(global::XmlData.GrpcServices.GetCustomerByIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetCustomerById, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::XmlData.GrpcServices.GetCustomerByIdResponse> GetCustomerByIdAsync(global::XmlData.GrpcServices.GetCustomerByIdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCustomerByIdAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::XmlData.GrpcServices.GetCustomerByIdResponse> GetCustomerByIdAsync(global::XmlData.GrpcServices.GetCustomerByIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetCustomerById, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::XmlData.GrpcServices.CreateCustomerResponse CreateNew(global::XmlData.GrpcServices.CreateCustomerRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateNew(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::XmlData.GrpcServices.CreateCustomerResponse CreateNew(global::XmlData.GrpcServices.CreateCustomerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateNew, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::XmlData.GrpcServices.CreateCustomerResponse> CreateNewAsync(global::XmlData.GrpcServices.CreateCustomerRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateNewAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::XmlData.GrpcServices.CreateCustomerResponse> CreateNewAsync(global::XmlData.GrpcServices.CreateCustomerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateNew, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::XmlData.GrpcServices.PutCustomerResponse PutCustomer(global::XmlData.GrpcServices.PutCustomerRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PutCustomer(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::XmlData.GrpcServices.PutCustomerResponse PutCustomer(global::XmlData.GrpcServices.PutCustomerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_PutCustomer, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::XmlData.GrpcServices.PutCustomerResponse> PutCustomerAsync(global::XmlData.GrpcServices.PutCustomerRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PutCustomerAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::XmlData.GrpcServices.PutCustomerResponse> PutCustomerAsync(global::XmlData.GrpcServices.PutCustomerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_PutCustomer, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::XmlData.GrpcServices.DeleteCustomerResponse DeleteCustomer(global::XmlData.GrpcServices.DeleteCustomerRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteCustomer(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::XmlData.GrpcServices.DeleteCustomerResponse DeleteCustomer(global::XmlData.GrpcServices.DeleteCustomerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteCustomer, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::XmlData.GrpcServices.DeleteCustomerResponse> DeleteCustomerAsync(global::XmlData.GrpcServices.DeleteCustomerRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteCustomerAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::XmlData.GrpcServices.DeleteCustomerResponse> DeleteCustomerAsync(global::XmlData.GrpcServices.DeleteCustomerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteCustomer, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::XmlData.GrpcServices.SaveCustomerResponse SaveCustomer(global::XmlData.GrpcServices.SaveCustomerRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SaveCustomer(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::XmlData.GrpcServices.SaveCustomerResponse SaveCustomer(global::XmlData.GrpcServices.SaveCustomerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SaveCustomer, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::XmlData.GrpcServices.SaveCustomerResponse> SaveCustomerAsync(global::XmlData.GrpcServices.SaveCustomerRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SaveCustomerAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::XmlData.GrpcServices.SaveCustomerResponse> SaveCustomerAsync(global::XmlData.GrpcServices.SaveCustomerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SaveCustomer, null, options, request);
      }
      /// <summary>
      ///rpc UploadXml (UploadXmlRequest) returns (UploadXmlResponse);
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncClientStreamingCall<global::XmlData.GrpcServices.UploadXmlRequest, global::XmlData.GrpcServices.UploadXmlResponse> UploadXml(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UploadXml(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///rpc UploadXml (UploadXmlRequest) returns (UploadXmlResponse);
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncClientStreamingCall<global::XmlData.GrpcServices.UploadXmlRequest, global::XmlData.GrpcServices.UploadXmlResponse> UploadXml(grpc::CallOptions options)
      {
        return CallInvoker.AsyncClientStreamingCall(__Method_UploadXml, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override CustomerDataClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CustomerDataClient(configuration);
      }
    }

  }
}
#endregion
