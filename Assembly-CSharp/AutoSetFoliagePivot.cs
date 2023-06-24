using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x02000027 RID: 39
[Token(Token = "0x2000027")]
public class AutoSetFoliagePivot : MonoBehaviour
{
	// Token: 0x06000098 RID: 152 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000098")]
	[Address(RVA = "0x5DBBF0", Offset = "0x5DA1F0", VA = "0x1805DBBF0")]
	private void EnablePreview()
	{
	}

	// Token: 0x06000099 RID: 153 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000099")]
	[Address(RVA = "0x5DBC00", Offset = "0x5DA200", VA = "0x1805DBC00")]
	private void DisablePreview()
	{
	}

	// Token: 0x0600009A RID: 154 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600009A")]
	[Address(RVA = "0x5DBC10", Offset = "0x5DA210", VA = "0x1805DBC10")]
	private void OnValidate()
	{
	}

	// Token: 0x0600009B RID: 155 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600009B")]
	[Address(RVA = "0x5DBD40", Offset = "0x5DA340", VA = "0x1805DBD40")]
	private void OnEnable()
	{
	}

	// Token: 0x0600009C RID: 156 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600009C")]
	[Address(RVA = "0x5DBDD0", Offset = "0x5DA3D0", VA = "0x1805DBDD0")]
	private void AddAndUpdatePropertyBlock()
	{
	}

	// Token: 0x0600009D RID: 157 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600009D")]
	[Address(RVA = "0x5DC150", Offset = "0x5DA750", VA = "0x1805DC150")]
	private void ClearPropertyBlock()
	{
	}

	// Token: 0x0600009E RID: 158 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600009E")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public AutoSetFoliagePivot()
	{
	}

	// Token: 0x0400014B RID: 331
	[Token(Token = "0x400014B")]
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("_rend")]
	public Renderer _targetRenderer;

	// Token: 0x0400014C RID: 332
	[Token(Token = "0x400014C")]
	[FieldOffset(Offset = "0x28")]
	private MaterialPropertyBlock _mpb;

	// Token: 0x0400014D RID: 333
	[Token(Token = "0x400014D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int UseStaticPivotID;

	// Token: 0x0400014E RID: 334
	[Token(Token = "0x400014E")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int StaticPivotID;
}
