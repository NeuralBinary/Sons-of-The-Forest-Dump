using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.RVO
{
	// Token: 0x0200014E RID: 334
	[Token(Token = "0x200014E")]
	public class ObstacleVertex
	{
		// Token: 0x06000A5E RID: 2654 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0x71D310", Offset = "0x71B910", VA = "0x18071D310")]
		public ObstacleVertex()
		{
		}

		// Token: 0x0400071C RID: 1820
		[Token(Token = "0x400071C")]
		[FieldOffset(Offset = "0x10")]
		public bool ignore;

		// Token: 0x0400071D RID: 1821
		[Token(Token = "0x400071D")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 position;

		// Token: 0x0400071E RID: 1822
		[Token(Token = "0x400071E")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 dir;

		// Token: 0x0400071F RID: 1823
		[Token(Token = "0x400071F")]
		[FieldOffset(Offset = "0x28")]
		public float height;

		// Token: 0x04000720 RID: 1824
		[Token(Token = "0x4000720")]
		[FieldOffset(Offset = "0x2C")]
		public RVOLayer layer;

		// Token: 0x04000721 RID: 1825
		[Token(Token = "0x4000721")]
		[FieldOffset(Offset = "0x30")]
		public ObstacleVertex next;

		// Token: 0x04000722 RID: 1826
		[Token(Token = "0x4000722")]
		[FieldOffset(Offset = "0x38")]
		public ObstacleVertex prev;
	}
}
