using System;
using Il2CppDummyDll;

namespace Pathfinding
{
	// Token: 0x02000071 RID: 113
	[Token(Token = "0x2000071")]
	public struct Connection
	{
		// Token: 0x060003FD RID: 1021 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x66F080", Offset = "0x66D680", VA = "0x18066F080")]
		public Connection(GraphNode node, uint cost, byte shapeEdge = 255)
		{
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00004094 File Offset: 0x00002294
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x66F0F0", Offset = "0x66D6F0", VA = "0x18066F0F0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x000040AC File Offset: 0x000022AC
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x66F130", Offset = "0x66D730", VA = "0x18066F130", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x040002C6 RID: 710
		[Token(Token = "0x40002C6")]
		[FieldOffset(Offset = "0x0")]
		public GraphNode node;

		// Token: 0x040002C7 RID: 711
		[Token(Token = "0x40002C7")]
		[FieldOffset(Offset = "0x8")]
		public uint cost;

		// Token: 0x040002C8 RID: 712
		[Token(Token = "0x40002C8")]
		[FieldOffset(Offset = "0xC")]
		public byte shapeEdge;

		// Token: 0x040002C9 RID: 713
		[Token(Token = "0x40002C9")]
		public const byte NoSharedEdge = 255;
	}
}
