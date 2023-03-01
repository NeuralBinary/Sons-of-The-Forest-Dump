using System;
using Bolt;
using Il2CppDummyDll;
using Sons.Cutscenes;
using UnityEngine;

namespace Sons.Multiplayer
{
	// Token: 0x02000549 RID: 1353
	[Token(Token = "0x2000549")]
	public class CoopDeathCutsceneHandler : EntityBehaviour<IPlayerState>
	{
		// Token: 0x06002338 RID: 9016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002338")]
		[Address(RVA = "0x2D5DDA0", Offset = "0x2D5CDA0", VA = "0x182D5DDA0")]
		private void OnValidate()
		{
		}

		// Token: 0x06002339 RID: 9017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002339")]
		[Address(RVA = "0x2D5D930", Offset = "0x2D5C930", VA = "0x182D5D930", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x0600233A RID: 9018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600233A")]
		[Address(RVA = "0x2D5DCC0", Offset = "0x2D5CCC0", VA = "0x182D5DCC0")]
		private void OnTiedUpStateChange()
		{
		}

		// Token: 0x0600233B RID: 9019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600233B")]
		[Address(RVA = "0x2D5DAA0", Offset = "0x2D5CAA0", VA = "0x182D5DAA0")]
		private void OnMarkerHashChange()
		{
		}

		// Token: 0x0600233C RID: 9020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600233C")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		private void OnCutsceneCompleted(PlayerDeathCutsceneMarker marker)
		{
		}

		// Token: 0x0600233D RID: 9021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600233D")]
		[Address(RVA = "0x2D5DEE0", Offset = "0x2D5CEE0", VA = "0x182D5DEE0")]
		public CoopDeathCutsceneHandler()
		{
		}

		// Token: 0x04001FBD RID: 8125
		[Token(Token = "0x4001FBD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x04001FBE RID: 8126
		[Token(Token = "0x4001FBE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private PlayerWakeOnEffigy _wakeOnEffigyController;

		// Token: 0x04001FBF RID: 8127
		[Token(Token = "0x4001FBF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private PlayerWakeInSpittle _wakeInSpittleController;

		// Token: 0x04001FC0 RID: 8128
		[Token(Token = "0x4001FC0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private PlayerWakeUnderWater _wakeUnderWaterController;

		// Token: 0x04001FC1 RID: 8129
		[Token(Token = "0x4001FC1")]
		[FieldOffset(Offset = "0x48")]
		private DeathCutsceneType _activeTiedUpState;

		// Token: 0x04001FC2 RID: 8130
		[Token(Token = "0x4001FC2")]
		[FieldOffset(Offset = "0x4C")]
		private int _markerHash;
	}
}
