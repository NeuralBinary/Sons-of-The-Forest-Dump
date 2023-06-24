using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000090 RID: 144
	[Token(Token = "0x2000090")]
	public class BuiltStructureValidator : IStructureImpactValidator
	{
		// Token: 0x060003BB RID: 955 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		public void OnDestroy()
		{
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00003A1C File Offset: 0x00001C1C
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x2DCAFD0", Offset = "0x2DC95D0", VA = "0x182DCAFD0", Slot = "5")]
		public bool Validate(Structure structure, Transform attackSourceTr, IImpactData impactData)
		{
			return default(bool);
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public BuiltStructureValidator()
		{
		}
	}
}
