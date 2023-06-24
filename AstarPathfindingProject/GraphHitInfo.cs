using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x02000020 RID: 32
	[Token(Token = "0x2000020")]
	public struct GraphHitInfo
	{
		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001CB RID: 459 RVA: 0x00002D14 File Offset: 0x00000F14
		[Token(Token = "0x17000081")]
		public float distance
		{
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x633010", Offset = "0x631610", VA = "0x180633010")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x633080", Offset = "0x631680", VA = "0x180633080")]
		public GraphHitInfo(Vector3 point)
		{
		}

		// Token: 0x04000123 RID: 291
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 origin;

		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0xC")]
		public Vector3 point;

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x18")]
		public GraphNode node;

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 tangentOrigin;

		// Token: 0x04000127 RID: 295
		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 tangent;
	}
}
