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
    public class System_Collections_Generic_Dictionary_2_System_Object_System_Object_Serializer : MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.Dictionary<object, object>> {
        
        private MsgPack.Serialization.MessagePackSerializer<object> _serializer0;
        
        public System_Collections_Generic_Dictionary_2_System_Object_System_Object_Serializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            this._serializer0 = this.OwnerContext.GetSerializer<object>();
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, System.Collections.Generic.Dictionary<object, object> objectTree) {
            packer.PackMapHeader(objectTree.Count);
            System.Collections.Generic.Dictionary<object, object>.Enumerator enumerator = objectTree.GetEnumerator();
            System.Collections.Generic.KeyValuePair<object, object> current;
            try {
                for (
                ; enumerator.MoveNext(); 
                ) {
                    current = enumerator.Current;
                    this._serializer0.PackTo(packer, current.Key);
                    this._serializer0.PackTo(packer, current.Value);
                }
            }
            finally {
                enumerator.Dispose();
            }
        }
        
        protected internal override System.Collections.Generic.Dictionary<object, object> UnpackFromCore(MsgPack.Unpacker unpacker) {
            if ((unpacker.IsMapHeader == false)) {
                throw MsgPack.Serialization.SerializationExceptions.NewIsNotMapHeader();
            }
            System.Collections.Generic.Dictionary<object, object> collection = default(System.Collections.Generic.Dictionary<object, object>);
            collection = new System.Collections.Generic.Dictionary<object, object>(MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker));
            this.UnpackToCore(unpacker, collection);
            return collection;
        }
        
        protected internal override void UnpackToCore(MsgPack.Unpacker unpacker, System.Collections.Generic.Dictionary<object, object> collection) {
            if ((unpacker.IsMapHeader == false)) {
                throw MsgPack.Serialization.SerializationExceptions.NewIsNotMapHeader();
            }
            int itemsCount = default(int);
            itemsCount = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
            for (int i = 0; (i < itemsCount); i = (i + 1)) {
                object key = default(object);
                object value = default(object);
                object nullable = default(object);
                if ((unpacker.Read() == false)) {
                    throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                }
                if (((unpacker.IsArrayHeader == false) 
                            && (unpacker.IsMapHeader == false))) {
                    nullable = this._serializer0.UnpackFrom(unpacker);
                }
                else {
                    MsgPack.Unpacker disposable = default(MsgPack.Unpacker);
                    disposable = unpacker.ReadSubtree();
                    try {
                        nullable = this._serializer0.UnpackFrom(disposable);
                    }
                    finally {
                        if (((disposable == null) 
                                    == false)) {
                            disposable.Dispose();
                        }
                    }
                }
                if (((nullable == null) 
                            == false)) {
                    key = nullable;
                }
                else {
                    throw MsgPack.Serialization.SerializationExceptions.NewNullIsProhibited(string.Format(System.Globalization.CultureInfo.InvariantCulture, "key{0}", new object[] {
                                    ((object)(i))}));
                }
                object nullable0 = default(object);
                if ((unpacker.Read() == false)) {
                    throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                }
                if (((unpacker.IsArrayHeader == false) 
                            && (unpacker.IsMapHeader == false))) {
                    nullable0 = this._serializer0.UnpackFrom(unpacker);
                }
                else {
                    MsgPack.Unpacker disposable0 = default(MsgPack.Unpacker);
                    disposable0 = unpacker.ReadSubtree();
                    try {
                        nullable0 = this._serializer0.UnpackFrom(disposable0);
                    }
                    finally {
                        if (((disposable0 == null) 
                                    == false)) {
                            disposable0.Dispose();
                        }
                    }
                }
                if (((nullable0 == null) 
                            == false)) {
                    value = nullable0;
                }
                else {
                    value = nullable0;
                }
                collection.Add(key, value);
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
