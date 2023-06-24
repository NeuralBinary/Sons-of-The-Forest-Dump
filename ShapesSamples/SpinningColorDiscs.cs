using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	[ExecuteAlways]
	public class SpinningColorDiscs : ImmediateModeShapeDrawer
	{
		// Token: 0x0600002D RID: 45 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2A5D030", Offset = "0x2A5B630", VA = "0x182A5D030", Slot = "4")]
		public override void DrawShapes(Camera cam)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000020E4 File Offset: 0x000002E4
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2A5D510", Offset = "0x2A5BB10", VA = "0x182A5D510")]
		private Vector2 GetDiscPosition(float t)
		{
			return default(Vector2);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2A5D620", Offset = "0x2A5BC20", VA = "0x182A5D620")]
		public SpinningColorDiscs()
		{
		}

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x28")]
		[Range(3f, 32f)]
		public int discCount;

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		public float discRadius;
	}
}
