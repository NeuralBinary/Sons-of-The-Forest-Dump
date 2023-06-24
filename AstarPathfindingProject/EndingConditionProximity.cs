using System;
using Il2CppDummyDll;

namespace Pathfinding
{
	// Token: 0x020000F8 RID: 248
	[Token(Token = "0x20000F8")]
	public class EndingConditionProximity : ABPathEndingCondition
	{
		// Token: 0x0600086E RID: 2158 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600086E")]
		[Address(RVA = "0x6DD500", Offset = "0x6DBB00", VA = "0x1806DD500")]
		public EndingConditionProximity(ABPath p, float maxDistance)
		{
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00005C9C File Offset: 0x00003E9C
		[Token(Token = "0x600086F")]
		[Address(RVA = "0x6DD530", Offset = "0x6DBB30", VA = "0x1806DD530", Slot = "4")]
		public override bool TargetFound(PathNode node)
		{
			return default(bool);
		}

		// Token: 0x040005B7 RID: 1463
		[Token(Token = "0x40005B7")]
		[FieldOffset(Offset = "0x20")]
		public float maxDistance;
	}
}
