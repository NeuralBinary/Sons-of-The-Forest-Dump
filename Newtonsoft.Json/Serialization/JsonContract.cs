using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000119 RID: 281
	[Token(Token = "0x2000119")]
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class JsonContract
	{
		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000108")]
		public Type UnderlyingType
		{
			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x620F10", Offset = "0x61F510", VA = "0x180620F10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060007F9 RID: 2041 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060007FA RID: 2042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000109")]
		public Type CreatedType
		{
			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x25813E0", Offset = "0x257F9E0", VA = "0x1825813E0")]
			set
			{
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060007FB RID: 2043 RVA: 0x00004800 File Offset: 0x00002A00
		// (set) Token: 0x060007FC RID: 2044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700010A")]
		public bool? IsReference
		{
			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x9ABDA0", Offset = "0x9AA3A0", VA = "0x1809ABDA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60007FC")]
			[Address(RVA = "0x2581540", Offset = "0x257FB40", VA = "0x182581540")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060007FD RID: 2045 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060007FE RID: 2046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700010B")]
		[Nullable(2)]
		public JsonConverter Converter
		{
			[Token(Token = "0x60007FD")]
			[Address(RVA = "0x6F1D00", Offset = "0x6F0300", VA = "0x1806F1D00")]
			[NullableContext(2)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60007FE")]
			[Address(RVA = "0x6F1D10", Offset = "0x6F0310", VA = "0x1806F1D10")]
			[NullableContext(2)]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060007FF RID: 2047 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000800 RID: 2048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700010C")]
		[Nullable(2)]
		public JsonConverter InternalConverter
		{
			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x6306D0", Offset = "0x62ECD0", VA = "0x1806306D0")]
			[NullableContext(2)]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000800")]
			[Address(RVA = "0x73EE10", Offset = "0x73D410", VA = "0x18073EE10")]
			[NullableContext(2)]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000801 RID: 2049 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700010D")]
		public IList<SerializationCallback> OnDeserializedCallbacks
		{
			[Token(Token = "0x6000801")]
			[Address(RVA = "0x2581550", Offset = "0x257FB50", VA = "0x182581550")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000802 RID: 2050 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700010E")]
		public IList<SerializationCallback> OnDeserializingCallbacks
		{
			[Token(Token = "0x6000802")]
			[Address(RVA = "0x2581610", Offset = "0x257FC10", VA = "0x182581610")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000803 RID: 2051 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700010F")]
		public IList<SerializationCallback> OnSerializedCallbacks
		{
			[Token(Token = "0x6000803")]
			[Address(RVA = "0x25816D0", Offset = "0x257FCD0", VA = "0x1825816D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000110")]
		public IList<SerializationCallback> OnSerializingCallbacks
		{
			[Token(Token = "0x6000804")]
			[Address(RVA = "0x2581790", Offset = "0x257FD90", VA = "0x182581790")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000805 RID: 2053 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000111")]
		public IList<SerializationErrorCallback> OnErrorCallbacks
		{
			[Token(Token = "0x6000805")]
			[Address(RVA = "0x2581850", Offset = "0x257FE50", VA = "0x182581850")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000806 RID: 2054 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000807 RID: 2055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000112")]
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<object> DefaultCreator
		{
			[Token(Token = "0x6000806")]
			[Address(RVA = "0x737410", Offset = "0x735A10", VA = "0x180737410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000807")]
			[Address(RVA = "0x8DD040", Offset = "0x8DB640", VA = "0x1808DD040")]
			[CompilerGenerated]
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000808 RID: 2056 RVA: 0x00004818 File Offset: 0x00002A18
		// (set) Token: 0x06000809 RID: 2057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000113")]
		public bool DefaultCreatorNonPublic
		{
			[Token(Token = "0x6000808")]
			[Address(RVA = "0x179C600", Offset = "0x179AC00", VA = "0x18179C600")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000809")]
			[Address(RVA = "0x179C610", Offset = "0x179AC10", VA = "0x18179C610")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600080A")]
		[Address(RVA = "0x2581910", Offset = "0x257FF10", VA = "0x182581910")]
		internal JsonContract(Type underlyingType)
		{
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600080B")]
		[Address(RVA = "0x2581C80", Offset = "0x2580280", VA = "0x182581C80")]
		internal void InvokeOnSerializing(object o, StreamingContext context)
		{
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600080C")]
		[Address(RVA = "0x2581DF0", Offset = "0x25803F0", VA = "0x182581DF0")]
		internal void InvokeOnSerialized(object o, StreamingContext context)
		{
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600080D")]
		[Address(RVA = "0x2581F60", Offset = "0x2580560", VA = "0x182581F60")]
		internal void InvokeOnDeserializing(object o, StreamingContext context)
		{
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600080E")]
		[Address(RVA = "0x25820D0", Offset = "0x25806D0", VA = "0x1825820D0")]
		internal void InvokeOnDeserialized(object o, StreamingContext context)
		{
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600080F")]
		[Address(RVA = "0x2582240", Offset = "0x2580840", VA = "0x182582240")]
		internal void InvokeOnError(object o, StreamingContext context, ErrorContext errorContext)
		{
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000810")]
		[Address(RVA = "0x25823C0", Offset = "0x25809C0", VA = "0x1825823C0")]
		internal static SerializationCallback CreateSerializationCallback(MethodInfo callbackMethodInfo)
		{
			return null;
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000811")]
		[Address(RVA = "0x25824A0", Offset = "0x2580AA0", VA = "0x1825824A0")]
		internal static SerializationErrorCallback CreateSerializationErrorCallback(MethodInfo callbackMethodInfo)
		{
			return null;
		}

		// Token: 0x0400052C RID: 1324
		[Token(Token = "0x400052C")]
		[FieldOffset(Offset = "0x10")]
		internal bool IsNullable;

		// Token: 0x0400052D RID: 1325
		[Token(Token = "0x400052D")]
		[FieldOffset(Offset = "0x11")]
		internal bool IsConvertable;

		// Token: 0x0400052E RID: 1326
		[Token(Token = "0x400052E")]
		[FieldOffset(Offset = "0x12")]
		internal bool IsEnum;

		// Token: 0x0400052F RID: 1327
		[Token(Token = "0x400052F")]
		[FieldOffset(Offset = "0x18")]
		internal Type NonNullableUnderlyingType;

		// Token: 0x04000530 RID: 1328
		[Token(Token = "0x4000530")]
		[FieldOffset(Offset = "0x20")]
		internal ReadType InternalReadType;

		// Token: 0x04000531 RID: 1329
		[Token(Token = "0x4000531")]
		[FieldOffset(Offset = "0x24")]
		internal JsonContractType ContractType;

		// Token: 0x04000532 RID: 1330
		[Token(Token = "0x4000532")]
		[FieldOffset(Offset = "0x28")]
		internal bool IsReadOnlyOrFixedSize;

		// Token: 0x04000533 RID: 1331
		[Token(Token = "0x4000533")]
		[FieldOffset(Offset = "0x29")]
		internal bool IsSealed;

		// Token: 0x04000534 RID: 1332
		[Token(Token = "0x4000534")]
		[FieldOffset(Offset = "0x2A")]
		internal bool IsInstantiable;

		// Token: 0x04000535 RID: 1333
		[Token(Token = "0x4000535")]
		[FieldOffset(Offset = "0x30")]
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SerializationCallback> _onDeserializedCallbacks;

		// Token: 0x04000536 RID: 1334
		[Token(Token = "0x4000536")]
		[FieldOffset(Offset = "0x38")]
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SerializationCallback> _onDeserializingCallbacks;

		// Token: 0x04000537 RID: 1335
		[Token(Token = "0x4000537")]
		[FieldOffset(Offset = "0x40")]
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SerializationCallback> _onSerializedCallbacks;

		// Token: 0x04000538 RID: 1336
		[Token(Token = "0x4000538")]
		[FieldOffset(Offset = "0x48")]
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SerializationCallback> _onSerializingCallbacks;

		// Token: 0x04000539 RID: 1337
		[Token(Token = "0x4000539")]
		[FieldOffset(Offset = "0x50")]
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SerializationErrorCallback> _onErrorCallbacks;

		// Token: 0x0400053A RID: 1338
		[Token(Token = "0x400053A")]
		[FieldOffset(Offset = "0x58")]
		private Type _createdType;
	}
}
