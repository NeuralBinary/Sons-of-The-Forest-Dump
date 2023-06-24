using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x02000024 RID: 36
	[Token(Token = "0x2000024")]
	public struct NNInfo
	{
		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x00002D5C File Offset: 0x00000F5C
		[Token(Token = "0x17000085")]
		[Obsolete("This field has been renamed to 'position'")]
		public Vector3 clampedPosition
		{
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x633690", Offset = "0x631C90", VA = "0x180633690")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x6336B0", Offset = "0x631CB0", VA = "0x1806336B0")]
		public NNInfo(NNInfoInternal internalInfo)
		{
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00002D74 File Offset: 0x00000F74
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x633690", Offset = "0x631C90", VA = "0x180633690")]
		public static explicit operator Vector3(NNInfo ob)
		{
			return default(Vector3);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x633720", Offset = "0x631D20", VA = "0x180633720")]
		public static explicit operator GraphNode(NNInfo ob)
		{
			return null;
		}

		// Token: 0x04000135 RID: 309
		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x0")]
		public readonly GraphNode node;

		// Token: 0x04000136 RID: 310
		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x8")]
		public readonly Vector3 position;
	}
}
