using System;
using Il2CppDummyDll;
using Sons.Areas;

namespace Sons.Ai.Vail
{
	// Token: 0x02000081 RID: 129
	[Token(Token = "0x2000081")]
	public interface IActorZone
	{
		// Token: 0x06000587 RID: 1415
		[Token(Token = "0x6000587")]
		void TeleportToZone(WorldSimActor actor);

		// Token: 0x06000588 RID: 1416
		[Token(Token = "0x6000588")]
		BoundsShape GetWanderBounds(State state);

		// Token: 0x06000589 RID: 1417
		[Token(Token = "0x6000589")]
		bool KeepAboveTerrain();

		// Token: 0x0600058A RID: 1418
		[Token(Token = "0x600058A")]
		AreaMask GetAreaMask();
	}
}
