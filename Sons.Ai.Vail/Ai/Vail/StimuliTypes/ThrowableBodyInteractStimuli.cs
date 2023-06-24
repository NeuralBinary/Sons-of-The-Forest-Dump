using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001EA RID: 490
	[Token(Token = "0x20001EA")]
	[AddComponentMenu("Sons/Stimuli/Throwable Body Interact Stimuli")]
	public class ThrowableBodyInteractStimuli : InteractStimuli
	{
		// Token: 0x06000E5A RID: 3674 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000E5A")]
		[Address(RVA = "0x2BAC930", Offset = "0x2BAAF30", VA = "0x182BAC930")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000E5B")]
		[Address(RVA = "0x2BAC960", Offset = "0x2BAAF60", VA = "0x182BAC960")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x00008178 File Offset: 0x00006378
		[Token(Token = "0x6000E5C")]
		[Address(RVA = "0x2BAC9E0", Offset = "0x2BAAFE0", VA = "0x182BAC9E0", Slot = "11")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E5D")]
		[Address(RVA = "0x2BACB10", Offset = "0x2BAB110", VA = "0x182BACB10", Slot = "15")]
		public override void OnInteractAnimEvent(VailActor actor, string param)
		{
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E5E")]
		[Address(RVA = "0x2B955D0", Offset = "0x2B93BD0", VA = "0x182B955D0")]
		public ThrowableBodyInteractStimuli()
		{
		}
	}
}
