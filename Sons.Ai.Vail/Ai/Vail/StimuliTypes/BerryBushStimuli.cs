using System;
using Il2CppDummyDll;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x02000181 RID: 385
	[Token(Token = "0x2000181")]
	[AddComponentMenu("Sons/Stimuli/Berry Bush Stimuli")]
	public class BerryBushStimuli : ConsumableStimuli
	{
		// Token: 0x06000C1D RID: 3101 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000C1D")]
		[Address(RVA = "0x2B97C90", Offset = "0x2B96290", VA = "0x182B97C90")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000C1E")]
		[Address(RVA = "0x2B97CC0", Offset = "0x2B962C0", VA = "0x182B97CC0")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x000073F8 File Offset: 0x000055F8
		[Token(Token = "0x6000C1F")]
		[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850")]
		public static int GridType()
		{
			return 0;
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000C20")]
		[Address(RVA = "0x2B97D40", Offset = "0x2B96340", VA = "0x182B97D40")]
		private static ValueDropdownList<string> GetItemTypes()
		{
			return null;
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000C21")]
		[Address(RVA = "0x784BA0", Offset = "0x7831A0", VA = "0x180784BA0", Slot = "29")]
		public override string GetVailItemType()
		{
			return null;
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C22")]
		[Address(RVA = "0x2B97D80", Offset = "0x2B96380", VA = "0x182B97D80", Slot = "30")]
		public override void BeginInteraction(VailActor actor, Action completedCallback, Action interruptedCallback)
		{
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C23")]
		[Address(RVA = "0x2B97DD0", Offset = "0x2B963D0", VA = "0x182B97DD0", Slot = "15")]
		public override void OnInteractAnimEvent(VailActor actor, string param)
		{
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C24")]
		[Address(RVA = "0x2B97ED0", Offset = "0x2B964D0", VA = "0x182B97ED0")]
		public BerryBushStimuli()
		{
		}

		// Token: 0x0400084B RID: 2123
		[Token(Token = "0x400084B")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private string _itemType;
	}
}
