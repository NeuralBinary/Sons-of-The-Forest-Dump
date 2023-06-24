using System;
using Il2CppDummyDll;

namespace Pathfinding
{
	// Token: 0x020000F7 RID: 247
	[Token(Token = "0x20000F7")]
	public class ABPathEndingCondition : PathEndingCondition
	{
		// Token: 0x0600086C RID: 2156 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600086C")]
		[Address(RVA = "0x6DD3C0", Offset = "0x6DB9C0", VA = "0x1806DD3C0")]
		public ABPathEndingCondition(ABPath p)
		{
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00005C84 File Offset: 0x00003E84
		[Token(Token = "0x600086D")]
		[Address(RVA = "0x6DD4D0", Offset = "0x6DBAD0", VA = "0x1806DD4D0", Slot = "4")]
		public override bool TargetFound(PathNode node)
		{
			return default(bool);
		}

		// Token: 0x040005B6 RID: 1462
		[Token(Token = "0x40005B6")]
		[FieldOffset(Offset = "0x18")]
		protected ABPath abPath;
	}
}
