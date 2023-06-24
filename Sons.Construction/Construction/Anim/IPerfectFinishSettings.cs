using System;
using Il2CppDummyDll;

namespace Construction.Anim
{
	// Token: 0x020002BE RID: 702
	[Token(Token = "0x20002BE")]
	public interface IPerfectFinishSettings
	{
		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06001543 RID: 5443
		[Token(Token = "0x1700046F")]
		PerfectFinishIkModes IkMode { [Token(Token = "0x6001543")] get; }

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06001544 RID: 5444
		[Token(Token = "0x17000470")]
		IIkSingleGoalProviderModule GoalProvider { [Token(Token = "0x6001544")] get; }

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06001545 RID: 5445
		[Token(Token = "0x17000471")]
		TargetInfo TargetInfo { [Token(Token = "0x6001545")] get; }

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06001546 RID: 5446
		[Token(Token = "0x17000472")]
		StructureElement Prefab { [Token(Token = "0x6001546")] get; }

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06001547 RID: 5447
		[Token(Token = "0x17000473")]
		float Delay { [Token(Token = "0x6001547")] get; }

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06001548 RID: 5448
		[Token(Token = "0x17000474")]
		float SmoothDuration { [Token(Token = "0x6001548")] get; }
	}
}
