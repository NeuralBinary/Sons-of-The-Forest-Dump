using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.StatSystem
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	[CreateAssetMenu(fileName = "StatOverrideSet", menuName = "Sons/Stats/StatOverrideSet")]
	public class StatOverrideSet : ScriptableObject
	{
		// Token: 0x06000045 RID: 69 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x3143BE0", Offset = "0x31421E0", VA = "0x183143BE0")]
		public void SetRuntimeRegenRateMultiplier(string typeName, float multiplier)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002294 File Offset: 0x00000494
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x3143D80", Offset = "0x3142380", VA = "0x183143D80")]
		public bool TryGetFadeRate(string typeName, out float fadeRate)
		{
			return default(bool);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000022AC File Offset: 0x000004AC
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x3143F50", Offset = "0x3142550", VA = "0x183143F50")]
		public bool TryGetRegenRate(string typeName, out float regenRate)
		{
			return default(bool);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public StatOverrideSet()
		{
		}

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<StatOverride> _stats;
	}
}
