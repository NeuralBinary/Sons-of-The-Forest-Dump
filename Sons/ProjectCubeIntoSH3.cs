using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000246 RID: 582
[Token(Token = "0x2000246")]
public class ProjectCubeIntoSH3 : MonoBehaviour
{
	// Token: 0x0600106A RID: 4202 RVA: 0x00006078 File Offset: 0x00004278
	[Token(Token = "0x600106A")]
	[Address(RVA = "0x3737C20", Offset = "0x3736220", VA = "0x183737C20")]
	private Matrix4x4 QuaternionToMatrix(Quaternion quat)
	{
		return default(Matrix4x4);
	}

	// Token: 0x0600106B RID: 4203 RVA: 0x00006090 File Offset: 0x00004290
	[Token(Token = "0x600106B")]
	[Address(RVA = "0x3737DD0", Offset = "0x37363D0", VA = "0x183737DD0")]
	public SphericalHarmonicsL2 ProjectCubeIntoSH3Func(Cubemap src, int miplevel)
	{
		return default(SphericalHarmonicsL2);
	}

	// Token: 0x0600106C RID: 4204 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600106C")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public ProjectCubeIntoSH3()
	{
	}

	// Token: 0x04000F52 RID: 3922
	[Token(Token = "0x4000F52")]
	[FieldOffset(Offset = "0x20")]
	public Cubemap specCube;
}
