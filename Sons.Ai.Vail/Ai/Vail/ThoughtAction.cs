using System;
using Il2CppDummyDll;
using Sons.Animation.Mae;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Ai.Vail
{
	// Token: 0x020000B1 RID: 177
	[Token(Token = "0x20000B1")]
	[Serializable]
	public struct ThoughtAction
	{
		// Token: 0x06000703 RID: 1795 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000703")]
		[Address(RVA = "0x633720", Offset = "0x631D20", VA = "0x180633720")]
		public MaeSequence GetSequence()
		{
			return null;
		}

		// Token: 0x0400057C RID: 1404
		[Token(Token = "0x400057C")]
		[FieldOffset(Offset = "0x0")]
		[FormerlySerializedAs("_action")]
		[SerializeField]
		private MaeSequence _sequence;
	}
}
