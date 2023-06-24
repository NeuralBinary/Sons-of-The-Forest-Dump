using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001DE RID: 478
	[Token(Token = "0x20001DE")]
	[AddComponentMenu("Sons/Stimuli/Rock Stimuli")]
	public class RockStimuli : MonoBehaviourStimuli
	{
		// Token: 0x06000E0B RID: 3595 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000E0B")]
		[Address(RVA = "0x2BA9B60", Offset = "0x2BA8160", VA = "0x182BA9B60")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000E0C")]
		[Address(RVA = "0x2BA9B90", Offset = "0x2BA8190", VA = "0x182BA9B90")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x00007F38 File Offset: 0x00006138
		[Token(Token = "0x6000E0D")]
		[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850")]
		public static int GridType()
		{
			return 0;
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E0E")]
		[Address(RVA = "0x2BA9C10", Offset = "0x2BA8210", VA = "0x182BA9C10")]
		private RockStimuli()
		{
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x00007F50 File Offset: 0x00006150
		[Token(Token = "0x6000E0F")]
		[Address(RVA = "0x2BA9C30", Offset = "0x2BA8230", VA = "0x182BA9C30", Slot = "12")]
		public override bool Validate(VailActor actor)
		{
			return default(bool);
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x00007F68 File Offset: 0x00006168
		[Token(Token = "0x6000E10")]
		[Address(RVA = "0x2BA9D00", Offset = "0x2BA8300", VA = "0x182BA9D00", Slot = "19")]
		public override bool GetSnapToTarget(VailActor actor, bool allowReserveLoc, out Vector3 position, out Quaternion rotation)
		{
			return default(bool);
		}
	}
}
