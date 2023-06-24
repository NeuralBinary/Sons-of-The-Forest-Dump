using System;
using Il2CppDummyDll;

namespace Sons.Ai.Vail
{
	// Token: 0x0200008C RID: 140
	[Token(Token = "0x200008C")]
	public interface IWorldActorLocators
	{
		// Token: 0x060005A4 RID: 1444
		[Token(Token = "0x60005A4")]
		void AddGpsLocator(WorldSimActor actor, int iconId);

		// Token: 0x060005A5 RID: 1445
		[Token(Token = "0x60005A5")]
		void RemoveGpsLocator(WorldSimActor actor);

		// Token: 0x060005A6 RID: 1446
		[Token(Token = "0x60005A6")]
		int GetActorLocatorTypeId(WorldSimActor actor);
	}
}
