using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x02000098 RID: 152
	[Token(Token = "0x2000098")]
	[Serializable]
	public class StateProfileManager
	{
		// Token: 0x06000622 RID: 1570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000622")]
		[Address(RVA = "0x2B340F0", Offset = "0x2B326F0", VA = "0x182B340F0")]
		internal void OnValidate()
		{
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000623")]
		[Address(RVA = "0x2B345E0", Offset = "0x2B32BE0", VA = "0x182B345E0")]
		[NotNull]
		private StateProfile GetStateProfile(State checkState)
		{
			return null;
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00004D10 File Offset: 0x00002F10
		[Token(Token = "0x6000624")]
		[Address(RVA = "0x2B348D0", Offset = "0x2B32ED0", VA = "0x182B348D0")]
		public float GetVeryCloseDistance(State checkState)
		{
			return 0f;
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00004D28 File Offset: 0x00002F28
		[Token(Token = "0x6000625")]
		[Address(RVA = "0x2B34910", Offset = "0x2B32F10", VA = "0x182B34910")]
		public float GetNearDistance(State checkState)
		{
			return 0f;
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00004D40 File Offset: 0x00002F40
		[Token(Token = "0x6000626")]
		[Address(RVA = "0x2B34950", Offset = "0x2B32F50", VA = "0x182B34950")]
		public float GetFarDistance(State checkState)
		{
			return 0f;
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000627")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public StateProfileManager()
		{
		}

		// Token: 0x040004FF RID: 1279
		[Token(Token = "0x40004FF")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private List<StateProfile> _profiles;

		// Token: 0x04000500 RID: 1280
		[Token(Token = "0x4000500")]
		[FieldOffset(Offset = "0x18")]
		private StateProfile _defaultProfile;
	}
}
