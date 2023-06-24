using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Cutscenes
{
	// Token: 0x020006A7 RID: 1703
	[Token(Token = "0x20006A7")]
	[AddComponentMenu("Sons/Player/CustomActions/PlayerWakeUnderWater")]
	public class PlayerWakeUnderWater : PlayerDeathCutsceneBase
	{
		// Token: 0x06002D0E RID: 11534 RVA: 0x0000D488 File Offset: 0x0000B688
		[Token(Token = "0x6002D0E")]
		[Address(RVA = "0x9FA5F0", Offset = "0x9F8BF0", VA = "0x1809FA5F0", Slot = "4")]
		public override DeathCutsceneType GetCutsceneType()
		{
			return DeathCutsceneType.Random;
		}

		// Token: 0x06002D0F RID: 11535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D0F")]
		[Address(RVA = "0x342FBC0", Offset = "0x342E1C0", VA = "0x18342FBC0")]
		public static PlayerDeathCutsceneMarker FindClosestMarker(Vector3 position)
		{
			return null;
		}

		// Token: 0x06002D10 RID: 11536 RVA: 0x0000D4A0 File Offset: 0x0000B6A0
		[Token(Token = "0x6002D10")]
		[Address(RVA = "0x342FC30", Offset = "0x342E230", VA = "0x18342FC30", Slot = "5")]
		protected override int GetTriggerCutsceneHash()
		{
			return 0;
		}

		// Token: 0x06002D11 RID: 11537 RVA: 0x0000D4B8 File Offset: 0x0000B6B8
		[Token(Token = "0x6002D11")]
		[Address(RVA = "0x342FC90", Offset = "0x342E290", VA = "0x18342FC90", Slot = "6")]
		protected override int GetIntroHash()
		{
			return 0;
		}

		// Token: 0x06002D12 RID: 11538 RVA: 0x0000D4D0 File Offset: 0x0000B6D0
		[Token(Token = "0x6002D12")]
		[Address(RVA = "0x342FCF0", Offset = "0x342E2F0", VA = "0x18342FCF0", Slot = "8")]
		protected override int GetOutroHash()
		{
			return 0;
		}

		// Token: 0x06002D13 RID: 11539 RVA: 0x0000D4E8 File Offset: 0x0000B6E8
		[Token(Token = "0x6002D13")]
		[Address(RVA = "0x342FD50", Offset = "0x342E350", VA = "0x18342FD50", Slot = "7")]
		protected override int GetIdleHash()
		{
			return 0;
		}

		// Token: 0x06002D14 RID: 11540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D14")]
		[Address(RVA = "0x342FDB0", Offset = "0x342E3B0", VA = "0x18342FDB0", Slot = "13")]
		internal override void PostPlayerSetup()
		{
		}

		// Token: 0x06002D15 RID: 11541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D15")]
		[Address(RVA = "0x342FE10", Offset = "0x342E410", VA = "0x18342FE10", Slot = "10")]
		public override IEnumerator SetupUniqueCutsceneProps()
		{
			return null;
		}

		// Token: 0x06002D16 RID: 11542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D16")]
		[Address(RVA = "0x342FEA0", Offset = "0x342E4A0", VA = "0x18342FEA0")]
		private void HideCombatKnife()
		{
		}

		// Token: 0x06002D17 RID: 11543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D17")]
		[Address(RVA = "0x342FFE0", Offset = "0x342E5E0", VA = "0x18342FFE0")]
		private void ShowCombatKnife()
		{
		}

		// Token: 0x06002D18 RID: 11544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D18")]
		[Address(RVA = "0x342FEA0", Offset = "0x342E4A0", VA = "0x18342FEA0", Slot = "12")]
		public override void Cleanup()
		{
		}

		// Token: 0x06002D19 RID: 11545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D19")]
		[Address(RVA = "0x34309A0", Offset = "0x342EFA0", VA = "0x1834309A0")]
		public PlayerWakeUnderWater()
		{
		}

		// Token: 0x04002787 RID: 10119
		[Token(Token = "0x4002787")]
		[FieldOffset(Offset = "0x88")]
		private GameObject _knifeGameObject;

		// Token: 0x04002788 RID: 10120
		[Token(Token = "0x4002788")]
		private const DeathCutsceneType ThisDeathCutsceneType = DeathCutsceneType.UnderWater;
	}
}
