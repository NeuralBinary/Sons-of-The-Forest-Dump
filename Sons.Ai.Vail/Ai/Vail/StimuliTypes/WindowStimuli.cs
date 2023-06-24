using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001F3 RID: 499
	[Token(Token = "0x20001F3")]
	[AddComponentMenu("Sons/Stimuli/Window Stimuli")]
	public class WindowStimuli : StructureStimuli
	{
		// Token: 0x06000E8C RID: 3724 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000E8C")]
		[Address(RVA = "0x2BAEAA0", Offset = "0x2BAD0A0", VA = "0x182BAEAA0")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000E8D")]
		[Address(RVA = "0x2BAEAD0", Offset = "0x2BAD0D0", VA = "0x182BAEAD0")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x00008310 File Offset: 0x00006510
		[Token(Token = "0x6000E8E")]
		[Address(RVA = "0x2BADCF0", Offset = "0x2BAC2F0", VA = "0x182BADCF0", Slot = "21")]
		public override bool TryRequestLocation(VailActor requester, out Transform outTransform)
		{
			return default(bool);
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x00008328 File Offset: 0x00006528
		[Token(Token = "0x6000E8F")]
		[Address(RVA = "0x2BAEB50", Offset = "0x2BAD150", VA = "0x182BAEB50", Slot = "19")]
		public override bool GetSnapToTarget(VailActor vailActor, bool allowReserveLoc, out Vector3 position, out Quaternion rotation)
		{
			return default(bool);
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E90")]
		[Address(RVA = "0x2BAE710", Offset = "0x2BACD10", VA = "0x182BAE710")]
		public WindowStimuli()
		{
		}
	}
}
