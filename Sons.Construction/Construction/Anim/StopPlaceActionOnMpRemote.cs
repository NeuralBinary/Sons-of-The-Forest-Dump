using System;
using Construction.Multiplayer;
using Il2CppDummyDll;

namespace Construction.Anim
{
	// Token: 0x020002DC RID: 732
	[Token(Token = "0x20002DC")]
	public class StopPlaceActionOnMpRemote : IStoppedPlaceActionReceiver
	{
		// Token: 0x06001666 RID: 5734 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001666")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public StopPlaceActionOnMpRemote(FreeFormPlayerNetworkAnimation networkAnimation)
		{
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001667")]
		[Address(RVA = "0x2E0A560", Offset = "0x2E08B60", VA = "0x182E0A560", Slot = "4")]
		private void StoppedPlaceAction(AnimStatus status)
		{
		}

		// Token: 0x04000AFE RID: 2814
		[Token(Token = "0x4000AFE")]
		[FieldOffset(Offset = "0x10")]
		private readonly FreeFormPlayerNetworkAnimation _networkAnimation;
	}
}
