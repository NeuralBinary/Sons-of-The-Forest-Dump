using System;
using Bolt;
using Il2CppDummyDll;

namespace Sons.Characters
{
	// Token: 0x02000737 RID: 1847
	[Token(Token = "0x2000737")]
	[BoltGlobalBehaviour]
	public class VillageManagerNetworkCallbacks : GlobalEventListener
	{
		// Token: 0x06003158 RID: 12632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003158")]
		[Address(RVA = "0x34886D0", Offset = "0x3486CD0", VA = "0x1834886D0")]
		private void Awake()
		{
		}

		// Token: 0x06003159 RID: 12633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003159")]
		[Address(RVA = "0x34887B0", Offset = "0x3486DB0", VA = "0x1834887B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600315A RID: 12634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600315A")]
		[Address(RVA = "0x34888B0", Offset = "0x3486EB0", VA = "0x1834888B0")]
		private void OnFinishedLoadingMainScene(object _)
		{
		}

		// Token: 0x0600315B RID: 12635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600315B")]
		[Address(RVA = "0x3488A40", Offset = "0x3487040", VA = "0x183488A40")]
		private static void RequestAllVillageData()
		{
		}

		// Token: 0x0600315C RID: 12636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600315C")]
		[Address(RVA = "0x3488B00", Offset = "0x3487100", VA = "0x183488B00", Slot = "340")]
		public override void OnEvent(VailRequestVillageData boltEvent)
		{
		}

		// Token: 0x0600315D RID: 12637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600315D")]
		[Address(RVA = "0x144EB80", Offset = "0x144D180", VA = "0x18144EB80")]
		public VillageManagerNetworkCallbacks()
		{
		}

		// Token: 0x04002A92 RID: 10898
		[Token(Token = "0x4002A92")]
		private const int BlobChannel = 3;
	}
}
