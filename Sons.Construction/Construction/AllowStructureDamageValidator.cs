using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200008F RID: 143
	[Token(Token = "0x200008F")]
	public class AllowStructureDamageValidator : IStructureImpactValidator
	{
		// Token: 0x060003B7 RID: 951 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x2DCAE30", Offset = "0x2DC9430", VA = "0x182DCAE30")]
		public AllowStructureDamageValidator()
		{
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x2DCAEE0", Offset = "0x2DC94E0", VA = "0x182DCAEE0", Slot = "4")]
		public void OnDestroy()
		{
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x2DCAF90", Offset = "0x2DC9590", VA = "0x182DCAF90")]
		private void SetStructureDamage(bool onOff)
		{
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00003A04 File Offset: 0x00001C04
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x5FD4E0", Offset = "0x5FBAE0", VA = "0x1805FD4E0", Slot = "5")]
		public bool Validate(Structure structure, Transform attackSourceTr, IImpactData impactData)
		{
			return default(bool);
		}

		// Token: 0x04000397 RID: 919
		[Token(Token = "0x4000397")]
		[FieldOffset(Offset = "0x10")]
		private bool _structureDamage;
	}
}
