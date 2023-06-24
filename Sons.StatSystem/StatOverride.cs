using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.StatSystem
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	[Serializable]
	internal class StatOverride
	{
		// Token: 0x0600003F RID: 63 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x3143B10", Offset = "0x3142110", VA = "0x183143B10")]
		private static List<string> GetTypeValues()
		{
			return null;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x623B90", Offset = "0x622190", VA = "0x180623B90")]
		public void SetRuntimeRegenRateMultiplier(float multiplier)
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000224C File Offset: 0x0000044C
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x3143B50", Offset = "0x3142150", VA = "0x183143B50")]
		public bool TryGetFadeRate(out float fadeRate)
		{
			return default(bool);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002264 File Offset: 0x00000464
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x3143B70", Offset = "0x3142170", VA = "0x183143B70")]
		public bool TryGetRegenRate(out float regenRate)
		{
			return default(bool);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000227C File Offset: 0x0000047C
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x3143B90", Offset = "0x3142190", VA = "0x183143B90")]
		public bool IsType(string typeName)
		{
			return default(bool);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2B58350", Offset = "0x2B56950", VA = "0x182B58350")]
		public StatOverride()
		{
		}

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool _overrideFadeRate;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float _fadeRate;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _overrideRegenRate;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _regenRate;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _assignedType;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x28")]
		private float _regenRateMultiplier;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x0")]
		private static List<string> _allStats;
	}
}
