using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000023")]
	public struct NNInfoInternal
	{
		// Token: 0x060001D5 RID: 469 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x6333F0", Offset = "0x6319F0", VA = "0x1806333F0")]
		public NNInfoInternal(GraphNode node)
		{
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x633520", Offset = "0x631B20", VA = "0x180633520")]
		public void UpdateInfo()
		{
		}

		// Token: 0x04000131 RID: 305
		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x0")]
		public GraphNode node;

		// Token: 0x04000132 RID: 306
		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x8")]
		public GraphNode constrainedNode;

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 clampedPosition;

		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 constClampedPosition;
	}
}
