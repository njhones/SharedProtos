// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LocationIdUpdated.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Carvana.Sched.HistoricalRoutes.Root {

  /// <summary>Holder for reflection information generated from LocationIdUpdated.proto</summary>
  public static partial class LocationIdUpdatedReflection {

    #region Descriptor
    /// <summary>File descriptor for LocationIdUpdated.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LocationIdUpdatedReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdMb2NhdGlvbklkVXBkYXRlZC5wcm90bxIyQ2FydmFuYS5TY2hlZC5IaXN0",
            "b3JpY2FsUm91dGVzLlJvb3QuTW9kZWwuTWVzc2FnZXMiwAEKEUxvY2F0aW9u",
            "SWRVcGRhdGVkEhIKCmxvY2F0aW9uSWQYASABKAUSaAoMcmVzb3VyY2VUeXBl",
            "GAIgASgOMlIuQ2FydmFuYS5TY2hlZC5IaXN0b3JpY2FsUm91dGVzLlJvb3Qu",
            "TW9kZWwuTWVzc2FnZXMuTG9jYXRpb25JZFVwZGF0ZWQuUmVzb3VyY2VUeXBl",
            "Ii0KDFJlc291cmNlVHlwZRIICgROb25lEAASBwoDQmF5EAESCgoGSGF1bGVy",
            "EAJCJqoCI0NhcnZhbmEuU2NoZWQuSGlzdG9yaWNhbFJvdXRlcy5Sb290YgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Carvana.Sched.HistoricalRoutes.Root.LocationIdUpdated), global::Carvana.Sched.HistoricalRoutes.Root.LocationIdUpdated.Parser, new[]{ "LocationId", "ResourceType" }, null, new[]{ typeof(global::Carvana.Sched.HistoricalRoutes.Root.LocationIdUpdated.Types.ResourceType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class LocationIdUpdated : pb::IMessage<LocationIdUpdated>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LocationIdUpdated> _parser = new pb::MessageParser<LocationIdUpdated>(() => new LocationIdUpdated());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LocationIdUpdated> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Carvana.Sched.HistoricalRoutes.Root.LocationIdUpdatedReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LocationIdUpdated() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LocationIdUpdated(LocationIdUpdated other) : this() {
      locationId_ = other.locationId_;
      resourceType_ = other.resourceType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LocationIdUpdated Clone() {
      return new LocationIdUpdated(this);
    }

    /// <summary>Field number for the "locationId" field.</summary>
    public const int LocationIdFieldNumber = 1;
    private int locationId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int LocationId {
      get { return locationId_; }
      set {
        locationId_ = value;
      }
    }

    /// <summary>Field number for the "resourceType" field.</summary>
    public const int ResourceTypeFieldNumber = 2;
    private global::Carvana.Sched.HistoricalRoutes.Root.LocationIdUpdated.Types.ResourceType resourceType_ = global::Carvana.Sched.HistoricalRoutes.Root.LocationIdUpdated.Types.ResourceType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Carvana.Sched.HistoricalRoutes.Root.LocationIdUpdated.Types.ResourceType ResourceType {
      get { return resourceType_; }
      set {
        resourceType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LocationIdUpdated);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LocationIdUpdated other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LocationId != other.LocationId) return false;
      if (ResourceType != other.ResourceType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (LocationId != 0) hash ^= LocationId.GetHashCode();
      if (ResourceType != global::Carvana.Sched.HistoricalRoutes.Root.LocationIdUpdated.Types.ResourceType.None) hash ^= ResourceType.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (LocationId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(LocationId);
      }
      if (ResourceType != global::Carvana.Sched.HistoricalRoutes.Root.LocationIdUpdated.Types.ResourceType.None) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ResourceType);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (LocationId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(LocationId);
      }
      if (ResourceType != global::Carvana.Sched.HistoricalRoutes.Root.LocationIdUpdated.Types.ResourceType.None) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ResourceType);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (LocationId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(LocationId);
      }
      if (ResourceType != global::Carvana.Sched.HistoricalRoutes.Root.LocationIdUpdated.Types.ResourceType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ResourceType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LocationIdUpdated other) {
      if (other == null) {
        return;
      }
      if (other.LocationId != 0) {
        LocationId = other.LocationId;
      }
      if (other.ResourceType != global::Carvana.Sched.HistoricalRoutes.Root.LocationIdUpdated.Types.ResourceType.None) {
        ResourceType = other.ResourceType;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            LocationId = input.ReadInt32();
            break;
          }
          case 16: {
            ResourceType = (global::Carvana.Sched.HistoricalRoutes.Root.LocationIdUpdated.Types.ResourceType) input.ReadEnum();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            LocationId = input.ReadInt32();
            break;
          }
          case 16: {
            ResourceType = (global::Carvana.Sched.HistoricalRoutes.Root.LocationIdUpdated.Types.ResourceType) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the LocationIdUpdated message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum ResourceType {
        [pbr::OriginalName("None")] None = 0,
        [pbr::OriginalName("Bay")] Bay = 1,
        [pbr::OriginalName("Hauler")] Hauler = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
