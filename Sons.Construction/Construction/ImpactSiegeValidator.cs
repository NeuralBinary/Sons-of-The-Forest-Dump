using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000092 RID: 146
	[Token(Token = "0x2000092")]
	public class ImpactSiegeValidator : IStructureImpactValidator
	{
		// Token: 0x060003C2 RID: 962 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		public void OnDestroy()
		{
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00003A4C File Offset: 0x00001C4C
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x2DCB380", Offset = "0x2DC9980", VA = "0x182DCB380", Slot = "5")]
		public bool Validate(Structure structure, Transform attackSourceTr, IImpactData impactData)
		{
			return default(bool);
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ImpactSiegeValidator()
		{
		}
	}
}
