﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.34011
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers.ArrayBased {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.5.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class System_Collections_ObjectModel_Collection_1_System_Int32_Serializer : MsgPack.Serialization.MessagePackSerializer<System.Collections.ObjectModel.Collection<int>> {
        
        private MsgPack.Serialization.MessagePackSerializer<int> _serializer0;
        
        public System_Collections_ObjectModel_Collection_1_System_Int32_Serializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            this._serializer0 = this.OwnerContext.GetSerializer<int>();
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, System.Collections.ObjectModel.Collection<int> objectTree) {
            packer.PackArrayHeader(objectTree.Count);
            System.Collections.Generic.IEnumerator<int> enumerator = objectTree.GetEnumerator();
            int current;
            try {
                for (
                ; enumerator.MoveNext(); 
                ) {
                    current = enumerator.Current;
                    this._serializer0.PackTo(packer, current);
                }
            }
            finally {
                enumerator.Dispose();
            }
        }
        
        protected internal override System.Collections.ObjectModel.Collection<int> UnpackFromCore(MsgPack.Unpacker unpacker) {
            if ((unpacker.IsArrayHeader == false)) {
                throw MsgPack.Serialization.SerializationExceptions.NewIsNotArrayHeader();
            }
            System.Collections.ObjectModel.Collection<int> collection = default(System.Collections.ObjectModel.Collection<int>);
            collection = new System.Collections.ObjectModel.Collection<int>();
            this.UnpackToCore(unpacker, collection);
            return collection;
        }
        
        protected internal override void UnpackToCore(MsgPack.Unpacker unpacker, System.Collections.ObjectModel.Collection<int> collection) {
            if ((unpacker.IsArrayHeader == false)) {
                throw MsgPack.Serialization.SerializationExceptions.NewIsNotArrayHeader();
            }
            int count = default(int);
            count = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
            for (int i = 0; (i < count); i = (i + 1)) {
                System.Nullable<int> nullable = default(System.Nullable<int>);
                nullable = MsgPack.Serialization.UnpackHelpers.UnpackNullableInt32Value(unpacker, typeof(System.Collections.ObjectModel.Collection<int>), string.Format(System.Globalization.CultureInfo.InvariantCulture, "item{0}", new object[] {
                                ((object)(i))}));
                if (nullable.HasValue) {
                    collection.Add(nullable.Value);
                }
                else {
                    throw MsgPack.Serialization.SerializationExceptions.NewValueTypeCannotBeNull(string.Format(System.Globalization.CultureInfo.InvariantCulture, "item{0}", new object[] {
                                    ((object)(i))}), typeof(int), typeof(System.Collections.ObjectModel.Collection<int>));
                }
            }
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
