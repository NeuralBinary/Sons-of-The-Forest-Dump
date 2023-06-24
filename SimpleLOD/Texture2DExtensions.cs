using System;
using Il2CppDummyDll;
using UnityEngine;

namespace OrbCreationExtensions
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	public static class Texture2DExtensions
	{
		// Token: 0x0600009A RID: 154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x2A840A0", Offset = "0x2A826A0", VA = "0x182A840A0")]
		public static Texture2D GetCopy(this Texture2D tex)
		{
			return null;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x2A84170", Offset = "0x2A82770", VA = "0x182A84170")]
		public static Texture2D GetCopy(this Texture2D tex, int x, int y, int w, int h)
		{
			return null;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x2A84170", Offset = "0x2A82770", VA = "0x182A84170")]
		public static Texture2D GetSection(this Texture2D tex, int x, int y, int w, int h)
		{
			return null;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x2A84220", Offset = "0x2A82820", VA = "0x182A84220")]
		public static Texture2D GetCopy(this Texture2D tex, int x, int y, int w, int h, bool mipMaps)
		{
			return null;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x2A843D0", Offset = "0x2A829D0", VA = "0x182A843D0")]
		public static Texture2D ScaledCopy(this Texture2D tex, int width, int height, bool mipMaps)
		{
			return null;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x2A845F0", Offset = "0x2A82BF0", VA = "0x182A845F0")]
		public static void CopyFrom(this Texture2D tex, Texture2D fromTex, int toX, int toY, int fromX, int fromY, int width, int height)
		{
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x2A847E0", Offset = "0x2A82DE0", VA = "0x182A847E0")]
		public static void Scale(this Texture2D tex, int width, int height)
		{
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x2A84950", Offset = "0x2A82F50", VA = "0x182A84950")]
		public static void MakeFormatWritable(this Texture2D tex)
		{
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002550 File Offset: 0x00000750
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x2A84B70", Offset = "0x2A83170", VA = "0x182A84B70")]
		public static TextureFormat GetWritableFormat(TextureFormat format)
		{
			return (TextureFormat)0;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002568 File Offset: 0x00000768
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x2A84BB0", Offset = "0x2A831B0", VA = "0x182A84BB0")]
		public static Color GetAverageColor(this Texture2D tex)
		{
			return default(Color);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002580 File Offset: 0x00000780
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x2A84D30", Offset = "0x2A83330", VA = "0x182A84D30")]
		public static Color GetAverageColor(this Texture2D tex, Color useThisColorForAlpha)
		{
			return default(Color);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002598 File Offset: 0x00000798
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x2A84F00", Offset = "0x2A83500", VA = "0x182A84F00")]
		public static bool IsReadable(this Texture2D tex)
		{
			return default(bool);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000025B0 File Offset: 0x000007B0
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x2A84F90", Offset = "0x2A83590", VA = "0x182A84F90")]
		public static bool HasTransparency(this Texture2D tex)
		{
			return default(bool);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000025C8 File Offset: 0x000007C8
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x2A85030", Offset = "0x2A83630", VA = "0x182A85030")]
		public static bool IsNormalMap(this Texture2D aTexture)
		{
			return default(bool);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x2A851D0", Offset = "0x2A837D0", VA = "0x182A851D0")]
		private static Color[] ScaledPixels(Color[] originalPixels, int oldWidth, int oldHeight, int width, int height)
		{
			return null;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x2A85740", Offset = "0x2A83D40", VA = "0x182A85740")]
		public static Texture2D GetUnityNormalMap(this Texture2D tex)
		{
			return null;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x2A85A00", Offset = "0x2A84000", VA = "0x182A85A00")]
		public static Texture2D FromUnityNormalMap(this Texture2D tex)
		{
			return null;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x2A85CC0", Offset = "0x2A842C0", VA = "0x182A85CC0")]
		public static void Fill(this Texture2D tex, Color aColor)
		{
		}
	}
}
