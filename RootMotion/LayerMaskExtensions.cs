using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000021 RID: 33
	[Token(Token = "0x2000021")]
	public static class LayerMaskExtensions
	{
		// Token: 0x060000CF RID: 207 RVA: 0x000028DC File Offset: 0x00000ADC
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xAA5950", Offset = "0xAA3F50", VA = "0x180AA5950")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000028F4 File Offset: 0x00000AF4
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x28F2820", Offset = "0x28F0E20", VA = "0x1828F2820")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000290C File Offset: 0x00000B0C
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x28F2830", Offset = "0x28F0E30", VA = "0x1828F2830")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002924 File Offset: 0x00000B24
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x28F2880", Offset = "0x28F0E80", VA = "0x1828F2880")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000293C File Offset: 0x00000B3C
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x28F2830", Offset = "0x28F0E30", VA = "0x1828F2830")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002954 File Offset: 0x00000B54
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x28F2930", Offset = "0x28F0F30", VA = "0x1828F2930")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000296C File Offset: 0x00000B6C
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x28F2940", Offset = "0x28F0F40", VA = "0x1828F2940")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002984 File Offset: 0x00000B84
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x28F2A00", Offset = "0x28F1000", VA = "0x1828F2A00")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x28F2AC0", Offset = "0x28F10C0", VA = "0x1828F2AC0")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x28F2BA0", Offset = "0x28F11A0", VA = "0x1828F2BA0")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x28F2C70", Offset = "0x28F1270", VA = "0x1828F2C70")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x28F2CB0", Offset = "0x28F12B0", VA = "0x1828F2CB0")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
}
