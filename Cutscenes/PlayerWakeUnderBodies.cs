using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Cutscenes
{
	// Token: 0x0200079B RID: 1947
	[Token(Token = "0x200079B")]
	[AddComponentMenu("Sons/Player/CustomActions/PlayerWakeUnderBodies")]
	public class PlayerWakeUnderBodies : PlayerDeathCutsceneBase
	{
		// Token: 0x0600338E RID: 13198 RVA: 0x0000EB38 File Offset: 0x0000CD38
		[Token(Token = "0x600338E")]
		[Address(RVA = "0x8B5F90", Offset = "0x8B4F90", VA = "0x1808B5F90", Slot = "4")]
		public override DeathCutsceneType GetCutsceneType()
		{
			return DeathCutsceneType.Random;
		}

		// Token: 0x0600338F RID: 13199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600338F")]
		[Address(RVA = "0x2E663F0", Offset = "0x2E653F0", VA = "0x182E663F0")]
		public static PlayerDeathCutsceneMarker FindClosestMarker(Vector3 position)
		{
			return null;
		}

		// Token: 0x06003390 RID: 13200 RVA: 0x0000EB50 File Offset: 0x0000CD50
		[Token(Token = "0x6003390")]
		[Address(RVA = "0x2E66580", Offset = "0x2E65580", VA = "0x182E66580", Slot = "5")]
		protected override int GetTriggerCutsceneHash()
		{
			return default(int);
		}

		// Token: 0x06003391 RID: 13201 RVA: 0x0000EB68 File Offset: 0x0000CD68
		[Token(Token = "0x6003391")]
		[Address(RVA = "0x2E664C0", Offset = "0x2E654C0", VA = "0x182E664C0", Slot = "6")]
		protected override int GetIntroHash()
		{
			return default(int);
		}

		// Token: 0x06003392 RID: 13202 RVA: 0x0000EB80 File Offset: 0x0000CD80
		[Token(Token = "0x6003392")]
		[Address(RVA = "0x2E66520", Offset = "0x2E65520", VA = "0x182E66520", Slot = "8")]
		protected override int GetOutroHash()
		{
			return default(int);
		}

		// Token: 0x06003393 RID: 13203 RVA: 0x0000EB98 File Offset: 0x0000CD98
		[Token(Token = "0x6003393")]
		[Address(RVA = "0x2E66460", Offset = "0x2E65460", VA = "0x182E66460", Slot = "7")]
		protected override int GetIdleHash()
		{
			return default(int);
		}

		// Token: 0x06003394 RID: 13204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003394")]
		[Address(RVA = "0x2E65D40", Offset = "0x2E64D40", VA = "0x182E65D40", Slot = "13")]
		internal override void PostPlayerSetup()
		{
		}

		// Token: 0x06003395 RID: 13205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003395")]
		[Address(RVA = "0x2E665E0", Offset = "0x2E655E0", VA = "0x182E665E0")]
		public PlayerWakeUnderBodies()
		{
		}

		// Token: 0x04002CB3 RID: 11443
		[Token(Token = "0x4002CB3")]
		private const DeathCutsceneType ThisDeathCutsceneType = DeathCutsceneType.UnderBodies;
	}
}
