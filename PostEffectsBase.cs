using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002E4 RID: 740
[Token(Token = "0x20002E4")]
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
[Serializable]
public class PostEffectsBase : MonoBehaviour
{
	// Token: 0x060012EE RID: 4846 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012EE")]
	[Address(RVA = "0x2C67DB0", Offset = "0x2C66DB0", VA = "0x182C67DB0", Slot = "4")]
	public virtual Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
	{
		return null;
	}

	// Token: 0x060012EF RID: 4847 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012EF")]
	[Address(RVA = "0x2C68430", Offset = "0x2C67430", VA = "0x182C68430", Slot = "5")]
	public virtual Material CreateMaterial(Shader s, Material m2Create)
	{
		return null;
	}

	// Token: 0x060012F0 RID: 4848 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012F0")]
	[Address(RVA = "0x2C689F0", Offset = "0x2C679F0", VA = "0x182C689F0", Slot = "6")]
	public virtual void OnEnable()
	{
	}

	// Token: 0x060012F1 RID: 4849 RVA: 0x000066F0 File Offset: 0x000048F0
	[Token(Token = "0x60012F1")]
	[Address(RVA = "0x2C682B0", Offset = "0x2C672B0", VA = "0x182C682B0", Slot = "7")]
	public virtual bool CheckSupport()
	{
		return default(bool);
	}

	// Token: 0x060012F2 RID: 4850 RVA: 0x00006708 File Offset: 0x00004908
	[Token(Token = "0x60012F2")]
	[Address(RVA = "0x2C67D00", Offset = "0x2C66D00", VA = "0x182C67D00", Slot = "8")]
	public virtual bool CheckResources()
	{
		return default(bool);
	}

	// Token: 0x060012F3 RID: 4851 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012F3")]
	[Address(RVA = "0xDB9D10", Offset = "0xDB8D10", VA = "0x180DB9D10", Slot = "9")]
	public virtual void Start()
	{
	}

	// Token: 0x060012F4 RID: 4852 RVA: 0x00006720 File Offset: 0x00004920
	[Token(Token = "0x60012F4")]
	[Address(RVA = "0x2C682D0", Offset = "0x2C672D0", VA = "0x182C682D0", Slot = "10")]
	public virtual bool CheckSupport(bool needDepth)
	{
		return default(bool);
	}

	// Token: 0x060012F5 RID: 4853 RVA: 0x00006738 File Offset: 0x00004938
	[Token(Token = "0x60012F5")]
	[Address(RVA = "0x2C683D0", Offset = "0x2C673D0", VA = "0x182C683D0", Slot = "11")]
	public virtual bool CheckSupport(bool needDepth, bool needHdr)
	{
		return default(bool);
	}

	// Token: 0x060012F6 RID: 4854 RVA: 0x00006750 File Offset: 0x00004950
	[Token(Token = "0x60012F6")]
	[Address(RVA = "0x873BD0", Offset = "0x872BD0", VA = "0x180873BD0", Slot = "12")]
	public virtual bool Dx11Support()
	{
		return default(bool);
	}

	// Token: 0x060012F7 RID: 4855 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012F7")]
	[Address(RVA = "0x2C68A00", Offset = "0x2C67A00", VA = "0x182C68A00", Slot = "13")]
	public virtual void ReportAutoDisable()
	{
	}

	// Token: 0x060012F8 RID: 4856 RVA: 0x00006768 File Offset: 0x00004968
	[Token(Token = "0x60012F8")]
	[Address(RVA = "0x2C68100", Offset = "0x2C67100", VA = "0x182C68100", Slot = "14")]
	public virtual bool CheckShader(Shader s)
	{
		return default(bool);
	}

	// Token: 0x060012F9 RID: 4857 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012F9")]
	[Address(RVA = "0x2C689D0", Offset = "0x2C679D0", VA = "0x182C689D0", Slot = "15")]
	public virtual void NotSupported()
	{
	}

	// Token: 0x060012FA RID: 4858 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012FA")]
	[Address(RVA = "0x2C68620", Offset = "0x2C67620", VA = "0x182C68620", Slot = "16")]
	public virtual void DrawBorder(RenderTexture dest, Material material)
	{
	}

	// Token: 0x060012FB RID: 4859 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012FB")]
	[Address(RVA = "0x2C68AA0", Offset = "0x2C67AA0", VA = "0x182C68AA0")]
	public PostEffectsBase()
	{
	}

	// Token: 0x040012E3 RID: 4835
	[Token(Token = "0x40012E3")]
	[FieldOffset(Offset = "0x20")]
	protected bool supportHDRTextures;

	// Token: 0x040012E4 RID: 4836
	[Token(Token = "0x40012E4")]
	[FieldOffset(Offset = "0x21")]
	protected bool supportDX11;

	// Token: 0x040012E5 RID: 4837
	[Token(Token = "0x40012E5")]
	[FieldOffset(Offset = "0x22")]
	protected bool isSupported;
}
