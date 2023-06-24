using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x0200003A RID: 58
	[Token(Token = "0x200003A")]
	internal class MpbQuad : MetaMpb
	{
		// Token: 0x06000AE5 RID: 2789 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0x2A3CF90", Offset = "0x2A3B590", VA = "0x182A3CF90", Slot = "5")]
		protected override void TransferShapeProperties()
		{
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0x2A3D0D0", Offset = "0x2A3B6D0", VA = "0x182A3D0D0")]
		public MpbQuad()
		{
		}

		// Token: 0x04000168 RID: 360
		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0xC0")]
		internal readonly List<Vector4> a;

		// Token: 0x04000169 RID: 361
		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0xC8")]
		internal readonly List<Vector4> b;

		// Token: 0x0400016A RID: 362
		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0xD0")]
		internal readonly List<Vector4> c;

		// Token: 0x0400016B RID: 363
		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0xD8")]
		internal readonly List<Vector4> colorB;

		// Token: 0x0400016C RID: 364
		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0xE0")]
		internal readonly List<Vector4> colorC;

		// Token: 0x0400016D RID: 365
		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0xE8")]
		internal readonly List<Vector4> colorD;

		// Token: 0x0400016E RID: 366
		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0xF0")]
		internal readonly List<Vector4> d;
	}
}
