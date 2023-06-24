using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x020000AB RID: 171
	[Token(Token = "0x20000AB")]
	internal abstract class NetworkProperty_Mecanim : NetworkProperty
	{
		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000544 RID: 1348 RVA: 0x00003B10 File Offset: 0x00001D10
		[Token(Token = "0x17000103")]
		public override bool WantsOnSimulateAfter
		{
			[Token(Token = "0x6000544")]
			[Address(RVA = "0x8EC310", Offset = "0x8EA910", VA = "0x1808EC310", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000545")]
		[Address(RVA = "0x8EC320", Offset = "0x8EA920", VA = "0x1808EC320")]
		public void Settings_Mecanim(MecanimMode mode, MecanimDirection direction, float damping, int layer)
		{
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000546")]
		[Address(RVA = "0x8EC340", Offset = "0x8EA940", VA = "0x1808EC340", Slot = "19")]
		public override void OnSimulateAfter(NetworkObj obj)
		{
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00003B28 File Offset: 0x00001D28
		[Token(Token = "0x6000547")]
		[Address(RVA = "0x8EC7C0", Offset = "0x8EADC0", VA = "0x1808EC7C0")]
		protected bool ShouldPullDataFromMecanim(NetworkState state)
		{
			return default(bool);
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000548")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "25")]
		protected virtual void PullMecanimValue(NetworkState state)
		{
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000549")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "26")]
		protected virtual void PushMecanimValue(NetworkState state)
		{
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600054A")]
		[Address(RVA = "0x8EC800", Offset = "0x8EAE00", VA = "0x1808EC800")]
		private void PullMecanimLayer(NetworkState state)
		{
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600054B")]
		[Address(RVA = "0x8ECA40", Offset = "0x8EB040", VA = "0x1808ECA40")]
		private void PushMecanimLayer(NetworkState state)
		{
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600054C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		protected NetworkProperty_Mecanim()
		{
		}

		// Token: 0x04000283 RID: 643
		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0x48")]
		public MecanimMode MecanimMode;

		// Token: 0x04000284 RID: 644
		[Token(Token = "0x4000284")]
		[FieldOffset(Offset = "0x4C")]
		public MecanimDirection MecanimDirection;

		// Token: 0x04000285 RID: 645
		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0x50")]
		public float MecanimDamping;

		// Token: 0x04000286 RID: 646
		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0x54")]
		public int MecanimLayer;
	}
}
