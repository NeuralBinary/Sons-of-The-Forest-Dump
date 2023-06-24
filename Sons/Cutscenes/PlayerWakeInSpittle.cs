using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Cutscenes
{
	// Token: 0x020006A3 RID: 1699
	[Token(Token = "0x20006A3")]
	[AddComponentMenu("Sons/Player/CustomActions/PlayerWakeInSpittle")]
	public class PlayerWakeInSpittle : PlayerDeathCutsceneBase
	{
		// Token: 0x06002CEB RID: 11499 RVA: 0x0000D308 File Offset: 0x0000B508
		[Token(Token = "0x6002CEB")]
		[Address(RVA = "0xE51980", Offset = "0xE4FF80", VA = "0x180E51980", Slot = "4")]
		public override DeathCutsceneType GetCutsceneType()
		{
			return DeathCutsceneType.Random;
		}

		// Token: 0x06002CEC RID: 11500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CEC")]
		[Address(RVA = "0x342E820", Offset = "0x342CE20", VA = "0x18342E820")]
		public static PlayerDeathCutsceneMarker FindClosestMarker(Vector3 position)
		{
			return null;
		}

		// Token: 0x06002CED RID: 11501 RVA: 0x0000D320 File Offset: 0x0000B520
		[Token(Token = "0x6002CED")]
		[Address(RVA = "0x342E890", Offset = "0x342CE90", VA = "0x18342E890", Slot = "5")]
		protected override int GetTriggerCutsceneHash()
		{
			return 0;
		}

		// Token: 0x06002CEE RID: 11502 RVA: 0x0000D338 File Offset: 0x0000B538
		[Token(Token = "0x6002CEE")]
		[Address(RVA = "0x342E8F0", Offset = "0x342CEF0", VA = "0x18342E8F0", Slot = "6")]
		protected override int GetIntroHash()
		{
			return 0;
		}

		// Token: 0x06002CEF RID: 11503 RVA: 0x0000D350 File Offset: 0x0000B550
		[Token(Token = "0x6002CEF")]
		[Address(RVA = "0x342E950", Offset = "0x342CF50", VA = "0x18342E950", Slot = "8")]
		protected override int GetOutroHash()
		{
			return 0;
		}

		// Token: 0x06002CF0 RID: 11504 RVA: 0x0000D368 File Offset: 0x0000B568
		[Token(Token = "0x6002CF0")]
		[Address(RVA = "0x342E9B0", Offset = "0x342CFB0", VA = "0x18342E9B0", Slot = "7")]
		protected override int GetIdleHash()
		{
			return 0;
		}

		// Token: 0x06002CF1 RID: 11505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CF1")]
		[Address(RVA = "0x342EA10", Offset = "0x342D010", VA = "0x18342EA10", Slot = "13")]
		internal override void PostPlayerSetup()
		{
		}

		// Token: 0x06002CF2 RID: 11506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CF2")]
		[Address(RVA = "0x342EA20", Offset = "0x342D020", VA = "0x18342EA20")]
		public PlayerWakeInSpittle()
		{
		}

		// Token: 0x04002780 RID: 10112
		[Token(Token = "0x4002780")]
		private const DeathCutsceneType ThisDeathCutsceneType = DeathCutsceneType.InSpittle;
	}
}
