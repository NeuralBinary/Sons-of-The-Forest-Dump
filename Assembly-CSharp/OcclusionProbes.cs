using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000018 RID: 24
[Token(Token = "0x2000018")]
[ExecuteInEditMode]
public class OcclusionProbes : MonoBehaviour
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000058 RID: 88 RVA: 0x0000209A File Offset: 0x0000029A
	// (set) Token: 0x06000059 RID: 89 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000001")]
	public static OcclusionProbes Instance
	{
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x5D2C50", Offset = "0x5D1250", VA = "0x1805D2C50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x5D2C90", Offset = "0x5D1290", VA = "0x1805D2C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005A")]
	[Address(RVA = "0x5D2D20", Offset = "0x5D1320", VA = "0x1805D2D20")]
	private void OnEnable()
	{
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005B")]
	[Address(RVA = "0x5D2D30", Offset = "0x5D1330", VA = "0x1805D2D30")]
	private void OnDisable()
	{
	}

	// Token: 0x0600005C RID: 92 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005C")]
	[Address(RVA = "0x5D2ED0", Offset = "0x5D14D0", VA = "0x1805D2ED0")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600005D RID: 93 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005D")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void Cleanup()
	{
	}

	// Token: 0x0600005E RID: 94 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005E")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private static void OcclusionProbesSetup()
	{
	}

	// Token: 0x0600005F RID: 95 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005F")]
	[Address(RVA = "0x5D3030", Offset = "0x5D1630", VA = "0x1805D3030")]
	private void Start()
	{
	}

	// Token: 0x06000060 RID: 96 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000060")]
	[Address(RVA = "0x5D3180", Offset = "0x5D1780", VA = "0x1805D3180")]
	private void OnPreRender()
	{
	}

	// Token: 0x06000061 RID: 97 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000061")]
	[Address(RVA = "0x5D3320", Offset = "0x5D1920", VA = "0x1805D3320")]
	public static void SetupGPUData(Camera camera, CommandBuffer cmd)
	{
	}

	// Token: 0x06000062 RID: 98 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000062")]
	[Address(RVA = "0x5D3480", Offset = "0x5D1A80", VA = "0x1805D3480")]
	private static void GetShaderConstantsFromNormalizedSH(ref SphericalHarmonicsL2 ambientProbe, Vector4[] outCoefficients)
	{
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000063")]
	[Address(RVA = "0x5D36B0", Offset = "0x5D1CB0", VA = "0x1805D36B0")]
	private void SetShaderUniforms(CommandBuffer cmd, Camera camera)
	{
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000064")]
	[Address(RVA = "0x5D40F0", Offset = "0x5D26F0", VA = "0x1805D40F0")]
	private static void SetAmbientProbeShaderUniforms(CommandBuffer cmd, AmbientProbeData ambientProbeData)
	{
	}

	// Token: 0x06000065 RID: 101 RVA: 0x000020A0 File Offset: 0x000002A0
	[Token(Token = "0x6000065")]
	[Address(RVA = "0x5D4460", Offset = "0x5D2A60", VA = "0x1805D4460")]
	private static bool IsInside(Vector3 worldPos, Matrix4x4 worldToLocal)
	{
		return default(bool);
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000066")]
	[Address(RVA = "0x5D4530", Offset = "0x5D2B30", VA = "0x1805D4530")]
	private static void InitWhiteTexture()
	{
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000067")]
	[Address(RVA = "0x5D4810", Offset = "0x5D2E10", VA = "0x1805D4810")]
	private static void SetDisabledOcclusionShaderUniforms(CommandBuffer cmd)
	{
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000068")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public OcclusionProbes()
	{
	}

	// Token: 0x040000CA RID: 202
	[Token(Token = "0x40000CA")]
	[FieldOffset(Offset = "0x20")]
	[Header("Baked Results")]
	[Tooltip("Debug output in DebugMenu/Material/Material/Lit/SkyOcclusion")]
	public OcclusionProbeData m_Data;

	// Token: 0x040000CB RID: 203
	[Token(Token = "0x40000CB")]
	[FieldOffset(Offset = "0x28")]
	[Tooltip("Stores direct sky contribution. Baked with the button below or during lightmap bake. If not set, a probe generated from the current skybox will be used.")]
	public AmbientProbeData m_AmbientProbeData;

	// Token: 0x040000CC RID: 204
	[Token(Token = "0x40000CC")]
	[FieldOffset(Offset = "0x8")]
	private static Vector4[] ms_AmbientProbeSC;

	// Token: 0x040000CD RID: 205
	[Token(Token = "0x40000CD")]
	[FieldOffset(Offset = "0x10")]
	private static Texture3D ms_White;

	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	private static class Uniforms
	{
		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly int _AmbientProbeSH;

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x4")]
		internal static readonly int _OcclusionProbes;

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly int _OcclusionProbesWorldToLocal;

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0xC")]
		internal static readonly int _OcclusionProbesDetail;

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly int _OcclusionProbesWorldToLocalDetail;

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x14")]
		internal static readonly int _OcclusionProbesReflectionOcclusionAmount;
	}
}
