using System;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x0200007D RID: 125
	[Token(Token = "0x200007D")]
	public class StructureDamageFXProcessor : IStructureImpactProcessor
	{
		// Token: 0x0600035A RID: 858 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600035A")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public StructureDamageFXProcessor(AudioClipProfile defaultDamageSfx)
		{
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0000371C File Offset: 0x0000191C
		[Token(Token = "0x600035B")]
		[Address(RVA = "0x2DC1050", Offset = "0x2DBF650", VA = "0x182DC1050", Slot = "4")]
		public bool Process(StructureImpactProcessingData processingData)
		{
			return default(bool);
		}

		// Token: 0x04000363 RID: 867
		[Token(Token = "0x4000363")]
		[FieldOffset(Offset = "0x10")]
		private AudioClipProfile _defaultDamageSfx;
	}
}
