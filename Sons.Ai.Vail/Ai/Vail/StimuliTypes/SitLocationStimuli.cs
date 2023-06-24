using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001E2 RID: 482
	[Token(Token = "0x20001E2")]
	[AddComponentMenu("Sons/Stimuli/Sit Location Stimuli")]
	public class SitLocationStimuli : MonoBehaviourStimuli
	{
		// Token: 0x06000E27 RID: 3623 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000E27")]
		[Address(RVA = "0x2BAA1C0", Offset = "0x2BA87C0", VA = "0x182BAA1C0")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000E28")]
		[Address(RVA = "0x2BAA1F0", Offset = "0x2BA87F0", VA = "0x182BAA1F0")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x00008028 File Offset: 0x00006228
		[Token(Token = "0x6000E29")]
		[Address(RVA = "0x2BA1D00", Offset = "0x2BA0300", VA = "0x182BA1D00", Slot = "19")]
		public override bool GetSnapToTarget(VailActor vailActor, bool useReserveLoc, out Vector3 position, out Quaternion rotation)
		{
			return default(bool);
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x00008040 File Offset: 0x00006240
		[Token(Token = "0x6000E2A")]
		[Address(RVA = "0x2B956A0", Offset = "0x2B93CA0", VA = "0x182B956A0", Slot = "11")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E2B")]
		[Address(RVA = "0x784C10", Offset = "0x783210", VA = "0x180784C10")]
		public void SetInUse(bool inUse)
		{
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E2C")]
		[Address(RVA = "0x1243280", Offset = "0x1241880", VA = "0x181243280")]
		public SitLocationStimuli()
		{
		}

		// Token: 0x040008E3 RID: 2275
		[Token(Token = "0x40008E3")]
		[FieldOffset(Offset = "0xA8")]
		private bool _inUse;
	}
}
