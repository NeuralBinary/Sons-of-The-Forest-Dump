using System;
using Bolt;
using Il2CppDummyDll;

namespace Sons.Characters
{
	// Token: 0x02000824 RID: 2084
	[Token(Token = "0x2000824")]
	[BoltGlobalBehaviour]
	public class VillageManagerNetworkCallbacks : GlobalEventListener
	{
		// Token: 0x06003775 RID: 14197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003775")]
		[Address(RVA = "0x2EC1AF0", Offset = "0x2EC0AF0", VA = "0x182EC1AF0")]
		private void Awake()
		{
		}

		// Token: 0x06003776 RID: 14198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003776")]
		[Address(RVA = "0x2EC1BD0", Offset = "0x2EC0BD0", VA = "0x182EC1BD0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003777 RID: 14199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003777")]
		[Address(RVA = "0x2EC1D30", Offset = "0x2EC0D30", VA = "0x182EC1D30")]
		private void OnFinishedLoadingMainScene(object _)
		{
		}

		// Token: 0x06003778 RID: 14200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003778")]
		[Address(RVA = "0x2EC1E90", Offset = "0x2EC0E90", VA = "0x182EC1E90")]
		private static void RequestAllVillageData()
		{
		}

		// Token: 0x06003779 RID: 14201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003779")]
		[Address(RVA = "0x2EC1CD0", Offset = "0x2EC0CD0", VA = "0x182EC1CD0", Slot = "322")]
		public override void OnEvent(VailRequestVillageData boltEvent)
		{
		}

		// Token: 0x0600377A RID: 14202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600377A")]
		[Address(RVA = "0x122BAB0", Offset = "0x122AAB0", VA = "0x18122BAB0")]
		public VillageManagerNetworkCallbacks()
		{
		}

		// Token: 0x04002F76 RID: 12150
		[Token(Token = "0x4002F76")]
		private const int BlobChannel = 3;
	}
}
