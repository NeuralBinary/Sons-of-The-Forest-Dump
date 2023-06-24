using System;
using Bolt;
using Il2CppDummyDll;

namespace Sons.TerrainDetail
{
	// Token: 0x0200051D RID: 1309
	[Token(Token = "0x200051D")]
	[BoltGlobalBehaviour]
	public class WorldObjectLocatorManagerNetworkCallbacks : GlobalEventListener
	{
		// Token: 0x060022D0 RID: 8912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022D0")]
		[Address(RVA = "0x3346010", Offset = "0x3344610", VA = "0x183346010")]
		private void Awake()
		{
		}

		// Token: 0x060022D1 RID: 8913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022D1")]
		[Address(RVA = "0x33460F0", Offset = "0x33446F0", VA = "0x1833460F0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060022D2 RID: 8914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022D2")]
		[Address(RVA = "0x33461F0", Offset = "0x33447F0", VA = "0x1833461F0")]
		private void OnFinishedLoadingMainScene(object _)
		{
		}

		// Token: 0x060022D3 RID: 8915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022D3")]
		[Address(RVA = "0x3346330", Offset = "0x3344930", VA = "0x183346330")]
		private static void RequestAllWorldObjectLocatorData()
		{
		}

		// Token: 0x060022D4 RID: 8916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022D4")]
		[Address(RVA = "0x33463F0", Offset = "0x33449F0", VA = "0x1833463F0", Slot = "316")]
		public override void OnEvent(WorldObjectLocatorRequestAllData boltEvent)
		{
		}

		// Token: 0x060022D5 RID: 8917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022D5")]
		[Address(RVA = "0x3346450", Offset = "0x3344A50", VA = "0x183346450", Slot = "314")]
		public override void OnEvent(WorldObjectLocatorState boltEvent)
		{
		}

		// Token: 0x060022D6 RID: 8918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022D6")]
		[Address(RVA = "0x144EB80", Offset = "0x144D180", VA = "0x18144EB80")]
		public WorldObjectLocatorManagerNetworkCallbacks()
		{
		}

		// Token: 0x04001FBD RID: 8125
		[Token(Token = "0x4001FBD")]
		private const int BlobChannel = 2;
	}
}
