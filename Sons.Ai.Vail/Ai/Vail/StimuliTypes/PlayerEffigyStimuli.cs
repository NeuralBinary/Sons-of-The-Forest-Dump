using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001C8 RID: 456
	[Token(Token = "0x20001C8")]
	[AddComponentMenu("Sons/Stimuli/PlayerEffigyStimuli")]
	public class PlayerEffigyStimuli : PlayerStructureStimuli
	{
		// Token: 0x06000D83 RID: 3459 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000D83")]
		[Address(RVA = "0x2BA4A10", Offset = "0x2BA3010", VA = "0x182BA4A10")]
		public new static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000D84")]
		[Address(RVA = "0x2BA4A40", Offset = "0x2BA3040", VA = "0x182BA4A40")]
		public new static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D85")]
		[Address(RVA = "0x2BA4AC0", Offset = "0x2BA30C0", VA = "0x182BA4AC0")]
		public void Initialize(int limbCount)
		{
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D86")]
		[Address(RVA = "0x2B95780", Offset = "0x2B93D80", VA = "0x182B95780")]
		public PlayerEffigyStimuli()
		{
		}

		// Token: 0x040008AE RID: 2222
		[Token(Token = "0x40008AE")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private AuraInfluence _aura;

		// Token: 0x040008AF RID: 2223
		[Token(Token = "0x40008AF")]
		[FieldOffset(Offset = "0xB0")]
		private int _limbCount;

		// Token: 0x040008B0 RID: 2224
		[Token(Token = "0x40008B0")]
		[FieldOffset(Offset = "0xB4")]
		private float _strength;
	}
}
