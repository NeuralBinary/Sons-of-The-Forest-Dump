using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001C2 RID: 450
	[Token(Token = "0x20001C2")]
	[AddComponentMenu("Sons/Stimuli/Log Pickup Stimuli")]
	public class LogPickupStimuli : PickupStimuli
	{
		// Token: 0x06000D6C RID: 3436 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000D6C")]
		[Address(RVA = "0x2BA3F60", Offset = "0x2BA2560", VA = "0x182BA3F60")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000D6D")]
		[Address(RVA = "0x2BA3F90", Offset = "0x2BA2590", VA = "0x182BA3F90")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x00007B60 File Offset: 0x00005D60
		[Token(Token = "0x6000D6E")]
		[Address(RVA = "0x2BA4010", Offset = "0x2BA2610", VA = "0x182BA4010", Slot = "12")]
		public override bool Validate(VailActor vailActor)
		{
			return default(bool);
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D6F")]
		[Address(RVA = "0x2B955D0", Offset = "0x2B93BD0", VA = "0x182B955D0")]
		public LogPickupStimuli()
		{
		}
	}
}
