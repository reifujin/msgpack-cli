﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.34011
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers.MapBased {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.5.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_DataMemberAttributeNamedPropertyTestTargetSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.DataMemberAttributeNamedPropertyTestTarget> {
        
        private MsgPack.Serialization.MessagePackSerializer<string> _serializer0;
        
        public MsgPack_Serialization_DataMemberAttributeNamedPropertyTestTargetSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            this._serializer0 = this.OwnerContext.GetSerializer<string>();
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.DataMemberAttributeNamedPropertyTestTarget objectTree) {
            packer.PackMapHeader(1);
            this._serializer0.PackTo(packer, "Alias");
            this._serializer0.PackTo(packer, objectTree.Member);
        }
        
        protected internal override MsgPack.Serialization.DataMemberAttributeNamedPropertyTestTarget UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.DataMemberAttributeNamedPropertyTestTarget result = default(MsgPack.Serialization.DataMemberAttributeNamedPropertyTestTarget);
            result = new MsgPack.Serialization.DataMemberAttributeNamedPropertyTestTarget();
            if (unpacker.IsArrayHeader) {
                int unpacked = default(int);
                int itemsCount = default(int);
                itemsCount = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
                string nullable = default(string);
                if ((unpacked < itemsCount)) {
                    nullable = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.DataMemberAttributeNamedPropertyTestTarget), "System.String Member");
                }
                if (((nullable == null) 
                            == false)) {
                    result.Member = nullable;
                }
                unpacked = (unpacked + 1);
            }
            else {
                int itemsCount0 = default(int);
                itemsCount0 = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
                for (int i = 0; (i < itemsCount0); i = (i + 1)) {
                    string key = default(string);
                    string nullable0 = default(string);
                    nullable0 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.DataMemberAttributeNamedPropertyTestTarget), "MemberName");
                    if (((nullable0 == null) 
                                == false)) {
                        key = nullable0;
                    }
                    else {
                        throw MsgPack.Serialization.SerializationExceptions.NewNullIsProhibited("MemberName");
                    }
                    if ((key == "Alias")) {
                        string nullable1 = default(string);
                        nullable1 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.DataMemberAttributeNamedPropertyTestTarget), "System.String Member");
                        if (((nullable1 == null) 
                                    == false)) {
                            result.Member = nullable1;
                        }
                    }
                }
            }
            return result;
        }
        
        private static T @__Conditional<T>(bool condition, T whenTrue, T whenFalse)
         {
            if (condition) {
                return whenTrue;
            }
            else {
                return whenFalse;
            }
        }
    }
}
