using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000234 RID: 564
	[Token(Token = "0x2000234")]
	public class SetVerticesMeshChange
	{
		// Token: 0x06001443 RID: 5187 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001443")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public SetVerticesMeshChange()
		{
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001444")]
		[Address(RVA = "0x1E7CDA0", Offset = "0x1E7B3A0", VA = "0x181E7CDA0")]
		public void Apply(DMesh3 mesh)
		{
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001445")]
		[Address(RVA = "0x1E7CE90", Offset = "0x1E7B490", VA = "0x181E7CE90")]
		public void Revert(DMesh3 mesh)
		{
		}

		// Token: 0x04000961 RID: 2401
		[Token(Token = "0x4000961")]
		[FieldOffset(Offset = "0x10")]
		public DVector<double> OldPositions;

		// Token: 0x04000962 RID: 2402
		[Token(Token = "0x4000962")]
		[FieldOffset(Offset = "0x18")]
		public DVector<double> NewPositions;

		// Token: 0x04000963 RID: 2403
		[Token(Token = "0x4000963")]
		[FieldOffset(Offset = "0x20")]
		public DVector<float> OldNormals;

		// Token: 0x04000964 RID: 2404
		[Token(Token = "0x4000964")]
		[FieldOffset(Offset = "0x28")]
		public DVector<float> NewNormals;

		// Token: 0x04000965 RID: 2405
		[Token(Token = "0x4000965")]
		[FieldOffset(Offset = "0x30")]
		public DVector<float> OldColors;

		// Token: 0x04000966 RID: 2406
		[Token(Token = "0x4000966")]
		[FieldOffset(Offset = "0x38")]
		public DVector<float> NewColors;

		// Token: 0x04000967 RID: 2407
		[Token(Token = "0x4000967")]
		[FieldOffset(Offset = "0x40")]
		public DVector<float> OldUVs;

		// Token: 0x04000968 RID: 2408
		[Token(Token = "0x4000968")]
		[FieldOffset(Offset = "0x48")]
		public DVector<float> NewUVs;

		// Token: 0x04000969 RID: 2409
		[Token(Token = "0x4000969")]
		[FieldOffset(Offset = "0x50")]
		public Action<SetVerticesMeshChange> OnApplyF;

		// Token: 0x0400096A RID: 2410
		[Token(Token = "0x400096A")]
		[FieldOffset(Offset = "0x58")]
		public Action<SetVerticesMeshChange> OnRevertF;
	}
}
