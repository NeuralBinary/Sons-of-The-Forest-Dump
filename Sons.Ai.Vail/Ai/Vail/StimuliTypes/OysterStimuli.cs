using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x02000189 RID: 393
	[Token(Token = "0x2000189")]
	[AddComponentMenu("Sons/Stimuli/Oyster Stimuli")]
	public class OysterStimuli : ConsumableStimuli
	{
		// Token: 0x06000C4F RID: 3151 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000C4F")]
		[Address(RVA = "0x2B9A5B0", Offset = "0x2B98BB0", VA = "0x182B9A5B0")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000C50")]
		[Address(RVA = "0x2B9A5E0", Offset = "0x2B98BE0", VA = "0x182B9A5E0")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C51")]
		[Address(RVA = "0x2B9A660", Offset = "0x2B98C60", VA = "0x182B9A660")]
		private OysterStimuli()
		{
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C52")]
		[Address(RVA = "0x2B9A680", Offset = "0x2B98C80", VA = "0x182B9A680", Slot = "30")]
		public override void BeginInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C53")]
		[Address(RVA = "0x2B9ACE0", Offset = "0x2B992E0", VA = "0x182B9ACE0", Slot = "32")]
		public override void EndInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C54")]
		[Address(RVA = "0x2B9AE70", Offset = "0x2B99470", VA = "0x182B9AE70")]
		private void EnableRender(bool enable)
		{
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C55")]
		[Address(RVA = "0x2B9AF90", Offset = "0x2B99590", VA = "0x182B9AF90")]
		private void DestroyEatInstance()
		{
		}

		// Token: 0x04000860 RID: 2144
		[Token(Token = "0x4000860")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private GameObject _eatPrefab;

		// Token: 0x04000861 RID: 2145
		[Token(Token = "0x4000861")]
		[FieldOffset(Offset = "0xE8")]
		private GameObject _eatInstance;
	}
}
