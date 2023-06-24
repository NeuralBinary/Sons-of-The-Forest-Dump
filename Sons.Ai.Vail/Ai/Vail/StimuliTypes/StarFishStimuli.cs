using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x0200018D RID: 397
	[Token(Token = "0x200018D")]
	[AddComponentMenu("Sons/Stimuli/Star Fish Stimuli")]
	public class StarFishStimuli : ConsumableStimuli
	{
		// Token: 0x06000C60 RID: 3168 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000C60")]
		[Address(RVA = "0x2B9B2F0", Offset = "0x2B998F0", VA = "0x182B9B2F0")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000C61")]
		[Address(RVA = "0x2B9B320", Offset = "0x2B99920", VA = "0x182B9B320")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x00007488 File Offset: 0x00005688
		[Token(Token = "0x6000C62")]
		[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850")]
		public static int GridType()
		{
			return 0;
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C63")]
		[Address(RVA = "0x2B9B3A0", Offset = "0x2B999A0", VA = "0x182B9B3A0")]
		private StarFishStimuli()
		{
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C64")]
		[Address(RVA = "0x2B9B3D0", Offset = "0x2B999D0", VA = "0x182B9B3D0", Slot = "30")]
		public override void BeginInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C65")]
		[Address(RVA = "0x2B9BA30", Offset = "0x2B9A030", VA = "0x182B9BA30", Slot = "32")]
		public override void EndInteraction(VailActor vailActor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C66")]
		[Address(RVA = "0x2B9BA90", Offset = "0x2B9A090", VA = "0x182B9BA90")]
		private void EnableRender(bool enable)
		{
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C67")]
		[Address(RVA = "0x2B9BBB0", Offset = "0x2B9A1B0", VA = "0x182B9BBB0")]
		private void DisableEatInstance()
		{
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C68")]
		[Address(RVA = "0x2B9BD00", Offset = "0x2B9A300", VA = "0x182B9BD00", Slot = "10")]
		internal override void OnDisable()
		{
		}

		// Token: 0x04000862 RID: 2146
		[Token(Token = "0x4000862")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private GameObject _eatPrefab;

		// Token: 0x04000863 RID: 2147
		[Token(Token = "0x4000863")]
		[FieldOffset(Offset = "0xE8")]
		private GameObject _eatInstance;
	}
}
