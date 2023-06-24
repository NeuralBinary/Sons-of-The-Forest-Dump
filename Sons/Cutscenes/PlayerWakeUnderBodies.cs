using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Cutscenes
{
	// Token: 0x020006A6 RID: 1702
	[Token(Token = "0x20006A6")]
	[AddComponentMenu("Sons/Player/CustomActions/PlayerWakeUnderBodies")]
	public class PlayerWakeUnderBodies : PlayerDeathCutsceneBase
	{
		// Token: 0x06002D06 RID: 11526 RVA: 0x0000D410 File Offset: 0x0000B610
		[Token(Token = "0x6002D06")]
		[Address(RVA = "0x9E1E00", Offset = "0x9E0400", VA = "0x1809E1E00", Slot = "4")]
		public override DeathCutsceneType GetCutsceneType()
		{
			return DeathCutsceneType.Random;
		}

		// Token: 0x06002D07 RID: 11527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D07")]
		[Address(RVA = "0x342F980", Offset = "0x342DF80", VA = "0x18342F980")]
		public static PlayerDeathCutsceneMarker FindClosestMarker(Vector3 position)
		{
			return null;
		}

		// Token: 0x06002D08 RID: 11528 RVA: 0x0000D428 File Offset: 0x0000B628
		[Token(Token = "0x6002D08")]
		[Address(RVA = "0x342F9F0", Offset = "0x342DFF0", VA = "0x18342F9F0", Slot = "5")]
		protected override int GetTriggerCutsceneHash()
		{
			return 0;
		}

		// Token: 0x06002D09 RID: 11529 RVA: 0x0000D440 File Offset: 0x0000B640
		[Token(Token = "0x6002D09")]
		[Address(RVA = "0x342FA50", Offset = "0x342E050", VA = "0x18342FA50", Slot = "6")]
		protected override int GetIntroHash()
		{
			return 0;
		}

		// Token: 0x06002D0A RID: 11530 RVA: 0x0000D458 File Offset: 0x0000B658
		[Token(Token = "0x6002D0A")]
		[Address(RVA = "0x342FAB0", Offset = "0x342E0B0", VA = "0x18342FAB0", Slot = "8")]
		protected override int GetOutroHash()
		{
			return 0;
		}

		// Token: 0x06002D0B RID: 11531 RVA: 0x0000D470 File Offset: 0x0000B670
		[Token(Token = "0x6002D0B")]
		[Address(RVA = "0x342FB10", Offset = "0x342E110", VA = "0x18342FB10", Slot = "7")]
		protected override int GetIdleHash()
		{
			return 0;
		}

		// Token: 0x06002D0C RID: 11532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D0C")]
		[Address(RVA = "0x342EA10", Offset = "0x342D010", VA = "0x18342EA10", Slot = "13")]
		internal override void PostPlayerSetup()
		{
		}

		// Token: 0x06002D0D RID: 11533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D0D")]
		[Address(RVA = "0x342FB70", Offset = "0x342E170", VA = "0x18342FB70")]
		public PlayerWakeUnderBodies()
		{
		}

		// Token: 0x04002786 RID: 10118
		[Token(Token = "0x4002786")]
		private const DeathCutsceneType ThisDeathCutsceneType = DeathCutsceneType.UnderBodies;
	}
}
