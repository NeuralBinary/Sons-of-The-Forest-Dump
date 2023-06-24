using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002D3 RID: 723
[Token(Token = "0x20002D3")]
public class GrassUpdate : MonoBehaviour
{
	// Token: 0x17000221 RID: 545
	// (get) Token: 0x0600130A RID: 4874 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000221")]
	private Material TerrainMaterial
	{
		[Token(Token = "0x600130A")]
		[Address(RVA = "0x31ECAE0", Offset = "0x31EB0E0", VA = "0x1831ECAE0")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600130B RID: 4875 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600130B")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void Awake()
	{
	}

	// Token: 0x0600130C RID: 4876 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600130C")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void Start()
	{
	}

	// Token: 0x0600130D RID: 4877 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600130D")]
	[Address(RVA = "0x31ECD40", Offset = "0x31EB340", VA = "0x1831ECD40")]
	public void Update()
	{
	}

	// Token: 0x0600130E RID: 4878 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600130E")]
	[Address(RVA = "0x31ECE40", Offset = "0x31EB440", VA = "0x1831ECE40")]
	public void OnDestroy()
	{
	}

	// Token: 0x0600130F RID: 4879 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600130F")]
	[Address(RVA = "0x31ECF20", Offset = "0x31EB520", VA = "0x1831ECF20")]
	public GrassUpdate()
	{
	}

	// Token: 0x040012FE RID: 4862
	[Token(Token = "0x40012FE")]
	[FieldOffset(Offset = "0x20")]
	public float Fresnel;

	// Token: 0x040012FF RID: 4863
	[Token(Token = "0x40012FF")]
	[FieldOffset(Offset = "0x24")]
	public float CutOff;

	// Token: 0x04001300 RID: 4864
	[Token(Token = "0x4001300")]
	[FieldOffset(Offset = "0x28")]
	public float Shininess;

	// Token: 0x04001301 RID: 4865
	[Token(Token = "0x4001301")]
	[FieldOffset(Offset = "0x2C")]
	public float SpecularIntensity;

	// Token: 0x04001302 RID: 4866
	[Token(Token = "0x4001302")]
	[FieldOffset(Offset = "0x30")]
	public Vector4 Diffuse;

	// Token: 0x04001303 RID: 4867
	[Token(Token = "0x4001303")]
	[FieldOffset(Offset = "0x40")]
	private Material grassMaterial;
}
