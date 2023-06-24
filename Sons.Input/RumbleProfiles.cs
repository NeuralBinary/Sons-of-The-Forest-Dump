using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Input
{
	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	[CreateAssetMenu(fileName = "RumbleProfiles", menuName = "Sons/Input/RumbleProfiles", order = 1)]
	public class RumbleProfiles : ScriptableObject
	{
		// Token: 0x06000140 RID: 320 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x307D3D0", Offset = "0x307B9D0", VA = "0x18307D3D0")]
		private void OnValidate()
		{
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00002C24 File Offset: 0x00000E24
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x307D5C0", Offset = "0x307BBC0", VA = "0x18307D5C0")]
		public bool TryGetRumbleProfile(string rumbleProfileId, out RumbleProfile rumbleProfile)
		{
			return default(bool);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public RumbleProfiles()
		{
		}

		// Token: 0x0400017E RID: 382
		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public List<RumbleProfile> _profiles;
	}
}
