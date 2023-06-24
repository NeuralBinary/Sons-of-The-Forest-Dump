using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002D8 RID: 728
[Token(Token = "0x20002D8")]
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
[Serializable]
public class PostEffectsBase : MonoBehaviour
{
	// Token: 0x06001324 RID: 4900 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001324")]
	[Address(RVA = "0x31EE110", Offset = "0x31EC710", VA = "0x1831EE110", Slot = "4")]
	public virtual Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
	{
		return null;
	}

	// Token: 0x06001325 RID: 4901 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001325")]
	[Address(RVA = "0x31EE610", Offset = "0x31ECC10", VA = "0x1831EE610", Slot = "5")]
	public virtual Material CreateMaterial(Shader s, Material m2Create)
	{
		return null;
	}

	// Token: 0x06001326 RID: 4902 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001326")]
	[Address(RVA = "0x31EE9A0", Offset = "0x31ECFA0", VA = "0x1831EE9A0", Slot = "6")]
	public virtual void OnEnable()
	{
	}

	// Token: 0x06001327 RID: 4903 RVA: 0x00006960 File Offset: 0x00004B60
	[Token(Token = "0x6001327")]
	[Address(RVA = "0x31EE9B0", Offset = "0x31ECFB0", VA = "0x1831EE9B0", Slot = "7")]
	public virtual bool CheckSupport()
	{
		return default(bool);
	}

	// Token: 0x06001328 RID: 4904 RVA: 0x00006978 File Offset: 0x00004B78
	[Token(Token = "0x6001328")]
	[Address(RVA = "0x31EE9D0", Offset = "0x31ECFD0", VA = "0x1831EE9D0", Slot = "8")]
	public virtual bool CheckResources()
	{
		return default(bool);
	}

	// Token: 0x06001329 RID: 4905 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001329")]
	[Address(RVA = "0xFAB1C0", Offset = "0xFA97C0", VA = "0x180FAB1C0", Slot = "9")]
	public virtual void Start()
	{
	}

	// Token: 0x0600132A RID: 4906 RVA: 0x00006990 File Offset: 0x00004B90
	[Token(Token = "0x600132A")]
	[Address(RVA = "0x31EEA80", Offset = "0x31ED080", VA = "0x1831EEA80", Slot = "10")]
	public virtual bool CheckSupport(bool needDepth)
	{
		return default(bool);
	}

	// Token: 0x0600132B RID: 4907 RVA: 0x000069A8 File Offset: 0x00004BA8
	[Token(Token = "0x600132B")]
	[Address(RVA = "0x31EEBE0", Offset = "0x31ED1E0", VA = "0x1831EEBE0", Slot = "11")]
	public virtual bool CheckSupport(bool needDepth, bool needHdr)
	{
		return default(bool);
	}

	// Token: 0x0600132C RID: 4908 RVA: 0x000069C0 File Offset: 0x00004BC0
	[Token(Token = "0x600132C")]
	[Address(RVA = "0x9938E0", Offset = "0x991EE0", VA = "0x1809938E0", Slot = "12")]
	public virtual bool Dx11Support()
	{
		return default(bool);
	}

	// Token: 0x0600132D RID: 4909 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600132D")]
	[Address(RVA = "0x31EEC40", Offset = "0x31ED240", VA = "0x1831EEC40", Slot = "13")]
	public virtual void ReportAutoDisable()
	{
	}

	// Token: 0x0600132E RID: 4910 RVA: 0x000069D8 File Offset: 0x00004BD8
	[Token(Token = "0x600132E")]
	[Address(RVA = "0x31EECE0", Offset = "0x31ED2E0", VA = "0x1831EECE0", Slot = "14")]
	public virtual bool CheckShader(Shader s)
	{
		return default(bool);
	}

	// Token: 0x0600132F RID: 4911 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600132F")]
	[Address(RVA = "0x31EEE90", Offset = "0x31ED490", VA = "0x1831EEE90", Slot = "15")]
	public virtual void NotSupported()
	{
	}

	// Token: 0x06001330 RID: 4912 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001330")]
	[Address(RVA = "0x31EEEF0", Offset = "0x31ED4F0", VA = "0x1831EEEF0", Slot = "16")]
	public virtual void DrawBorder(RenderTexture dest, Material material)
	{
	}

	// Token: 0x06001331 RID: 4913 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001331")]
	[Address(RVA = "0x31EF430", Offset = "0x31EDA30", VA = "0x1831EF430")]
	public PostEffectsBase()
	{
	}

	// Token: 0x0400130B RID: 4875
	[Token(Token = "0x400130B")]
	[FieldOffset(Offset = "0x20")]
	protected bool supportHDRTextures;

	// Token: 0x0400130C RID: 4876
	[Token(Token = "0x400130C")]
	[FieldOffset(Offset = "0x21")]
	protected bool supportDX11;

	// Token: 0x0400130D RID: 4877
	[Token(Token = "0x400130D")]
	[FieldOffset(Offset = "0x22")]
	protected bool isSupported;
}
