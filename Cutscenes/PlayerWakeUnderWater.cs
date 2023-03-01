using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Cutscenes
{
	// Token: 0x0200079C RID: 1948
	[Token(Token = "0x200079C")]
	[AddComponentMenu("Sons/Player/CustomActions/PlayerWakeUnderWater")]
	public class PlayerWakeUnderWater : PlayerDeathCutsceneBase
	{
		// Token: 0x06003396 RID: 13206 RVA: 0x0000EBB0 File Offset: 0x0000CDB0
		[Token(Token = "0x6003396")]
		[Address(RVA = "0x8BBDF0", Offset = "0x8BADF0", VA = "0x1808BBDF0", Slot = "4")]
		public override DeathCutsceneType GetCutsceneType()
		{
			return DeathCutsceneType.Random;
		}

		// Token: 0x06003397 RID: 13207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003397")]
		[Address(RVA = "0x2E666E0", Offset = "0x2E656E0", VA = "0x182E666E0")]
		public static PlayerDeathCutsceneMarker FindClosestMarker(Vector3 position)
		{
			return null;
		}

		// Token: 0x06003398 RID: 13208 RVA: 0x0000EBC8 File Offset: 0x0000CDC8
		[Token(Token = "0x6003398")]
		[Address(RVA = "0x2E66870", Offset = "0x2E65870", VA = "0x182E66870", Slot = "5")]
		protected override int GetTriggerCutsceneHash()
		{
			return default(int);
		}

		// Token: 0x06003399 RID: 13209 RVA: 0x0000EBE0 File Offset: 0x0000CDE0
		[Token(Token = "0x6003399")]
		[Address(RVA = "0x2E667B0", Offset = "0x2E657B0", VA = "0x182E667B0", Slot = "6")]
		protected override int GetIntroHash()
		{
			return default(int);
		}

		// Token: 0x0600339A RID: 13210 RVA: 0x0000EBF8 File Offset: 0x0000CDF8
		[Token(Token = "0x600339A")]
		[Address(RVA = "0x2E66810", Offset = "0x2E65810", VA = "0x182E66810", Slot = "8")]
		protected override int GetOutroHash()
		{
			return default(int);
		}

		// Token: 0x0600339B RID: 13211 RVA: 0x0000EC10 File Offset: 0x0000CE10
		[Token(Token = "0x600339B")]
		[Address(RVA = "0x2E66750", Offset = "0x2E65750", VA = "0x182E66750", Slot = "7")]
		protected override int GetIdleHash()
		{
			return default(int);
		}

		// Token: 0x0600339C RID: 13212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600339C")]
		[Address(RVA = "0x2E668D0", Offset = "0x2E658D0", VA = "0x182E668D0", Slot = "13")]
		internal override void PostPlayerSetup()
		{
		}

		// Token: 0x0600339D RID: 13213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600339D")]
		[Address(RVA = "0x2E66930", Offset = "0x2E65930", VA = "0x182E66930", Slot = "10")]
		public override IEnumerator SetupUniqueCutsceneProps()
		{
			return null;
		}

		// Token: 0x0600339E RID: 13214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600339E")]
		[Address(RVA = "0x2E66630", Offset = "0x2E65630", VA = "0x182E66630")]
		private void HideCombatKnife()
		{
		}

		// Token: 0x0600339F RID: 13215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600339F")]
		[Address(RVA = "0x2E669A0", Offset = "0x2E659A0", VA = "0x182E669A0")]
		private void ShowCombatKnife()
		{
		}

		// Token: 0x060033A0 RID: 13216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033A0")]
		[Address(RVA = "0x2E66630", Offset = "0x2E65630", VA = "0x182E66630", Slot = "12")]
		public override void Cleanup()
		{
		}

		// Token: 0x060033A1 RID: 13217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033A1")]
		[Address(RVA = "0x2E66BA0", Offset = "0x2E65BA0", VA = "0x182E66BA0")]
		public PlayerWakeUnderWater()
		{
		}

		// Token: 0x04002CB4 RID: 11444
		[Token(Token = "0x4002CB4")]
		[FieldOffset(Offset = "0x88")]
		private GameObject _knifeGameObject;

		// Token: 0x04002CB5 RID: 11445
		[Token(Token = "0x4002CB5")]
		private const DeathCutsceneType ThisDeathCutsceneType = DeathCutsceneType.UnderWater;
	}
}
