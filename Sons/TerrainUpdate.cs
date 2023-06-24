using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002D7 RID: 727
[Token(Token = "0x20002D7")]
public class TerrainUpdate : MonoBehaviour
{
	// Token: 0x17000224 RID: 548
	// (get) Token: 0x0600131E RID: 4894 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000224")]
	private Material TerrainMaterial
	{
		[Token(Token = "0x600131E")]
		[Address(RVA = "0x31ED840", Offset = "0x31EBE40", VA = "0x1831ED840")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600131F RID: 4895 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600131F")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void Awake()
	{
	}

	// Token: 0x06001320 RID: 4896 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001320")]
	[Address(RVA = "0x31EDAA0", Offset = "0x31EC0A0", VA = "0x1831EDAA0")]
	private void Start()
	{
	}

	// Token: 0x06001321 RID: 4897 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001321")]
	[Address(RVA = "0x31EDCE0", Offset = "0x31EC2E0", VA = "0x1831EDCE0")]
	public void Update()
	{
	}

	// Token: 0x06001322 RID: 4898 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001322")]
	[Address(RVA = "0x31EDFA0", Offset = "0x31EC5A0", VA = "0x1831EDFA0")]
	public void OnDestroy()
	{
	}

	// Token: 0x06001323 RID: 4899 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001323")]
	[Address(RVA = "0x31EE080", Offset = "0x31EC680", VA = "0x1831EE080")]
	public TerrainUpdate()
	{
	}

	// Token: 0x04001308 RID: 4872
	[Token(Token = "0x4001308")]
	[FieldOffset(Offset = "0x20")]
	private Matrix4x4 skyMatrix;

	// Token: 0x04001309 RID: 4873
	[Token(Token = "0x4001309")]
	[FieldOffset(Offset = "0x60")]
	private float ripplesUpdate;

	// Token: 0x0400130A RID: 4874
	[Token(Token = "0x400130A")]
	[FieldOffset(Offset = "0x68")]
	private Material terrainMaterial;
}
