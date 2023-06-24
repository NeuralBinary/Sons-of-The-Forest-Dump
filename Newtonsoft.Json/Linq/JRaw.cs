using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x0200017A RID: 378
	[Token(Token = "0x200017A")]
	[NullableContext(1)]
	[Nullable(0)]
	public class JRaw : JValue
	{
		// Token: 0x06000C8A RID: 3210 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000C8A")]
		[Address(RVA = "0x25CA030", Offset = "0x25C8630", VA = "0x1825CA030")]
		public static Task<JRaw> CreateAsync(JsonReader reader, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C8B")]
		[Address(RVA = "0x25CA220", Offset = "0x25C8820", VA = "0x1825CA220")]
		public JRaw(JRaw other)
		{
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C8C")]
		[Address(RVA = "0x25CA2E0", Offset = "0x25C88E0", VA = "0x1825CA2E0")]
		internal JRaw(JRaw other, [Nullable(2)] JsonCloneSettings settings)
		{
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C8D")]
		[Address(RVA = "0x25CA3B0", Offset = "0x25C89B0", VA = "0x1825CA3B0")]
		[NullableContext(2)]
		public JRaw(object rawJson)
		{
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000C8E")]
		[Address(RVA = "0x25CA3C0", Offset = "0x25C89C0", VA = "0x1825CA3C0")]
		public static JRaw Create(JsonReader reader)
		{
			return null;
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000C8F")]
		[Address(RVA = "0x25CA6B0", Offset = "0x25C8CB0", VA = "0x1825CA6B0", Slot = "13")]
		internal override JToken CloneToken([Nullable(2)] JsonCloneSettings settings)
		{
			return null;
		}
	}
}
