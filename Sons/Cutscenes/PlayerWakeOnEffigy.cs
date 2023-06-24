using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Cutscenes
{
	// Token: 0x020006A4 RID: 1700
	[Token(Token = "0x20006A4")]
	[AddComponentMenu("Sons/Player/CustomActions/PlayerWakeOnEffigy")]
	public class PlayerWakeOnEffigy : PlayerDeathCutsceneBase
	{
		// Token: 0x06002CF3 RID: 11507 RVA: 0x0000D380 File Offset: 0x0000B580
		[Token(Token = "0x6002CF3")]
		[Address(RVA = "0x6A2B30", Offset = "0x6A1130", VA = "0x1806A2B30", Slot = "4")]
		public override DeathCutsceneType GetCutsceneType()
		{
			return DeathCutsceneType.Random;
		}

		// Token: 0x06002CF4 RID: 11508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CF4")]
		[Address(RVA = "0x342EA70", Offset = "0x342D070", VA = "0x18342EA70")]
		public static PlayerDeathCutsceneMarker FindClosestMarker(Vector3 position)
		{
			return null;
		}

		// Token: 0x06002CF5 RID: 11509 RVA: 0x0000D398 File Offset: 0x0000B598
		[Token(Token = "0x6002CF5")]
		[Address(RVA = "0x342EAE0", Offset = "0x342D0E0", VA = "0x18342EAE0", Slot = "5")]
		protected override int GetTriggerCutsceneHash()
		{
			return 0;
		}

		// Token: 0x06002CF6 RID: 11510 RVA: 0x0000D3B0 File Offset: 0x0000B5B0
		[Token(Token = "0x6002CF6")]
		[Address(RVA = "0x342EB40", Offset = "0x342D140", VA = "0x18342EB40", Slot = "6")]
		protected override int GetIntroHash()
		{
			return 0;
		}

		// Token: 0x06002CF7 RID: 11511 RVA: 0x0000D3C8 File Offset: 0x0000B5C8
		[Token(Token = "0x6002CF7")]
		[Address(RVA = "0x342EBA0", Offset = "0x342D1A0", VA = "0x18342EBA0", Slot = "8")]
		protected override int GetOutroHash()
		{
			return 0;
		}

		// Token: 0x06002CF8 RID: 11512 RVA: 0x0000D3E0 File Offset: 0x0000B5E0
		[Token(Token = "0x6002CF8")]
		[Address(RVA = "0x342EC00", Offset = "0x342D200", VA = "0x18342EC00", Slot = "7")]
		protected override int GetIdleHash()
		{
			return 0;
		}

		// Token: 0x06002CF9 RID: 11513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CF9")]
		[Address(RVA = "0x342EC60", Offset = "0x342D260", VA = "0x18342EC60", Slot = "10")]
		public override IEnumerator SetupUniqueCutsceneProps()
		{
			return null;
		}

		// Token: 0x06002CFA RID: 11514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CFA")]
		[Address(RVA = "0x342EA10", Offset = "0x342D010", VA = "0x18342EA10", Slot = "13")]
		internal override void PostPlayerSetup()
		{
		}

		// Token: 0x06002CFB RID: 11515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CFB")]
		[Address(RVA = "0x342ECF0", Offset = "0x342D2F0", VA = "0x18342ECF0")]
		private void ShowCombatKnife()
		{
		}

		// Token: 0x06002CFC RID: 11516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CFC")]
		[Address(RVA = "0x342EF80", Offset = "0x342D580", VA = "0x18342EF80")]
		private void InitializeKnifeProp()
		{
		}

		// Token: 0x06002CFD RID: 11517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CFD")]
		[Address(RVA = "0x342F700", Offset = "0x342DD00", VA = "0x18342F700")]
		private void HideCombatKnife()
		{
		}

		// Token: 0x06002CFE RID: 11518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CFE")]
		[Address(RVA = "0x342F700", Offset = "0x342DD00", VA = "0x18342F700", Slot = "12")]
		public override void Cleanup()
		{
		}

		// Token: 0x06002CFF RID: 11519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CFF")]
		[Address(RVA = "0x342F770", Offset = "0x342DD70", VA = "0x18342F770")]
		public PlayerWakeOnEffigy()
		{
		}

		// Token: 0x04002781 RID: 10113
		[Token(Token = "0x4002781")]
		[FieldOffset(Offset = "0x88")]
		private GameObject _knifeGameObject;

		// Token: 0x04002782 RID: 10114
		[Token(Token = "0x4002782")]
		private const DeathCutsceneType ThisDeathCutsceneType = DeathCutsceneType.OnEffigy;
	}
}
