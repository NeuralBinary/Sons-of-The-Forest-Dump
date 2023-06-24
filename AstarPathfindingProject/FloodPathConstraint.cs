using System;
using Il2CppDummyDll;

namespace Pathfinding
{
	// Token: 0x020000F0 RID: 240
	[Token(Token = "0x20000F0")]
	public class FloodPathConstraint : NNConstraint
	{
		// Token: 0x06000839 RID: 2105 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000839")]
		[Address(RVA = "0x6D7DB0", Offset = "0x6D63B0", VA = "0x1806D7DB0")]
		public FloodPathConstraint(FloodPath path)
		{
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00005BF4 File Offset: 0x00003DF4
		[Token(Token = "0x600083A")]
		[Address(RVA = "0x6D7E90", Offset = "0x6D6490", VA = "0x1806D7E90", Slot = "5")]
		public override bool Suitable(GraphNode node)
		{
			return default(bool);
		}

		// Token: 0x04000595 RID: 1429
		[Token(Token = "0x4000595")]
		[FieldOffset(Offset = "0x28")]
		private readonly FloodPath path;
	}
}
