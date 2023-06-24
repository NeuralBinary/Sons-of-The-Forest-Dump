using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x02000187 RID: 391
	[Token(Token = "0x2000187")]
	[AddComponentMenu("Sons/Stimuli/Meat Stimuli")]
	public class MeatStimuli : ConsumableStimuli
	{
		// Token: 0x06000C47 RID: 3143 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000C47")]
		[Address(RVA = "0x2B99C70", Offset = "0x2B98270", VA = "0x182B99C70")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000C48")]
		[Address(RVA = "0x2B99CA0", Offset = "0x2B982A0", VA = "0x182B99CA0")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x00007458 File Offset: 0x00005658
		[Token(Token = "0x6000C49")]
		[Address(RVA = "0x2B99D20", Offset = "0x2B98320", VA = "0x182B99D20", Slot = "12")]
		public override bool Validate(VailActor vailActor)
		{
			return default(bool);
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C4A")]
		[Address(RVA = "0x2B99D80", Offset = "0x2B98380", VA = "0x182B99D80", Slot = "15")]
		public override void OnInteractAnimEvent(VailActor actor, string param)
		{
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C4B")]
		[Address(RVA = "0x2B9A4D0", Offset = "0x2B98AD0", VA = "0x182B9A4D0")]
		public MeatStimuli()
		{
		}

		// Token: 0x0400085F RID: 2143
		[Token(Token = "0x400085F")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private bool _isHumanEdible;
	}
}
