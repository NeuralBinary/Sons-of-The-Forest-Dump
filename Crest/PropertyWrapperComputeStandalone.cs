using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x02000026 RID: 38
	[Token(Token = "0x2000026")]
	[Serializable]
	public class PropertyWrapperComputeStandalone : IPropertyWrapper
	{
		// Token: 0x060000A9 RID: 169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x9D27E0", Offset = "0x9D0DE0", VA = "0x1809D27E0")]
		public PropertyWrapperComputeStandalone(ComputeShader computeShader, int computeKernel)
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x9D2840", Offset = "0x9D0E40", VA = "0x1809D2840", Slot = "4")]
		public void SetFloat(int param, float value)
		{
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x9D28C0", Offset = "0x9D0EC0", VA = "0x1809D28C0", Slot = "5")]
		public void SetFloatArray(int param, float[] value)
		{
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x9D2940", Offset = "0x9D0F40", VA = "0x1809D2940", Slot = "10")]
		public void SetInt(int param, int value)
		{
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x9D29C0", Offset = "0x9D0FC0", VA = "0x1809D29C0", Slot = "8")]
		public void SetTexture(int param, Texture value)
		{
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x9D2A00", Offset = "0x9D1000", VA = "0x1809D2A00", Slot = "6")]
		public void SetVector(int param, Vector4 value)
		{
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x9D2A80", Offset = "0x9D1080", VA = "0x1809D2A80", Slot = "7")]
		public void SetVectorArray(int param, Vector4[] value)
		{
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x9D2B00", Offset = "0x9D1100", VA = "0x1809D2B00", Slot = "9")]
		public void SetMatrix(int param, Matrix4x4 value)
		{
		}

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x10")]
		private ComputeShader _computeShader;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x18")]
		private int _computeKernel;
	}
}
