using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001C6 RID: 454
	[Token(Token = "0x20001C6")]
	[AddComponentMenu("Sons/Stimuli/Player Camp Fire Stimuli")]
	public class PlayerCampFireStimuli : MonoBehaviourStimuli
	{
		// Token: 0x06000D7B RID: 3451 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000D7B")]
		[Address(RVA = "0x2BA47F0", Offset = "0x2BA2DF0", VA = "0x182BA47F0")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000D7C")]
		[Address(RVA = "0x2BA4820", Offset = "0x2BA2E20", VA = "0x182BA4820")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D7D")]
		[Address(RVA = "0x2BA48A0", Offset = "0x2BA2EA0", VA = "0x182BA48A0")]
		private void Start()
		{
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x00007B90 File Offset: 0x00005D90
		[Token(Token = "0x6000D7E")]
		[Address(RVA = "0x2BA4900", Offset = "0x2BA2F00", VA = "0x182BA4900", Slot = "22")]
		public override float TimeAlive()
		{
			return 0f;
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D7F")]
		[Address(RVA = "0x1243280", Offset = "0x1241880", VA = "0x181243280")]
		public PlayerCampFireStimuli()
		{
		}

		// Token: 0x040008AD RID: 2221
		[Token(Token = "0x40008AD")]
		[FieldOffset(Offset = "0xA8")]
		private float _spawnTime;
	}
}
