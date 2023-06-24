using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	public class RichSpecial : RichPathPart
	{
		// Token: 0x060001A4 RID: 420 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x62FF90", Offset = "0x62E590", VA = "0x18062FF90", Slot = "5")]
		public override void OnEnterPool()
		{
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x62FFF0", Offset = "0x62E5F0", VA = "0x18062FFF0")]
		public RichSpecial Initialize(NodeLink2 nodeLink, GraphNode first)
		{
			return null;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public RichSpecial()
		{
		}

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x10")]
		public NodeLink2 nodeLink;

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x18")]
		public Transform first;

		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x20")]
		public Transform second;

		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x28")]
		public bool reverse;
	}
}
