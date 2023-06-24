using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001AE RID: 430
	[Token(Token = "0x20001AE")]
	[AddComponentMenu("Sons/Stimuli/Event/Surround Target Stimuli")]
	public class SurroundTargetStimuli : EventStimuli
	{
		// Token: 0x06000D03 RID: 3331 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000D03")]
		[Address(RVA = "0x2BA0480", Offset = "0x2B9EA80", VA = "0x182BA0480")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000D04")]
		[Address(RVA = "0x2BA04B0", Offset = "0x2B9EAB0", VA = "0x182BA04B0")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x000078D8 File Offset: 0x00005AD8
		[Token(Token = "0x6000D05")]
		[Address(RVA = "0x2BA0530", Offset = "0x2B9EB30", VA = "0x182BA0530", Slot = "18")]
		public override Vector3 GetLookAtPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D06")]
		[Address(RVA = "0x2B9CE20", Offset = "0x2B9B420", VA = "0x182B9CE20")]
		public SurroundTargetStimuli()
		{
		}
	}
}
