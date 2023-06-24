using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000C1 RID: 193
	[Token(Token = "0x20000C1")]
	[NullableContext(1)]
	[Nullable(0)]
	internal class EnumInfo
	{
		// Token: 0x060005FA RID: 1530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x255E290", Offset = "0x255C890", VA = "0x18255E290")]
		public EnumInfo(bool isFlags, ulong[] values, string[] names, string[] resolvedNames)
		{
		}

		// Token: 0x0400043D RID: 1085
		[Token(Token = "0x400043D")]
		[FieldOffset(Offset = "0x10")]
		public readonly bool IsFlags;

		// Token: 0x0400043E RID: 1086
		[Token(Token = "0x400043E")]
		[FieldOffset(Offset = "0x18")]
		public readonly ulong[] Values;

		// Token: 0x0400043F RID: 1087
		[Token(Token = "0x400043F")]
		[FieldOffset(Offset = "0x20")]
		public readonly string[] Names;

		// Token: 0x04000440 RID: 1088
		[Token(Token = "0x4000440")]
		[FieldOffset(Offset = "0x28")]
		public readonly string[] ResolvedNames;
	}
}
