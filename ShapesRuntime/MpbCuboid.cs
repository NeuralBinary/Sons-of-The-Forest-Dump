using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x02000034 RID: 52
	[Token(Token = "0x2000034")]
	internal class MpbCuboid : MetaMpb
	{
		// Token: 0x06000ABF RID: 2751 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ABF")]
		[Address(RVA = "0x2A3B530", Offset = "0x2A39B30", VA = "0x182A3B530", Slot = "5")]
		protected override void TransferShapeProperties()
		{
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AC0")]
		[Address(RVA = "0x2A3B5C0", Offset = "0x2A39BC0", VA = "0x182A3B5C0")]
		public MpbCuboid()
		{
		}

		// Token: 0x0400012F RID: 303
		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0xC0")]
		internal readonly List<Vector4> size;

		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0xC8")]
		internal readonly List<float> sizeSpace;
	}
}
