using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000107 RID: 263
	[Token(Token = "0x2000107")]
	[NullableContext(1)]
	[Nullable(0)]
	internal class DefaultReferenceResolver : IReferenceResolver
	{
		// Token: 0x060007A1 RID: 1953 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x257D030", Offset = "0x257B630", VA = "0x18257D030")]
		private BidirectionalDictionary<string, object> GetMappings(object context)
		{
			return null;
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x257D260", Offset = "0x257B860", VA = "0x18257D260", Slot = "4")]
		public object ResolveReference(object context, string reference)
		{
			return null;
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x257D320", Offset = "0x257B920", VA = "0x18257D320", Slot = "5")]
		public string GetReference(object context, object value)
		{
			return null;
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x257D4A0", Offset = "0x257BAA0", VA = "0x18257D4A0", Slot = "7")]
		public void AddReference(object context, string reference, object value)
		{
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x000046B0 File Offset: 0x000028B0
		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x257D520", Offset = "0x257BB20", VA = "0x18257D520", Slot = "6")]
		public bool IsReferenced(object context, object value)
		{
			return default(bool);
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public DefaultReferenceResolver()
		{
		}

		// Token: 0x04000503 RID: 1283
		[Token(Token = "0x4000503")]
		[FieldOffset(Offset = "0x10")]
		private int _referenceCount;
	}
}
