using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000249 RID: 585
[Token(Token = "0x2000249")]
public class ProjectCubeIntoSH3 : MonoBehaviour
{
	// Token: 0x06001014 RID: 4116 RVA: 0x00005DF0 File Offset: 0x00003FF0
	[Token(Token = "0x6001014")]
	[Address(RVA = "0x2FB6440", Offset = "0x2FB5440", VA = "0x182FB6440")]
	private Matrix4x4 QuaternionToMatrix(Quaternion quat)
	{
		return default(Matrix4x4);
	}

	// Token: 0x06001015 RID: 4117 RVA: 0x00005E08 File Offset: 0x00004008
	[Token(Token = "0x6001015")]
	[Address(RVA = "0x2FB5A10", Offset = "0x2FB4A10", VA = "0x182FB5A10")]
	public SphericalHarmonicsL2 ProjectCubeIntoSH3Func(Cubemap src, int miplevel)
	{
		return default(SphericalHarmonicsL2);
	}

	// Token: 0x06001016 RID: 4118 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001016")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public ProjectCubeIntoSH3()
	{
	}

	// Token: 0x04000F27 RID: 3879
	[Token(Token = "0x4000F27")]
	[FieldOffset(Offset = "0x20")]
	public Cubemap specCube;
}
