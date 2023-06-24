using System;
using Il2CppDummyDll;

namespace MudBun
{
	// Token: 0x02000114 RID: 276
	[Token(Token = "0x2000114")]
	public class Assert
	{
		// Token: 0x060006E6 RID: 1766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public static void True(bool b, string message = "")
		{
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006E7")]
		public static void Equal<T>(T a, T b, string message = "")
		{
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006E8")]
		public static void Unequal<T>(T a, T b, string message = "")
		{
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public static void Warn(string message)
		{
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public Assert()
		{
		}
	}
}
