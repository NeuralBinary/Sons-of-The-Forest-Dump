using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000023")]
	[Serializable]
	public class PropertyWrapperMaterial : IPropertyWrapper
	{
		// Token: 0x06000089 RID: 137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public PropertyWrapperMaterial(Material target)
		{
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x9D1BB0", Offset = "0x9D01B0", VA = "0x1809D1BB0")]
		public PropertyWrapperMaterial(Shader shader)
		{
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x9D1C70", Offset = "0x9D0270", VA = "0x1809D1C70", Slot = "4")]
		public void SetFloat(int param, float value)
		{
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x9D1CF0", Offset = "0x9D02F0", VA = "0x1809D1CF0", Slot = "5")]
		public void SetFloatArray(int param, float[] value)
		{
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x9D1D20", Offset = "0x9D0320", VA = "0x1809D1D20", Slot = "8")]
		public void SetTexture(int param, Texture value)
		{
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x9D1DA0", Offset = "0x9D03A0", VA = "0x1809D1DA0")]
		public void SetBuffer(int param, ComputeBuffer value)
		{
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x9D1E20", Offset = "0x9D0420", VA = "0x1809D1E20", Slot = "6")]
		public void SetVector(int param, Vector4 value)
		{
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x9D1ED0", Offset = "0x9D04D0", VA = "0x1809D1ED0", Slot = "7")]
		public void SetVectorArray(int param, Vector4[] value)
		{
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x9D1F00", Offset = "0x9D0500", VA = "0x1809D1F00", Slot = "9")]
		public void SetMatrix(int param, Matrix4x4 value)
		{
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x9D1FA0", Offset = "0x9D05A0", VA = "0x1809D1FA0", Slot = "10")]
		public void SetInt(int param, int value)
		{
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000093 RID: 147 RVA: 0x000020E2 File Offset: 0x000002E2
		// (set) Token: 0x06000094 RID: 148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000C")]
		public Material material
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			[CompilerGenerated]
			private set
			{
			}
		}
	}
}
