using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001F5 RID: 501
	[Token(Token = "0x20001F5")]
	[AddComponentMenu("Sons/Stimuli/HuntingZoneStimuli")]
	public class HuntingZoneStimuli : ZoneStimuli
	{
		// Token: 0x06000E95 RID: 3733 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000E95")]
		[Address(RVA = "0x2BAEDF0", Offset = "0x2BAD3F0", VA = "0x182BAEDF0")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000E96")]
		[Address(RVA = "0x2BAEE20", Offset = "0x2BAD420", VA = "0x182BAEE20")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E97")]
		[Address(RVA = "0x1243280", Offset = "0x1241880", VA = "0x181243280")]
		public HuntingZoneStimuli()
		{
		}

		// Token: 0x040008FD RID: 2301
		[Token(Token = "0x40008FD")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private VailActorTypeId[] _preyTypes;
	}
}
