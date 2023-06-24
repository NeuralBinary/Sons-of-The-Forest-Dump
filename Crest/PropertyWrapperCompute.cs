using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Crest
{
	// Token: 0x02000025 RID: 37
	[Token(Token = "0x2000025")]
	[Serializable]
	public class PropertyWrapperCompute : IPropertyWrapper
	{
		// Token: 0x0600009F RID: 159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x9D2340", Offset = "0x9D0940", VA = "0x1809D2340")]
		public void Initialise(CommandBuffer commandBuffer, ComputeShader computeShader, int computeKernel)
		{
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x9D2410", Offset = "0x9D0A10", VA = "0x1809D2410", Slot = "4")]
		public void SetFloat(int param, float value)
		{
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x9D2450", Offset = "0x9D0A50", VA = "0x1809D2450", Slot = "5")]
		public void SetFloatArray(int param, float[] value)
		{
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x9D24D0", Offset = "0x9D0AD0", VA = "0x1809D24D0", Slot = "10")]
		public void SetInt(int param, int value)
		{
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x9D2510", Offset = "0x9D0B10", VA = "0x1809D2510", Slot = "8")]
		public void SetTexture(int param, Texture value)
		{
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x9D2610", Offset = "0x9D0C10", VA = "0x1809D2610")]
		public void SetBuffer(int param, ComputeBuffer value)
		{
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x9D2650", Offset = "0x9D0C50", VA = "0x1809D2650", Slot = "6")]
		public void SetVector(int param, Vector4 value)
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x9D26E0", Offset = "0x9D0CE0", VA = "0x1809D26E0", Slot = "7")]
		public void SetVectorArray(int param, Vector4[] value)
		{
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x9D2720", Offset = "0x9D0D20", VA = "0x1809D2720", Slot = "9")]
		public void SetMatrix(int param, Matrix4x4 value)
		{
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x9D27D0", Offset = "0x9D0DD0", VA = "0x1809D27D0")]
		public PropertyWrapperCompute()
		{
		}

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x10")]
		private CommandBuffer _commandBuffer;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x18")]
		private ComputeShader _computeShader;

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x20")]
		private int _computeKernel;
	}
}
