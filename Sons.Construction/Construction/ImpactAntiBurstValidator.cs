using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000091 RID: 145
	[Token(Token = "0x2000091")]
	public class ImpactAntiBurstValidator : IStructureImpactValidator, IUpdateReceiver
	{
		// Token: 0x060003BE RID: 958 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		public void OnDestroy()
		{
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x2DCB080", Offset = "0x2DC9680", VA = "0x182DCB080", Slot = "6")]
		public void OnUpdate()
		{
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00003A34 File Offset: 0x00001C34
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x2DCB120", Offset = "0x2DC9720", VA = "0x182DCB120", Slot = "5")]
		public bool Validate(Structure structure, Transform attackSourceTr, IImpactData impactData)
		{
			return default(bool);
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x2DCB230", Offset = "0x2DC9830", VA = "0x182DCB230")]
		public ImpactAntiBurstValidator()
		{
		}

		// Token: 0x04000398 RID: 920
		[Token(Token = "0x4000398")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<Structure> _frameTakingDamageStructures;

		// Token: 0x04000399 RID: 921
		[Token(Token = "0x4000399")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<Transform> _frameAttackSources;
	}
}
