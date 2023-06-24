using System;
using Bolt;
using Il2CppDummyDll;
using Sons.Cutscenes;
using UnityEngine;

namespace Sons.Multiplayer
{
	// Token: 0x02000553 RID: 1363
	[Token(Token = "0x2000553")]
	public class CoopDeathCutsceneHandler : EntityBehaviour<IPlayerState>
	{
		// Token: 0x0600242D RID: 9261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600242D")]
		[Address(RVA = "0x3383660", Offset = "0x3381C60", VA = "0x183383660")]
		private void OnValidate()
		{
		}

		// Token: 0x0600242E RID: 9262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600242E")]
		[Address(RVA = "0x33839A0", Offset = "0x3381FA0", VA = "0x1833839A0", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x0600242F RID: 9263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600242F")]
		[Address(RVA = "0x3383B40", Offset = "0x3382140", VA = "0x183383B40")]
		private void OnTiedUpStateChange()
		{
		}

		// Token: 0x06002430 RID: 9264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002430")]
		[Address(RVA = "0x3383C50", Offset = "0x3382250", VA = "0x183383C50")]
		private void OnMarkerHashChange()
		{
		}

		// Token: 0x06002431 RID: 9265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002431")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void OnCutsceneCompleted(PlayerDeathCutsceneMarker marker)
		{
		}

		// Token: 0x06002432 RID: 9266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002432")]
		[Address(RVA = "0x3383E90", Offset = "0x3382490", VA = "0x183383E90")]
		public CoopDeathCutsceneHandler()
		{
		}

		// Token: 0x04002077 RID: 8311
		[Token(Token = "0x4002077")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x04002078 RID: 8312
		[Token(Token = "0x4002078")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private PlayerWakeOnEffigy _wakeOnEffigyController;

		// Token: 0x04002079 RID: 8313
		[Token(Token = "0x4002079")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private PlayerWakeInSpittle _wakeInSpittleController;

		// Token: 0x0400207A RID: 8314
		[Token(Token = "0x400207A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private PlayerWakeUnderWater _wakeUnderWaterController;

		// Token: 0x0400207B RID: 8315
		[Token(Token = "0x400207B")]
		[FieldOffset(Offset = "0x48")]
		private DeathCutsceneType _activeTiedUpState;

		// Token: 0x0400207C RID: 8316
		[Token(Token = "0x400207C")]
		[FieldOffset(Offset = "0x4C")]
		private int _markerHash;
	}
}
