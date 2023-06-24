using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000F3 RID: 243
	[Token(Token = "0x20000F3")]
	[NullableContext(1)]
	[Nullable(0)]
	internal readonly struct StructMultiKey<T1, T2> : IEquatable<StructMultiKey<T1, T2>>
	{
		// Token: 0x0600071A RID: 1818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600071A")]
		public StructMultiKey(T1 v1, T2 v2)
		{
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x000042A8 File Offset: 0x000024A8
		[Token(Token = "0x600071B")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x000042C0 File Offset: 0x000024C0
		[Token(Token = "0x600071C")]
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x000042D8 File Offset: 0x000024D8
		[Token(Token = "0x600071D")]
		public bool Equals([Nullable(new byte[]
		{
			0,
			1,
			1
		})] StructMultiKey<T1, T2> other)
		{
			return default(bool);
		}

		// Token: 0x040004D6 RID: 1238
		[Token(Token = "0x40004D6")]
		[FieldOffset(Offset = "0x0")]
		public readonly T1 Value1;

		// Token: 0x040004D7 RID: 1239
		[Token(Token = "0x40004D7")]
		[FieldOffset(Offset = "0x0")]
		public readonly T2 Value2;
	}
}
