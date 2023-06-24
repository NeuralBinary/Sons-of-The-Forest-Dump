using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001B6 RID: 438
	[Token(Token = "0x20001B6")]
	[AddComponentMenu("Sons/Stimuli/Heavy Throne Stimuli")]
	public class HeavyThroneStimuli : MonoBehaviourStimuli
	{
		// Token: 0x06000D29 RID: 3369 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000D29")]
		[Address(RVA = "0x2BA1C50", Offset = "0x2BA0250", VA = "0x182BA1C50")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000D2A")]
		[Address(RVA = "0x2BA1C80", Offset = "0x2BA0280", VA = "0x182BA1C80")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x000079B0 File Offset: 0x00005BB0
		[Token(Token = "0x6000D2B")]
		[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850")]
		public static int GridType()
		{
			return 0;
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x000079C8 File Offset: 0x00005BC8
		[Token(Token = "0x6000D2C")]
		[Address(RVA = "0x2BA1D00", Offset = "0x2BA0300", VA = "0x182BA1D00", Slot = "19")]
		public override bool GetSnapToTarget(VailActor vailActor, bool useReserveLoc, out Vector3 position, out Quaternion rotation)
		{
			return default(bool);
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D2D")]
		[Address(RVA = "0x1243280", Offset = "0x1241880", VA = "0x181243280")]
		public HeavyThroneStimuli()
		{
		}
	}
}
