using System;
using Il2CppDummyDll;

namespace Pathfinding
{
	// Token: 0x020000ED RID: 237
	[Token(Token = "0x20000ED")]
	public class EndingConditionDistance : PathEndingCondition
	{
		// Token: 0x06000828 RID: 2088 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000828")]
		[Address(RVA = "0x6D69F0", Offset = "0x6D4FF0", VA = "0x1806D69F0")]
		public EndingConditionDistance(Path p, int maxGScore)
		{
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00005BAC File Offset: 0x00003DAC
		[Token(Token = "0x6000829")]
		[Address(RVA = "0x6D6AB0", Offset = "0x6D50B0", VA = "0x1806D6AB0", Slot = "4")]
		public override bool TargetFound(PathNode node)
		{
			return default(bool);
		}

		// Token: 0x0400058F RID: 1423
		[Token(Token = "0x400058F")]
		[FieldOffset(Offset = "0x18")]
		public int maxGScore;
	}
}
