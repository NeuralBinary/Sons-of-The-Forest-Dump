using System;
using Il2CppDummyDll;

namespace PathologicalGames
{
	// Token: 0x0200005A RID: 90
	[Token(Token = "0x200005A")]
	public struct MessageData_TargetableOnHit
	{
		// Token: 0x06000277 RID: 631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x28D12E0", Offset = "0x28CF8E0", VA = "0x1828D12E0")]
		public MessageData_TargetableOnHit(HitEffectList effects, Target target)
		{
		}

		// Token: 0x04000151 RID: 337
		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x0")]
		public HitEffectList effects;

		// Token: 0x04000152 RID: 338
		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x8")]
		public Target target;
	}
}
