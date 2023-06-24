using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200012E RID: 302
	[Token(Token = "0x200012E")]
	public class PolygonFont2d
	{
		// Token: 0x0600084E RID: 2126 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600084E")]
		[Address(RVA = "0x1FD8DA0", Offset = "0x1FD73A0", VA = "0x181FD8DA0")]
		public PolygonFont2d()
		{
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600084F")]
		[Address(RVA = "0x1FD8EA0", Offset = "0x1FD74A0", VA = "0x181FD8EA0")]
		public void AddCharacter(string s, GeneralPolygon2d[] polygons)
		{
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000850")]
		[Address(RVA = "0x1FD9100", Offset = "0x1FD7700", VA = "0x181FD9100")]
		public List<GeneralPolygon2d> GetCharacter(char c)
		{
			return null;
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000851")]
		[Address(RVA = "0x1FD92B0", Offset = "0x1FD78B0", VA = "0x181FD92B0")]
		public List<GeneralPolygon2d> GetCharacter(string s)
		{
			return null;
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x0000656C File Offset: 0x0000476C
		[Token(Token = "0x6000852")]
		[Address(RVA = "0x1FD93F0", Offset = "0x1FD79F0", VA = "0x181FD93F0")]
		public AxisAlignedBox2d GetCharacterBounds(char c)
		{
			return default(AxisAlignedBox2d);
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00006584 File Offset: 0x00004784
		[Token(Token = "0x6000853")]
		[Address(RVA = "0x1FD9580", Offset = "0x1FD7B80", VA = "0x181FD9580")]
		public bool HasCharacter(char c)
		{
			return default(bool);
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000854")]
		[Address(RVA = "0x1FD9630", Offset = "0x1FD7C30", VA = "0x181FD9630")]
		public static void Store(PolygonFont2d font, BinaryWriter writer)
		{
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000855")]
		[Address(RVA = "0x1FD9930", Offset = "0x1FD7F30", VA = "0x181FD9930")]
		public static PolygonFont2d ReadFont(string filename)
		{
			return null;
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000856")]
		[Address(RVA = "0x1FD9A50", Offset = "0x1FD8050", VA = "0x181FD9A50")]
		public static PolygonFont2d ReadFont(Stream s)
		{
			return null;
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000857")]
		[Address(RVA = "0x1FD9AE0", Offset = "0x1FD80E0", VA = "0x181FD9AE0")]
		public static void Restore(PolygonFont2d font, BinaryReader reader)
		{
		}

		// Token: 0x04000493 RID: 1171
		[Token(Token = "0x4000493")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, PolygonFont2d.CharacterInfo> Characters;

		// Token: 0x04000494 RID: 1172
		[Token(Token = "0x4000494")]
		[FieldOffset(Offset = "0x18")]
		public AxisAlignedBox2d MaxBounds;

		// Token: 0x04000495 RID: 1173
		[Token(Token = "0x4000495")]
		private const int SerializerVersion = 3;

		// Token: 0x0200012F RID: 303
		[Token(Token = "0x200012F")]
		public class CharacterInfo
		{
			// Token: 0x06000858 RID: 2136 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000858")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public CharacterInfo()
			{
			}

			// Token: 0x04000496 RID: 1174
			[Token(Token = "0x4000496")]
			[FieldOffset(Offset = "0x10")]
			public GeneralPolygon2d[] Polygons;

			// Token: 0x04000497 RID: 1175
			[Token(Token = "0x4000497")]
			[FieldOffset(Offset = "0x18")]
			public AxisAlignedBox2d Bounds;
		}
	}
}
