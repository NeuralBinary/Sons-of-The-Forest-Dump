using System;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x0200007E RID: 126
	[Token(Token = "0x200007E")]
	public class StructureDamageProcessor : IStructureImpactProcessor
	{
		// Token: 0x0600035C RID: 860 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600035C")]
		[Address(RVA = "0x1FEFE20", Offset = "0x1FEE420", VA = "0x181FEFE20")]
		public StructureDamageProcessor(float siegeDamageRatio, float explosionDamageRatio, float projectileDamageRatio)
		{
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00003734 File Offset: 0x00001934
		[Token(Token = "0x600035D")]
		[Address(RVA = "0x2DC12F0", Offset = "0x2DBF8F0", VA = "0x182DC12F0", Slot = "4")]
		public bool Process(StructureImpactProcessingData processingData)
		{
			return default(bool);
		}

		// Token: 0x04000364 RID: 868
		[Token(Token = "0x4000364")]
		[FieldOffset(Offset = "0x10")]
		private float _siegeDamageRatio;

		// Token: 0x04000365 RID: 869
		[Token(Token = "0x4000365")]
		[FieldOffset(Offset = "0x14")]
		private float _explosionDamageRatio;

		// Token: 0x04000366 RID: 870
		[Token(Token = "0x4000366")]
		[FieldOffset(Offset = "0x18")]
		private float _projectileDamageRatio;
	}
}
