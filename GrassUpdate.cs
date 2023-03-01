using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002DF RID: 735
[Token(Token = "0x20002DF")]
public class GrassUpdate : MonoBehaviour
{
	// Token: 0x17000218 RID: 536
	// (get) Token: 0x060012D4 RID: 4820 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000218")]
	private Material TerrainMaterial
	{
		[Token(Token = "0x60012D4")]
		[Address(RVA = "0x2C665C0", Offset = "0x2C655C0", VA = "0x182C665C0")]
		get
		{
			return null;
		}
	}

	// Token: 0x060012D5 RID: 4821 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012D5")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void Awake()
	{
	}

	// Token: 0x060012D6 RID: 4822 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012D6")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void Start()
	{
	}

	// Token: 0x060012D7 RID: 4823 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012D7")]
	[Address(RVA = "0x2C66460", Offset = "0x2C65460", VA = "0x182C66460")]
	public void Update()
	{
	}

	// Token: 0x060012D8 RID: 4824 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012D8")]
	[Address(RVA = "0x2C663F0", Offset = "0x2C653F0", VA = "0x182C663F0")]
	public void OnDestroy()
	{
	}

	// Token: 0x060012D9 RID: 4825 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012D9")]
	[Address(RVA = "0x2C66560", Offset = "0x2C65560", VA = "0x182C66560")]
	public GrassUpdate()
	{
	}

	// Token: 0x040012D6 RID: 4822
	[Token(Token = "0x40012D6")]
	[FieldOffset(Offset = "0x20")]
	public float Fresnel;

	// Token: 0x040012D7 RID: 4823
	[Token(Token = "0x40012D7")]
	[FieldOffset(Offset = "0x24")]
	public float CutOff;

	// Token: 0x040012D8 RID: 4824
	[Token(Token = "0x40012D8")]
	[FieldOffset(Offset = "0x28")]
	public float Shininess;

	// Token: 0x040012D9 RID: 4825
	[Token(Token = "0x40012D9")]
	[FieldOffset(Offset = "0x2C")]
	public float SpecularIntensity;

	// Token: 0x040012DA RID: 4826
	[Token(Token = "0x40012DA")]
	[FieldOffset(Offset = "0x30")]
	public Vector4 Diffuse;

	// Token: 0x040012DB RID: 4827
	[Token(Token = "0x40012DB")]
	[FieldOffset(Offset = "0x40")]
	private Material grassMaterial;
}
