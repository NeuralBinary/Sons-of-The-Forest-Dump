using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Cutscenes
{
	// Token: 0x02000799 RID: 1945
	[Token(Token = "0x2000799")]
	[AddComponentMenu("Sons/Player/CustomActions/PlayerWakeOnEffigy")]
	public class PlayerWakeOnEffigy : PlayerDeathCutsceneBase
	{
		// Token: 0x0600337B RID: 13179 RVA: 0x0000EAA8 File Offset: 0x0000CCA8
		[Token(Token = "0x600337B")]
		[Address(RVA = "0x6206B0", Offset = "0x61F6B0", VA = "0x1806206B0", Slot = "4")]
		public override DeathCutsceneType GetCutsceneType()
		{
			return DeathCutsceneType.Random;
		}

		// Token: 0x0600337C RID: 13180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600337C")]
		[Address(RVA = "0x2E65E50", Offset = "0x2E64E50", VA = "0x182E65E50")]
		public static PlayerDeathCutsceneMarker FindClosestMarker(Vector3 position)
		{
			return null;
		}

		// Token: 0x0600337D RID: 13181 RVA: 0x0000EAC0 File Offset: 0x0000CCC0
		[Token(Token = "0x600337D")]
		[Address(RVA = "0x2E65FE0", Offset = "0x2E64FE0", VA = "0x182E65FE0", Slot = "5")]
		protected override int GetTriggerCutsceneHash()
		{
			return default(int);
		}

		// Token: 0x0600337E RID: 13182 RVA: 0x0000EAD8 File Offset: 0x0000CCD8
		[Token(Token = "0x600337E")]
		[Address(RVA = "0x2E65F20", Offset = "0x2E64F20", VA = "0x182E65F20", Slot = "6")]
		protected override int GetIntroHash()
		{
			return default(int);
		}

		// Token: 0x0600337F RID: 13183 RVA: 0x0000EAF0 File Offset: 0x0000CCF0
		[Token(Token = "0x600337F")]
		[Address(RVA = "0x2E65F80", Offset = "0x2E64F80", VA = "0x182E65F80", Slot = "8")]
		protected override int GetOutroHash()
		{
			return default(int);
		}

		// Token: 0x06003380 RID: 13184 RVA: 0x0000EB08 File Offset: 0x0000CD08
		[Token(Token = "0x6003380")]
		[Address(RVA = "0x2E65EC0", Offset = "0x2E64EC0", VA = "0x182E65EC0", Slot = "7")]
		protected override int GetIdleHash()
		{
			return default(int);
		}

		// Token: 0x06003381 RID: 13185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003381")]
		[Address(RVA = "0x2E66120", Offset = "0x2E65120", VA = "0x182E66120", Slot = "10")]
		public override IEnumerator SetupUniqueCutsceneProps()
		{
			return null;
		}

		// Token: 0x06003382 RID: 13186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003382")]
		[Address(RVA = "0x2E65D40", Offset = "0x2E64D40", VA = "0x182E65D40", Slot = "13")]
		internal override void PostPlayerSetup()
		{
		}

		// Token: 0x06003383 RID: 13187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003383")]
		[Address(RVA = "0x2E65DA0", Offset = "0x2E64DA0", VA = "0x182E65DA0")]
		private void HideCombatKnife()
		{
		}

		// Token: 0x06003384 RID: 13188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003384")]
		[Address(RVA = "0x2E66190", Offset = "0x2E65190", VA = "0x182E66190")]
		private void ShowCombatKnife()
		{
		}

		// Token: 0x06003385 RID: 13189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003385")]
		[Address(RVA = "0x2E66040", Offset = "0x2E65040", VA = "0x182E66040")]
		private void InitializeKnifeProp()
		{
		}

		// Token: 0x06003386 RID: 13190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003386")]
		[Address(RVA = "0x2E65DA0", Offset = "0x2E64DA0", VA = "0x182E65DA0", Slot = "12")]
		public override void Cleanup()
		{
		}

		// Token: 0x06003387 RID: 13191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003387")]
		[Address(RVA = "0x2E663A0", Offset = "0x2E653A0", VA = "0x182E663A0")]
		public PlayerWakeOnEffigy()
		{
		}

		// Token: 0x04002CAE RID: 11438
		[Token(Token = "0x4002CAE")]
		[FieldOffset(Offset = "0x88")]
		private GameObject _knifeGameObject;

		// Token: 0x04002CAF RID: 11439
		[Token(Token = "0x4002CAF")]
		private const DeathCutsceneType ThisDeathCutsceneType = DeathCutsceneType.OnEffigy;
	}
}
