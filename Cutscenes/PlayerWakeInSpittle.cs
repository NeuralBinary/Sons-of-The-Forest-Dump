using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Cutscenes
{
	// Token: 0x02000798 RID: 1944
	[Token(Token = "0x2000798")]
	[AddComponentMenu("Sons/Player/CustomActions/PlayerWakeInSpittle")]
	public class PlayerWakeInSpittle : PlayerDeathCutsceneBase
	{
		// Token: 0x06003373 RID: 13171 RVA: 0x0000EA30 File Offset: 0x0000CC30
		[Token(Token = "0x6003373")]
		[Address(RVA = "0xC91F50", Offset = "0xC90F50", VA = "0x180C91F50", Slot = "4")]
		public override DeathCutsceneType GetCutsceneType()
		{
			return DeathCutsceneType.Random;
		}

		// Token: 0x06003374 RID: 13172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003374")]
		[Address(RVA = "0x2E65B50", Offset = "0x2E64B50", VA = "0x182E65B50")]
		public static PlayerDeathCutsceneMarker FindClosestMarker(Vector3 position)
		{
			return null;
		}

		// Token: 0x06003375 RID: 13173 RVA: 0x0000EA48 File Offset: 0x0000CC48
		[Token(Token = "0x6003375")]
		[Address(RVA = "0x2E65CE0", Offset = "0x2E64CE0", VA = "0x182E65CE0", Slot = "5")]
		protected override int GetTriggerCutsceneHash()
		{
			return default(int);
		}

		// Token: 0x06003376 RID: 13174 RVA: 0x0000EA60 File Offset: 0x0000CC60
		[Token(Token = "0x6003376")]
		[Address(RVA = "0x2E65C20", Offset = "0x2E64C20", VA = "0x182E65C20", Slot = "6")]
		protected override int GetIntroHash()
		{
			return default(int);
		}

		// Token: 0x06003377 RID: 13175 RVA: 0x0000EA78 File Offset: 0x0000CC78
		[Token(Token = "0x6003377")]
		[Address(RVA = "0x2E65C80", Offset = "0x2E64C80", VA = "0x182E65C80", Slot = "8")]
		protected override int GetOutroHash()
		{
			return default(int);
		}

		// Token: 0x06003378 RID: 13176 RVA: 0x0000EA90 File Offset: 0x0000CC90
		[Token(Token = "0x6003378")]
		[Address(RVA = "0x2E65BC0", Offset = "0x2E64BC0", VA = "0x182E65BC0", Slot = "7")]
		protected override int GetIdleHash()
		{
			return default(int);
		}

		// Token: 0x06003379 RID: 13177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003379")]
		[Address(RVA = "0x2E65D40", Offset = "0x2E64D40", VA = "0x182E65D40", Slot = "13")]
		internal override void PostPlayerSetup()
		{
		}

		// Token: 0x0600337A RID: 13178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600337A")]
		[Address(RVA = "0x2E65D50", Offset = "0x2E64D50", VA = "0x182E65D50")]
		public PlayerWakeInSpittle()
		{
		}

		// Token: 0x04002CAD RID: 11437
		[Token(Token = "0x4002CAD")]
		private const DeathCutsceneType ThisDeathCutsceneType = DeathCutsceneType.InSpittle;
	}
}
