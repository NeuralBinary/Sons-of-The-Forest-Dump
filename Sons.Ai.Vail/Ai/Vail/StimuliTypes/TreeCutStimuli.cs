using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001EB RID: 491
	[Token(Token = "0x20001EB")]
	[AddComponentMenu("Sons/Stimuli/TreeCutStimuli")]
	public class TreeCutStimuli : MonoBehaviourStimuli
	{
		// Token: 0x06000E5F RID: 3679 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000E5F")]
		[Address(RVA = "0x2BACE20", Offset = "0x2BAB420", VA = "0x182BACE20")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000E60")]
		[Address(RVA = "0x2BACE50", Offset = "0x2BAB450", VA = "0x182BACE50")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x00008190 File Offset: 0x00006390
		[Token(Token = "0x6000E61")]
		[Address(RVA = "0xE51970", Offset = "0xE4FF70", VA = "0x180E51970")]
		public static int GridType()
		{
			return 0;
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E62")]
		[Address(RVA = "0x2B95780", Offset = "0x2B93D80", VA = "0x182B95780")]
		private TreeCutStimuli()
		{
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x000081A8 File Offset: 0x000063A8
		[Token(Token = "0x6000E63")]
		[Address(RVA = "0x2BACED0", Offset = "0x2BAB4D0", VA = "0x182BACED0", Slot = "19")]
		public override bool GetSnapToTarget(VailActor vailActor, bool allowReserveLoc, out Vector3 position, out Quaternion rotation)
		{
			return default(bool);
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x000081C0 File Offset: 0x000063C0
		[Token(Token = "0x6000E64")]
		[Address(RVA = "0x2BAD180", Offset = "0x2BAB780", VA = "0x182BAD180", Slot = "18")]
		public override Vector3 GetLookAtPosition()
		{
			return default(Vector3);
		}
	}
}
