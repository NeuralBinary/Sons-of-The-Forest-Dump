using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	// Token: 0x02000026 RID: 38
	[Token(Token = "0x2000026")]
	[Nullable(0)]
	[NullableContext(1)]
	internal struct JsonPosition
	{
		// Token: 0x060000AD RID: 173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x24F2010", Offset = "0x24F0610", VA = "0x1824F2010")]
		public JsonPosition(JsonContainerType type)
		{
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000021F0 File Offset: 0x000003F0
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x24F20C0", Offset = "0x24F06C0", VA = "0x1824F20C0")]
		internal int CalculateLength()
		{
			return 0;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x24F2160", Offset = "0x24F0760", VA = "0x1824F2160")]
		[NullableContext(2)]
		internal void WriteTo([Nullable(1)] StringBuilder sb, ref StringWriter writer, ref char[] buffer)
		{
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002208 File Offset: 0x00000408
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xAC3190", Offset = "0xAC1790", VA = "0x180AC3190")]
		internal static bool TypeHasIndex(JsonContainerType type)
		{
			return default(bool);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x24F2370", Offset = "0x24F0970", VA = "0x1824F2370")]
		internal static string BuildPath(List<JsonPosition> positions, JsonPosition? currentPosition)
		{
			return null;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x24F28E0", Offset = "0x24F0EE0", VA = "0x1824F28E0")]
		internal static string FormatMessage([Nullable(2)] IJsonLineInfo lineInfo, string path, string message)
		{
			return null;
		}

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly char[] SpecialCharacters;

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x0")]
		internal JsonContainerType Type;

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x4")]
		internal int Position;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x8")]
		[Nullable(2)]
		internal string PropertyName;

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x10")]
		internal bool HasIndex;
	}
}
