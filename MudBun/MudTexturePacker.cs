using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MudBun
{
	// Token: 0x02000139 RID: 313
	[Token(Token = "0x2000139")]
	public class MudTexturePacker : ScriptableObject
	{
		// Token: 0x060007BA RID: 1978 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x244B490", Offset = "0x2449A90", VA = "0x18244B490")]
		private Color[] GetPixels(MudTexturePacker.TextureType type, int numPixels)
		{
			return null;
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x244B690", Offset = "0x2449C90", VA = "0x18244B690")]
		public void Pack(string path)
		{
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public MudTexturePacker()
		{
		}

		// Token: 0x040004A4 RID: 1188
		[Token(Token = "0x40004A4")]
		[FieldOffset(Offset = "0x18")]
		public MudTexturePacker.TextureType ColorType;

		// Token: 0x040004A5 RID: 1189
		[Token(Token = "0x40004A5")]
		[FieldOffset(Offset = "0x20")]
		public Texture2D Color;

		// Token: 0x040004A6 RID: 1190
		[Token(Token = "0x40004A6")]
		[FieldOffset(Offset = "0x28")]
		public MudTexturePacker.TextureType EmissionType;

		// Token: 0x040004A7 RID: 1191
		[Token(Token = "0x40004A7")]
		[FieldOffset(Offset = "0x30")]
		public Texture2D Emission;

		// Token: 0x040004A8 RID: 1192
		[Token(Token = "0x40004A8")]
		[FieldOffset(Offset = "0x38")]
		public MudTexturePacker.TextureType NormalType;

		// Token: 0x040004A9 RID: 1193
		[Token(Token = "0x40004A9")]
		[FieldOffset(Offset = "0x40")]
		public Texture2D Normal;

		// Token: 0x040004AA RID: 1194
		[Token(Token = "0x40004AA")]
		[FieldOffset(Offset = "0x48")]
		public MudTexturePacker.TextureType MetallicType;

		// Token: 0x040004AB RID: 1195
		[Token(Token = "0x40004AB")]
		[FieldOffset(Offset = "0x50")]
		public Texture2D Metallic;

		// Token: 0x040004AC RID: 1196
		[Token(Token = "0x40004AC")]
		[FieldOffset(Offset = "0x58")]
		public MudTexturePacker.TextureType SmoothnessType;

		// Token: 0x040004AD RID: 1197
		[Token(Token = "0x40004AD")]
		[FieldOffset(Offset = "0x60")]
		public Texture2D Smoothness;

		// Token: 0x0200013A RID: 314
		[Token(Token = "0x200013A")]
		public enum TextureType
		{
			// Token: 0x040004AF RID: 1199
			[Token(Token = "0x40004AF")]
			White,
			// Token: 0x040004B0 RID: 1200
			[Token(Token = "0x40004B0")]
			Gray,
			// Token: 0x040004B1 RID: 1201
			[Token(Token = "0x40004B1")]
			Black,
			// Token: 0x040004B2 RID: 1202
			[Token(Token = "0x40004B2")]
			FlatNormal,
			// Token: 0x040004B3 RID: 1203
			[Token(Token = "0x40004B3")]
			Texutre
		}
	}
}
