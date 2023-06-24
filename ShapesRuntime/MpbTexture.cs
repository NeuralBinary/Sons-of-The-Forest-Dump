using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x02000041 RID: 65
	[Token(Token = "0x2000041")]
	internal class MpbTexture : MetaMpb
	{
		// Token: 0x06000B12 RID: 2834 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B12")]
		[Address(RVA = "0x2A3F040", Offset = "0x2A3D640", VA = "0x182A3F040", Slot = "5")]
		protected override void TransferShapeProperties()
		{
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B13")]
		[Address(RVA = "0x2A3F220", Offset = "0x2A3D820", VA = "0x182A3F220")]
		public MpbTexture()
		{
		}

		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0xC0")]
		internal readonly List<Texture> textures;

		// Token: 0x040001B1 RID: 433
		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0xC8")]
		internal readonly List<Vector4> rect;

		// Token: 0x040001B2 RID: 434
		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0xD0")]
		internal readonly List<Vector4> uvs;
	}
}
