using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002E3 RID: 739
[Token(Token = "0x20002E3")]
public class TerrainUpdate : MonoBehaviour
{
	// Token: 0x1700021B RID: 539
	// (get) Token: 0x060012E8 RID: 4840 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700021B")]
	private Material TerrainMaterial
	{
		[Token(Token = "0x60012E8")]
		[Address(RVA = "0x2C779B0", Offset = "0x2C769B0", VA = "0x182C779B0")]
		get
		{
			return null;
		}
	}

	// Token: 0x060012E9 RID: 4841 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012E9")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void Awake()
	{
	}

	// Token: 0x060012EA RID: 4842 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012EA")]
	[Address(RVA = "0x2C77610", Offset = "0x2C76610", VA = "0x182C77610")]
	private void Start()
	{
	}

	// Token: 0x060012EB RID: 4843 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012EB")]
	[Address(RVA = "0x2C77790", Offset = "0x2C76790", VA = "0x182C77790")]
	public void Update()
	{
	}

	// Token: 0x060012EC RID: 4844 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012EC")]
	[Address(RVA = "0x2C775A0", Offset = "0x2C765A0", VA = "0x182C775A0")]
	public void OnDestroy()
	{
	}

	// Token: 0x060012ED RID: 4845 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012ED")]
	[Address(RVA = "0x2C77940", Offset = "0x2C76940", VA = "0x182C77940")]
	public TerrainUpdate()
	{
	}

	// Token: 0x040012E0 RID: 4832
	[Token(Token = "0x40012E0")]
	[FieldOffset(Offset = "0x20")]
	private Matrix4x4 skyMatrix;

	// Token: 0x040012E1 RID: 4833
	[Token(Token = "0x40012E1")]
	[FieldOffset(Offset = "0x60")]
	private float ripplesUpdate;

	// Token: 0x040012E2 RID: 4834
	[Token(Token = "0x40012E2")]
	[FieldOffset(Offset = "0x68")]
	private Material terrainMaterial;
}
