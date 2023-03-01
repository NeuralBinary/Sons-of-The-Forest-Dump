using System;
using Bolt;
using Il2CppDummyDll;

namespace Sons.TerrainDetail
{
	// Token: 0x02000515 RID: 1301
	[Token(Token = "0x2000515")]
	[BoltGlobalBehaviour]
	public class WorldObjectLocatorManagerNetworkCallbacks : GlobalEventListener
	{
		// Token: 0x060021E5 RID: 8677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021E5")]
		[Address(RVA = "0x2D72750", Offset = "0x2D71750", VA = "0x182D72750")]
		private void Awake()
		{
		}

		// Token: 0x060021E6 RID: 8678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021E6")]
		[Address(RVA = "0x2D72830", Offset = "0x2D71830", VA = "0x182D72830")]
		private void OnDestroy()
		{
		}

		// Token: 0x060021E7 RID: 8679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021E7")]
		[Address(RVA = "0x2D72C70", Offset = "0x2D71C70", VA = "0x182D72C70")]
		private void OnFinishedLoadingMainScene(object _)
		{
		}

		// Token: 0x060021E8 RID: 8680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021E8")]
		[Address(RVA = "0x2D72D80", Offset = "0x2D71D80", VA = "0x182D72D80")]
		private static void RequestAllWorldObjectLocatorData()
		{
		}

		// Token: 0x060021E9 RID: 8681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021E9")]
		[Address(RVA = "0x2D72C10", Offset = "0x2D71C10", VA = "0x182D72C10", Slot = "298")]
		public override void OnEvent(WorldObjectLocatorRequestAllData boltEvent)
		{
		}

		// Token: 0x060021EA RID: 8682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021EA")]
		[Address(RVA = "0x2D72930", Offset = "0x2D71930", VA = "0x182D72930", Slot = "296")]
		public override void OnEvent(WorldObjectLocatorState boltEvent)
		{
		}

		// Token: 0x060021EB RID: 8683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021EB")]
		[Address(RVA = "0x122BAB0", Offset = "0x122AAB0", VA = "0x18122BAB0")]
		public WorldObjectLocatorManagerNetworkCallbacks()
		{
		}

		// Token: 0x04001F09 RID: 7945
		[Token(Token = "0x4001F09")]
		private const int BlobChannel = 2;
	}
}
