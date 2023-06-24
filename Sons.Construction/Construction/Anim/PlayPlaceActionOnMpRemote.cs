using System;
using Construction.Multiplayer;
using Il2CppDummyDll;

namespace Construction.Anim
{
	// Token: 0x020002DB RID: 731
	[Token(Token = "0x20002DB")]
	public class PlayPlaceActionOnMpRemote : IBeginPlaceActionReceiver
	{
		// Token: 0x06001664 RID: 5732 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001664")]
		[Address(RVA = "0x2195090", Offset = "0x2193690", VA = "0x182195090")]
		public PlayPlaceActionOnMpRemote(FreeFormPlayerNetworkAnimation networkAnimation, ConstructionManager manager)
		{
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001665")]
		[Address(RVA = "0x2E0A4C0", Offset = "0x2E08AC0", VA = "0x182E0A4C0", Slot = "4")]
		private void BeginPlaceAction(TargetInfo targetInfo, IConstructionModule module, StructureElement elementPrefab, int placementMode)
		{
		}

		// Token: 0x04000AFC RID: 2812
		[Token(Token = "0x4000AFC")]
		[FieldOffset(Offset = "0x10")]
		private readonly ConstructionManager _manager;

		// Token: 0x04000AFD RID: 2813
		[Token(Token = "0x4000AFD")]
		[FieldOffset(Offset = "0x18")]
		private readonly FreeFormPlayerNetworkAnimation _networkAnimation;
	}
}
