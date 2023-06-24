using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Multiplayer
{
	// Token: 0x02000554 RID: 1364
	[Token(Token = "0x2000554")]
	public class IdObject
	{
		// Token: 0x06002433 RID: 9267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002433")]
		[Address(RVA = "0x3383EF0", Offset = "0x33824F0", VA = "0x183383EF0")]
		public static List<string> ListForDropdown()
		{
			return null;
		}

		// Token: 0x06002434 RID: 9268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002434")]
		[Address(RVA = "0x3384120", Offset = "0x3382720", VA = "0x183384120")]
		public static string ConvertToNamedKey(int index)
		{
			return null;
		}

		// Token: 0x06002435 RID: 9269 RVA: 0x0000A968 File Offset: 0x00008B68
		[Token(Token = "0x6002435")]
		[Address(RVA = "0x3384190", Offset = "0x3382790", VA = "0x183384190")]
		public static int ConvertToIndex(string key)
		{
			return 0;
		}

		// Token: 0x06002436 RID: 9270 RVA: 0x0000A980 File Offset: 0x00008B80
		[Token(Token = "0x6002436")]
		[Address(RVA = "0x33842A0", Offset = "0x33828A0", VA = "0x1833842A0")]
		public static bool TryConvertToIndex(string sourceKey, out int index)
		{
			return default(bool);
		}

		// Token: 0x06002437 RID: 9271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002437")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public IdObject()
		{
		}

		// Token: 0x0400207D RID: 8317
		[Token(Token = "0x400207D")]
		public const int None = -1;

		// Token: 0x0400207E RID: 8318
		[Token(Token = "0x400207E")]
		public const int CaveBSluggy = 0;

		// Token: 0x0400207F RID: 8319
		[Token(Token = "0x400207F")]
		public const int LuxuryBunkerEntranceDoor = 1;

		// Token: 0x04002080 RID: 8320
		[Token(Token = "0x4002080")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string[] NamedKeys;

		// Token: 0x04002081 RID: 8321
		[Token(Token = "0x4002081")]
		[FieldOffset(Offset = "0x8")]
		private static List<string> _listForDropDown;
	}
}
