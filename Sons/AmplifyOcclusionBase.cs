using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200008C RID: 140
[Token(Token = "0x200008C")]
[AddComponentMenu("")]
public class AmplifyOcclusionBase : MonoBehaviour
{
	// Token: 0x170000CC RID: 204
	// (get) Token: 0x06000512 RID: 1298 RVA: 0x00003A98 File Offset: 0x00001C98
	[Token(Token = "0x170000CC")]
	private bool UsingTemporalFilter
	{
		[Token(Token = "0x6000512")]
		[Address(RVA = "0x33773F0", Offset = "0x33759F0", VA = "0x1833773F0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000CD RID: 205
	// (get) Token: 0x06000513 RID: 1299 RVA: 0x00003AB0 File Offset: 0x00001CB0
	[Token(Token = "0x170000CD")]
	private bool UsingMotionVectors
	{
		[Token(Token = "0x6000513")]
		[Address(RVA = "0x3377470", Offset = "0x3375A70", VA = "0x183377470")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000514 RID: 1300 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000514")]
	[Address(RVA = "0x33774A0", Offset = "0x3375AA0", VA = "0x1833774A0")]
	private void createCommandBuffer(ref AmplifyOcclusionBase.CmdBuffer aCmdBuffer, string aCmdBufferName, CameraEvent aCameraEvent)
	{
	}

	// Token: 0x06000515 RID: 1301 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000515")]
	[Address(RVA = "0x3377680", Offset = "0x3375C80", VA = "0x183377680")]
	private void cleanupCommandBuffer(ref AmplifyOcclusionBase.CmdBuffer aCmdBuffer)
	{
	}

	// Token: 0x06000516 RID: 1302 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000516")]
	[Address(RVA = "0x3377910", Offset = "0x3375F10", VA = "0x183377910")]
	private void createQuadMesh()
	{
	}

	// Token: 0x06000517 RID: 1303 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000517")]
	[Address(RVA = "0x3377FA0", Offset = "0x33765A0", VA = "0x183377FA0")]
	private void PerformBlit(CommandBuffer cb, Material mat, int pass)
	{
	}

	// Token: 0x06000518 RID: 1304 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000518")]
	[Address(RVA = "0x33780A0", Offset = "0x33766A0", VA = "0x1833780A0")]
	private Material createMaterialWithShaderName(string aShaderName, bool aThroughErrorMsg)
	{
		return null;
	}

	// Token: 0x06000519 RID: 1305 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000519")]
	[Address(RVA = "0x33782B0", Offset = "0x33768B0", VA = "0x1833782B0")]
	private void checkMaterials(bool aThroughErrorMsg)
	{
	}

	// Token: 0x0600051A RID: 1306 RVA: 0x00003AC8 File Offset: 0x00001CC8
	[Token(Token = "0x600051A")]
	[Address(RVA = "0x3378720", Offset = "0x3376D20", VA = "0x183378720")]
	private bool checkRenderTextureFormats()
	{
		return default(bool);
	}

	// Token: 0x0600051B RID: 1307 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600051B")]
	[Address(RVA = "0x33787A0", Offset = "0x3376DA0", VA = "0x1833787A0")]
	private void OnEnable()
	{
	}

	// Token: 0x0600051C RID: 1308 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600051C")]
	[Address(RVA = "0x3378A50", Offset = "0x3377050", VA = "0x183378A50")]
	private void Reset()
	{
	}

	// Token: 0x0600051D RID: 1309 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600051D")]
	[Address(RVA = "0x3378A50", Offset = "0x3377050", VA = "0x183378A50")]
	private void OnDisable()
	{
	}

	// Token: 0x0600051E RID: 1310 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600051E")]
	[Address(RVA = "0x3378AA0", Offset = "0x33770A0", VA = "0x183378AA0")]
	private void releaseRT()
	{
	}

	// Token: 0x0600051F RID: 1311 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600051F")]
	[Address(RVA = "0x3378BE0", Offset = "0x33771E0", VA = "0x183378BE0")]
	private void ClearHistory()
	{
	}

	// Token: 0x06000520 RID: 1312 RVA: 0x00003AE0 File Offset: 0x00001CE0
	[Token(Token = "0x6000520")]
	[Address(RVA = "0x3378D40", Offset = "0x3377340", VA = "0x183378D40")]
	private bool checkParamsChanged()
	{
		return default(bool);
	}

	// Token: 0x06000521 RID: 1313 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000521")]
	[Address(RVA = "0x3379670", Offset = "0x3377C70", VA = "0x183379670")]
	private void updateParams()
	{
	}

	// Token: 0x06000522 RID: 1314 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000522")]
	[Address(RVA = "0x33796E0", Offset = "0x3377CE0", VA = "0x1833796E0")]
	private void Update()
	{
	}

	// Token: 0x06000523 RID: 1315 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000523")]
	[Address(RVA = "0x3379AE0", Offset = "0x33780E0", VA = "0x183379AE0")]
	private void OnPreRender()
	{
	}

	// Token: 0x06000524 RID: 1316 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000524")]
	[Address(RVA = "0x3379E30", Offset = "0x3378430", VA = "0x183379E30")]
	private void OnPostRender()
	{
	}

	// Token: 0x06000525 RID: 1317 RVA: 0x00003AF8 File Offset: 0x00001CF8
	[Token(Token = "0x6000525")]
	[Address(RVA = "0x3379FD0", Offset = "0x33785D0", VA = "0x183379FD0")]
	private int safeAllocateTemporaryRT(CommandBuffer cb, string propertyName, int width, int height, RenderTextureFormat format = RenderTextureFormat.Default, RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default, FilterMode filterMode = FilterMode.Point)
	{
		return 0;
	}

	// Token: 0x06000526 RID: 1318 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000526")]
	[Address(RVA = "0x337A090", Offset = "0x3378690", VA = "0x18337A090")]
	private void safeReleaseTemporaryRT(CommandBuffer cb, int id)
	{
	}

	// Token: 0x06000527 RID: 1319 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000527")]
	[Address(RVA = "0x337A100", Offset = "0x3378700", VA = "0x18337A100")]
	private RenderTexture safeAllocateRT(string name, int width, int height, RenderTextureFormat format, RenderTextureReadWrite readWrite, FilterMode filterMode = FilterMode.Point, int antiAliasing = 1)
	{
		return null;
	}

	// Token: 0x06000528 RID: 1320 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000528")]
	[Address(RVA = "0x337A360", Offset = "0x3378960", VA = "0x18337A360")]
	private void safeReleaseRT(ref RenderTexture rt)
	{
	}

	// Token: 0x06000529 RID: 1321 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000529")]
	[Address(RVA = "0x337A520", Offset = "0x3378B20", VA = "0x18337A520")]
	private void BeginSample(CommandBuffer cb, string name)
	{
	}

	// Token: 0x0600052A RID: 1322 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600052A")]
	[Address(RVA = "0x337A590", Offset = "0x3378B90", VA = "0x18337A590")]
	private void EndSample(CommandBuffer cb, string name)
	{
	}

	// Token: 0x0600052B RID: 1323 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600052B")]
	[Address(RVA = "0x337A600", Offset = "0x3378C00", VA = "0x18337A600")]
	private void commandBuffer_FillComputeOcclusion(CommandBuffer cb)
	{
	}

	// Token: 0x0600052C RID: 1324 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600052C")]
	[Address(RVA = "0x337B150", Offset = "0x3379750", VA = "0x18337B150")]
	private void commandBuffer_Blur(CommandBuffer cb, RenderTargetIdentifier aSourceRT, int aSourceWidth, int aSourceHeight)
	{
	}

	// Token: 0x0600052D RID: 1325 RVA: 0x00003B10 File Offset: 0x00001D10
	[Token(Token = "0x600052D")]
	[Address(RVA = "0x337B870", Offset = "0x3379E70", VA = "0x18337B870")]
	private int getTemporalPass()
	{
		return 0;
	}

	// Token: 0x0600052E RID: 1326 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600052E")]
	[Address(RVA = "0x337B8B0", Offset = "0x3379EB0", VA = "0x18337B8B0")]
	private void commandBuffer_TemporalFilter(CommandBuffer cb)
	{
	}

	// Token: 0x0600052F RID: 1327 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600052F")]
	[Address(RVA = "0x337BD70", Offset = "0x337A370", VA = "0x18337BD70")]
	private void commandBuffer_FillApplyDeferred(CommandBuffer cb, bool logTarget)
	{
	}

	// Token: 0x06000530 RID: 1328 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000530")]
	[Address(RVA = "0x337CD30", Offset = "0x337B330", VA = "0x18337CD30")]
	private void commandBuffer_FillApplyPostEffect(CommandBuffer cb)
	{
	}

	// Token: 0x06000531 RID: 1329 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000531")]
	[Address(RVA = "0x337D380", Offset = "0x337B980", VA = "0x18337D380")]
	private void commandBuffer_FillApplyDebug(CommandBuffer cb)
	{
	}

	// Token: 0x06000532 RID: 1330 RVA: 0x00003B28 File Offset: 0x00001D28
	[Token(Token = "0x6000532")]
	[Address(RVA = "0x337D7D0", Offset = "0x337BDD0", VA = "0x18337D7D0")]
	private bool isStereoSinglePassEnabled()
	{
		return default(bool);
	}

	// Token: 0x06000533 RID: 1331 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000533")]
	[Address(RVA = "0x337D8A0", Offset = "0x337BEA0", VA = "0x18337D8A0")]
	private void UpdateGlobalShaderConstants()
	{
	}

	// Token: 0x06000534 RID: 1332 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000534")]
	[Address(RVA = "0x337E130", Offset = "0x337C730", VA = "0x18337E130")]
	private void UpdateGlobalShaderConstants_AmbientOcclusion()
	{
	}

	// Token: 0x06000535 RID: 1333 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000535")]
	[Address(RVA = "0x337E430", Offset = "0x337CA30", VA = "0x18337E430")]
	private void UpdateGlobalShaderConstants_Matrices()
	{
	}

	// Token: 0x06000536 RID: 1334 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000536")]
	[Address(RVA = "0x337F570", Offset = "0x337DB70", VA = "0x18337F570")]
	public AmplifyOcclusionBase()
	{
	}

	// Token: 0x0400042F RID: 1071
	[Token(Token = "0x400042F")]
	[FieldOffset(Offset = "0x20")]
	[Header("Ambient Occlusion")]
	[Tooltip("How to inject the occlusion: Post Effect = Overlay, Deferred = Deferred Injection, Debug - Vizualize.")]
	public AmplifyOcclusionBase.ApplicationMethod ApplyMethod;

	// Token: 0x04000430 RID: 1072
	[Token(Token = "0x4000430")]
	[FieldOffset(Offset = "0x24")]
	[Tooltip("Number of samples per pass.")]
	public AmplifyOcclusionBase.SampleCountLevel SampleCount;

	// Token: 0x04000431 RID: 1073
	[Token(Token = "0x4000431")]
	[FieldOffset(Offset = "0x28")]
	[Tooltip("Source of per-pixel normals: None = All, Camera = Forward, GBuffer = Deferred.")]
	public AmplifyOcclusionBase.PerPixelNormalSource PerPixelNormals;

	// Token: 0x04000432 RID: 1074
	[Token(Token = "0x4000432")]
	[FieldOffset(Offset = "0x2C")]
	[Range(0f, 1f)]
	[Tooltip("Final applied intensity of the occlusion effect.")]
	public float Intensity;

	// Token: 0x04000433 RID: 1075
	[Token(Token = "0x4000433")]
	[FieldOffset(Offset = "0x30")]
	[Tooltip("Color tint for occlusion.")]
	public Color Tint;

	// Token: 0x04000434 RID: 1076
	[Token(Token = "0x4000434")]
	[FieldOffset(Offset = "0x40")]
	[Tooltip("Radius spread of the occlusion.")]
	[Range(0f, 32f)]
	public float Radius;

	// Token: 0x04000435 RID: 1077
	[Token(Token = "0x4000435")]
	[FieldOffset(Offset = "0x44")]
	[Tooltip("Power exponent attenuation of the occlusion.")]
	[Range(0f, 16f)]
	public float PowerExponent;

	// Token: 0x04000436 RID: 1078
	[Token(Token = "0x4000436")]
	[FieldOffset(Offset = "0x48")]
	[Tooltip("Controls the initial occlusion contribution offset.")]
	[Range(0f, 0.99f)]
	public float Bias;

	// Token: 0x04000437 RID: 1079
	[Token(Token = "0x4000437")]
	[FieldOffset(Offset = "0x4C")]
	[Tooltip("Controls the thickness occlusion contribution.")]
	[Range(0f, 1f)]
	public float Thickness;

	// Token: 0x04000438 RID: 1080
	[Token(Token = "0x4000438")]
	[FieldOffset(Offset = "0x50")]
	[Tooltip("Compute the Occlusion and Blur at half of the resolution.")]
	public bool Downsample;

	// Token: 0x04000439 RID: 1081
	[Token(Token = "0x4000439")]
	[FieldOffset(Offset = "0x51")]
	[Tooltip("Control parameters at faraway.")]
	[Header("Distance Fade")]
	public bool FadeEnabled;

	// Token: 0x0400043A RID: 1082
	[Token(Token = "0x400043A")]
	[FieldOffset(Offset = "0x54")]
	[Tooltip("Distance in Unity unities that start to fade.")]
	public float FadeStart;

	// Token: 0x0400043B RID: 1083
	[Token(Token = "0x400043B")]
	[FieldOffset(Offset = "0x58")]
	[Tooltip("Length distance to performe the transition.")]
	public float FadeLength;

	// Token: 0x0400043C RID: 1084
	[Token(Token = "0x400043C")]
	[FieldOffset(Offset = "0x5C")]
	[Tooltip("Final Intensity parameter.")]
	[Range(0f, 1f)]
	public float FadeToIntensity;

	// Token: 0x0400043D RID: 1085
	[Token(Token = "0x400043D")]
	[FieldOffset(Offset = "0x60")]
	public Color FadeToTint;

	// Token: 0x0400043E RID: 1086
	[Token(Token = "0x400043E")]
	[FieldOffset(Offset = "0x70")]
	[Tooltip("Final Radius parameter.")]
	[Range(0f, 32f)]
	public float FadeToRadius;

	// Token: 0x0400043F RID: 1087
	[Token(Token = "0x400043F")]
	[FieldOffset(Offset = "0x74")]
	[Range(0f, 16f)]
	[Tooltip("Final PowerExponent parameter.")]
	public float FadeToPowerExponent;

	// Token: 0x04000440 RID: 1088
	[Token(Token = "0x4000440")]
	[FieldOffset(Offset = "0x78")]
	[Tooltip("Final Thickness parameter.")]
	[Range(0f, 1f)]
	public float FadeToThickness;

	// Token: 0x04000441 RID: 1089
	[Token(Token = "0x4000441")]
	[FieldOffset(Offset = "0x7C")]
	[Header("Bilateral Blur")]
	public bool BlurEnabled;

	// Token: 0x04000442 RID: 1090
	[Token(Token = "0x4000442")]
	[FieldOffset(Offset = "0x80")]
	[Tooltip("Radius in screen pixels.")]
	[Range(1f, 4f)]
	public int BlurRadius;

	// Token: 0x04000443 RID: 1091
	[Token(Token = "0x4000443")]
	[FieldOffset(Offset = "0x84")]
	[Tooltip("Number of times that the Blur will repeat.")]
	[Range(1f, 4f)]
	public int BlurPasses;

	// Token: 0x04000444 RID: 1092
	[Token(Token = "0x4000444")]
	[FieldOffset(Offset = "0x88")]
	[Tooltip("Sharpness of blur edge-detection: 0 = Softer Edges, 20 = Sharper Edges.")]
	[Range(0f, 20f)]
	public float BlurSharpness;

	// Token: 0x04000445 RID: 1093
	[Token(Token = "0x4000445")]
	[FieldOffset(Offset = "0x8C")]
	[Header("Temporal Filter")]
	[Tooltip("Accumulates the effect over the time.")]
	public bool FilterEnabled;

	// Token: 0x04000446 RID: 1094
	[Token(Token = "0x4000446")]
	[FieldOffset(Offset = "0x90")]
	[Tooltip("Controls the accumulation decayment: 0 = More flicker with less ghosting, 1 = Less flicker with more ghosting.")]
	[Range(0f, 1f)]
	public float FilterBlending;

	// Token: 0x04000447 RID: 1095
	[Token(Token = "0x4000447")]
	[FieldOffset(Offset = "0x94")]
	[Tooltip("Controls the discard sensitivity based on the motion of the scene and objects.")]
	[Range(0f, 1f)]
	public float FilterResponse;

	// Token: 0x04000448 RID: 1096
	[Token(Token = "0x4000448")]
	[FieldOffset(Offset = "0x98")]
	[Tooltip("Reduces ghosting effect near the objects's edges while moving.")]
	private bool TemporalDilation;

	// Token: 0x04000449 RID: 1097
	[Token(Token = "0x4000449")]
	[FieldOffset(Offset = "0x99")]
	private bool m_HDR;

	// Token: 0x0400044A RID: 1098
	[Token(Token = "0x400044A")]
	[FieldOffset(Offset = "0x9A")]
	private bool m_MSAA;

	// Token: 0x0400044B RID: 1099
	[Token(Token = "0x400044B")]
	[FieldOffset(Offset = "0x9C")]
	private AmplifyOcclusionBase.PerPixelNormalSource m_prevPerPixelNormals;

	// Token: 0x0400044C RID: 1100
	[Token(Token = "0x400044C")]
	[FieldOffset(Offset = "0xA0")]
	private AmplifyOcclusionBase.ApplicationMethod m_prevApplyMethod;

	// Token: 0x0400044D RID: 1101
	[Token(Token = "0x400044D")]
	[FieldOffset(Offset = "0xA4")]
	private bool m_prevDeferredReflections;

	// Token: 0x0400044E RID: 1102
	[Token(Token = "0x400044E")]
	[FieldOffset(Offset = "0xA8")]
	private AmplifyOcclusionBase.SampleCountLevel m_prevSampleCount;

	// Token: 0x0400044F RID: 1103
	[Token(Token = "0x400044F")]
	[FieldOffset(Offset = "0xAC")]
	private bool m_prevDownsample;

	// Token: 0x04000450 RID: 1104
	[Token(Token = "0x4000450")]
	[FieldOffset(Offset = "0xAD")]
	private bool m_prevBlurEnabled;

	// Token: 0x04000451 RID: 1105
	[Token(Token = "0x4000451")]
	[FieldOffset(Offset = "0xB0")]
	private int m_prevBlurRadius;

	// Token: 0x04000452 RID: 1106
	[Token(Token = "0x4000452")]
	[FieldOffset(Offset = "0xB4")]
	private int m_prevBlurPasses;

	// Token: 0x04000453 RID: 1107
	[Token(Token = "0x4000453")]
	[FieldOffset(Offset = "0xB8")]
	private bool m_prevFilterEnabled;

	// Token: 0x04000454 RID: 1108
	[Token(Token = "0x4000454")]
	[FieldOffset(Offset = "0xB9")]
	private bool m_prevHDR;

	// Token: 0x04000455 RID: 1109
	[Token(Token = "0x4000455")]
	[FieldOffset(Offset = "0xBA")]
	private bool m_prevMSAA;

	// Token: 0x04000456 RID: 1110
	[Token(Token = "0x4000456")]
	[FieldOffset(Offset = "0xC0")]
	private Camera m_targetCamera;

	// Token: 0x04000457 RID: 1111
	[Token(Token = "0x4000457")]
	[FieldOffset(Offset = "0xC8")]
	private RenderTargetIdentifier[] applyDebugTargetsTemporal;

	// Token: 0x04000458 RID: 1112
	[Token(Token = "0x4000458")]
	[FieldOffset(Offset = "0xD0")]
	private RenderTargetIdentifier[] applyDeferredTargets_Log_Temporal;

	// Token: 0x04000459 RID: 1113
	[Token(Token = "0x4000459")]
	[FieldOffset(Offset = "0xD8")]
	private RenderTargetIdentifier[] applyDeferredTargetsTemporal;

	// Token: 0x0400045A RID: 1114
	[Token(Token = "0x400045A")]
	[FieldOffset(Offset = "0xE0")]
	private RenderTargetIdentifier[] applyOcclusionTemporal;

	// Token: 0x0400045B RID: 1115
	[Token(Token = "0x400045B")]
	[FieldOffset(Offset = "0xE8")]
	private RenderTargetIdentifier[] applyPostEffectTargetsTemporal;

	// Token: 0x0400045C RID: 1116
	[Token(Token = "0x400045C")]
	[FieldOffset(Offset = "0xF0")]
	private bool useMRTBlendingFallback;

	// Token: 0x0400045D RID: 1117
	[Token(Token = "0x400045D")]
	[FieldOffset(Offset = "0xF8")]
	private AmplifyOcclusionBase.CmdBuffer m_commandBuffer_Occlusion;

	// Token: 0x0400045E RID: 1118
	[Token(Token = "0x400045E")]
	[FieldOffset(Offset = "0x110")]
	private AmplifyOcclusionBase.CmdBuffer m_commandBuffer_Apply;

	// Token: 0x0400045F RID: 1119
	[Token(Token = "0x400045F")]
	[FieldOffset(Offset = "0x0")]
	private static Mesh m_quadMesh;

	// Token: 0x04000460 RID: 1120
	[Token(Token = "0x4000460")]
	[FieldOffset(Offset = "0x8")]
	private static Material m_occlusionMat;

	// Token: 0x04000461 RID: 1121
	[Token(Token = "0x4000461")]
	[FieldOffset(Offset = "0x10")]
	private static Material m_blurMat;

	// Token: 0x04000462 RID: 1122
	[Token(Token = "0x4000462")]
	[FieldOffset(Offset = "0x18")]
	private static Material m_applyOcclusionMat;

	// Token: 0x04000463 RID: 1123
	[Token(Token = "0x4000463")]
	[FieldOffset(Offset = "0x128")]
	private RenderTextureFormat m_occlusionRTFormat;

	// Token: 0x04000464 RID: 1124
	[Token(Token = "0x4000464")]
	[FieldOffset(Offset = "0x12C")]
	private RenderTextureFormat m_accumTemporalRTFormat;

	// Token: 0x04000465 RID: 1125
	[Token(Token = "0x4000465")]
	[FieldOffset(Offset = "0x130")]
	private RenderTextureFormat m_temporaryEmissionRTFormat;

	// Token: 0x04000466 RID: 1126
	[Token(Token = "0x4000466")]
	[FieldOffset(Offset = "0x134")]
	private bool m_paramsChanged;

	// Token: 0x04000467 RID: 1127
	[Token(Token = "0x4000467")]
	[FieldOffset(Offset = "0x138")]
	private RenderTexture m_occlusionDepthRT;

	// Token: 0x04000468 RID: 1128
	[Token(Token = "0x4000468")]
	[FieldOffset(Offset = "0x140")]
	private RenderTexture[] m_temporalAccumRT;

	// Token: 0x04000469 RID: 1129
	[Token(Token = "0x4000469")]
	[FieldOffset(Offset = "0x148")]
	private uint m_sampleStep;

	// Token: 0x0400046A RID: 1130
	[Token(Token = "0x400046A")]
	[FieldOffset(Offset = "0x14C")]
	private uint m_curStepIdx;

	// Token: 0x0400046B RID: 1131
	[Token(Token = "0x400046B")]
	[FieldOffset(Offset = "0x20")]
	private static readonly int PerPixelNormalSourceCount;

	// Token: 0x0400046C RID: 1132
	[Token(Token = "0x400046C")]
	[FieldOffset(Offset = "0x150")]
	private Matrix4x4 m_prevViewProjMatrixLeft;

	// Token: 0x0400046D RID: 1133
	[Token(Token = "0x400046D")]
	[FieldOffset(Offset = "0x190")]
	private Matrix4x4 m_prevInvViewProjMatrixLeft;

	// Token: 0x0400046E RID: 1134
	[Token(Token = "0x400046E")]
	[FieldOffset(Offset = "0x1D0")]
	private Matrix4x4 m_prevViewProjMatrixRight;

	// Token: 0x0400046F RID: 1135
	[Token(Token = "0x400046F")]
	[FieldOffset(Offset = "0x210")]
	private Matrix4x4 m_prevInvViewProjMatrixRight;

	// Token: 0x04000470 RID: 1136
	[Token(Token = "0x4000470")]
	[FieldOffset(Offset = "0x28")]
	private static readonly float[] m_temporalRotations;

	// Token: 0x04000471 RID: 1137
	[Token(Token = "0x4000471")]
	[FieldOffset(Offset = "0x30")]
	private static readonly float[] m_spatialOffsets;

	// Token: 0x04000472 RID: 1138
	[Token(Token = "0x4000472")]
	[FieldOffset(Offset = "0x250")]
	private readonly RenderTargetIdentifier[] m_applyDeferredTargets;

	// Token: 0x04000473 RID: 1139
	[Token(Token = "0x4000473")]
	[FieldOffset(Offset = "0x258")]
	private readonly RenderTargetIdentifier[] m_applyDeferredTargets_Log;

	// Token: 0x04000474 RID: 1140
	[Token(Token = "0x4000474")]
	[FieldOffset(Offset = "0x260")]
	private AmplifyOcclusionBase.TargetDesc m_target;

	// Token: 0x0200008D RID: 141
	[Token(Token = "0x200008D")]
	public enum ApplicationMethod
	{
		// Token: 0x04000476 RID: 1142
		[Token(Token = "0x4000476")]
		PostEffect,
		// Token: 0x04000477 RID: 1143
		[Token(Token = "0x4000477")]
		Deferred,
		// Token: 0x04000478 RID: 1144
		[Token(Token = "0x4000478")]
		Debug
	}

	// Token: 0x0200008E RID: 142
	[Token(Token = "0x200008E")]
	public enum PerPixelNormalSource
	{
		// Token: 0x0400047A RID: 1146
		[Token(Token = "0x400047A")]
		None,
		// Token: 0x0400047B RID: 1147
		[Token(Token = "0x400047B")]
		Camera,
		// Token: 0x0400047C RID: 1148
		[Token(Token = "0x400047C")]
		GBuffer,
		// Token: 0x0400047D RID: 1149
		[Token(Token = "0x400047D")]
		GBufferOctaEncoded
	}

	// Token: 0x0200008F RID: 143
	[Token(Token = "0x200008F")]
	public enum SampleCountLevel
	{
		// Token: 0x0400047F RID: 1151
		[Token(Token = "0x400047F")]
		Low,
		// Token: 0x04000480 RID: 1152
		[Token(Token = "0x4000480")]
		Medium,
		// Token: 0x04000481 RID: 1153
		[Token(Token = "0x4000481")]
		High,
		// Token: 0x04000482 RID: 1154
		[Token(Token = "0x4000482")]
		VeryHigh
	}

	// Token: 0x02000090 RID: 144
	[Token(Token = "0x2000090")]
	private struct CmdBuffer
	{
		// Token: 0x04000483 RID: 1155
		[Token(Token = "0x4000483")]
		[FieldOffset(Offset = "0x0")]
		public CommandBuffer cmdBuffer;

		// Token: 0x04000484 RID: 1156
		[Token(Token = "0x4000484")]
		[FieldOffset(Offset = "0x8")]
		public CameraEvent cmdBufferEvent;

		// Token: 0x04000485 RID: 1157
		[Token(Token = "0x4000485")]
		[FieldOffset(Offset = "0x10")]
		public string cmdBufferName;
	}

	// Token: 0x02000091 RID: 145
	[Token(Token = "0x2000091")]
	private struct TargetDesc
	{
		// Token: 0x04000486 RID: 1158
		[Token(Token = "0x4000486")]
		[FieldOffset(Offset = "0x0")]
		public int fullWidth;

		// Token: 0x04000487 RID: 1159
		[Token(Token = "0x4000487")]
		[FieldOffset(Offset = "0x4")]
		public int fullHeight;

		// Token: 0x04000488 RID: 1160
		[Token(Token = "0x4000488")]
		[FieldOffset(Offset = "0x8")]
		public int width;

		// Token: 0x04000489 RID: 1161
		[Token(Token = "0x4000489")]
		[FieldOffset(Offset = "0xC")]
		public int height;

		// Token: 0x0400048A RID: 1162
		[Token(Token = "0x400048A")]
		[FieldOffset(Offset = "0x10")]
		public float oneOverWidth;

		// Token: 0x0400048B RID: 1163
		[Token(Token = "0x400048B")]
		[FieldOffset(Offset = "0x14")]
		public float oneOverHeight;
	}

	// Token: 0x02000092 RID: 146
	[Token(Token = "0x2000092")]
	private static class ShaderPass
	{
		// Token: 0x0400048C RID: 1164
		[Token(Token = "0x400048C")]
		public const int CombineDownsampledOcclusionDepth = 16;

		// Token: 0x0400048D RID: 1165
		[Token(Token = "0x400048D")]
		public const int BlurHorizontal1 = 0;

		// Token: 0x0400048E RID: 1166
		[Token(Token = "0x400048E")]
		public const int BlurVertical1 = 1;

		// Token: 0x0400048F RID: 1167
		[Token(Token = "0x400048F")]
		public const int BlurHorizontal2 = 2;

		// Token: 0x04000490 RID: 1168
		[Token(Token = "0x4000490")]
		public const int BlurVertical2 = 3;

		// Token: 0x04000491 RID: 1169
		[Token(Token = "0x4000491")]
		public const int BlurHorizontal3 = 4;

		// Token: 0x04000492 RID: 1170
		[Token(Token = "0x4000492")]
		public const int BlurVertical3 = 5;

		// Token: 0x04000493 RID: 1171
		[Token(Token = "0x4000493")]
		public const int BlurHorizontal4 = 6;

		// Token: 0x04000494 RID: 1172
		[Token(Token = "0x4000494")]
		public const int BlurVertical4 = 7;

		// Token: 0x04000495 RID: 1173
		[Token(Token = "0x4000495")]
		public const int ApplyDebug = 0;

		// Token: 0x04000496 RID: 1174
		[Token(Token = "0x4000496")]
		public const int ApplyDebugTemporal = 1;

		// Token: 0x04000497 RID: 1175
		[Token(Token = "0x4000497")]
		public const int ApplyDeferred = 5;

		// Token: 0x04000498 RID: 1176
		[Token(Token = "0x4000498")]
		public const int ApplyDeferredTemporal = 6;

		// Token: 0x04000499 RID: 1177
		[Token(Token = "0x4000499")]
		public const int ApplyDeferredLog = 10;

		// Token: 0x0400049A RID: 1178
		[Token(Token = "0x400049A")]
		public const int ApplyDeferredLogTemporal = 11;

		// Token: 0x0400049B RID: 1179
		[Token(Token = "0x400049B")]
		public const int ApplyPostEffect = 15;

		// Token: 0x0400049C RID: 1180
		[Token(Token = "0x400049C")]
		public const int ApplyPostEffectTemporal = 16;

		// Token: 0x0400049D RID: 1181
		[Token(Token = "0x400049D")]
		public const int ApplyPostEffectTemporalMultiply = 20;

		// Token: 0x0400049E RID: 1182
		[Token(Token = "0x400049E")]
		public const int ApplyDeferredTemporalMultiply = 21;

		// Token: 0x0400049F RID: 1183
		[Token(Token = "0x400049F")]
		public const int OcclusionLow_None = 0;

		// Token: 0x040004A0 RID: 1184
		[Token(Token = "0x40004A0")]
		public const int OcclusionLow_Camera = 1;

		// Token: 0x040004A1 RID: 1185
		[Token(Token = "0x40004A1")]
		public const int OcclusionLow_GBuffer = 2;

		// Token: 0x040004A2 RID: 1186
		[Token(Token = "0x40004A2")]
		public const int OcclusionLow_GBufferOctaEncoded = 3;
	}

	// Token: 0x02000093 RID: 147
	[Token(Token = "0x2000093")]
	private static class PropertyID
	{
		// Token: 0x040004A3 RID: 1187
		[Token(Token = "0x40004A3")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int _AO_Radius;

		// Token: 0x040004A4 RID: 1188
		[Token(Token = "0x40004A4")]
		[FieldOffset(Offset = "0x4")]
		public static readonly int _AO_PowExponent;

		// Token: 0x040004A5 RID: 1189
		[Token(Token = "0x40004A5")]
		[FieldOffset(Offset = "0x8")]
		public static readonly int _AO_Bias;

		// Token: 0x040004A6 RID: 1190
		[Token(Token = "0x40004A6")]
		[FieldOffset(Offset = "0xC")]
		public static readonly int _AO_Levels;

		// Token: 0x040004A7 RID: 1191
		[Token(Token = "0x40004A7")]
		[FieldOffset(Offset = "0x10")]
		public static readonly int _AO_ThicknessDecay;

		// Token: 0x040004A8 RID: 1192
		[Token(Token = "0x40004A8")]
		[FieldOffset(Offset = "0x14")]
		public static readonly int _AO_BlurSharpness;

		// Token: 0x040004A9 RID: 1193
		[Token(Token = "0x40004A9")]
		[FieldOffset(Offset = "0x18")]
		public static readonly int _AO_CameraViewLeft;

		// Token: 0x040004AA RID: 1194
		[Token(Token = "0x40004AA")]
		[FieldOffset(Offset = "0x1C")]
		public static readonly int _AO_CameraViewRight;

		// Token: 0x040004AB RID: 1195
		[Token(Token = "0x40004AB")]
		[FieldOffset(Offset = "0x20")]
		public static readonly int _AO_ProjMatrixLeft;

		// Token: 0x040004AC RID: 1196
		[Token(Token = "0x40004AC")]
		[FieldOffset(Offset = "0x24")]
		public static readonly int _AO_ProjMatrixRight;

		// Token: 0x040004AD RID: 1197
		[Token(Token = "0x40004AD")]
		[FieldOffset(Offset = "0x28")]
		public static readonly int _AO_InvViewProjMatrixLeft;

		// Token: 0x040004AE RID: 1198
		[Token(Token = "0x40004AE")]
		[FieldOffset(Offset = "0x2C")]
		public static readonly int _AO_PrevViewProjMatrixLeft;

		// Token: 0x040004AF RID: 1199
		[Token(Token = "0x40004AF")]
		[FieldOffset(Offset = "0x30")]
		public static readonly int _AO_PrevInvViewProjMatrixLeft;

		// Token: 0x040004B0 RID: 1200
		[Token(Token = "0x40004B0")]
		[FieldOffset(Offset = "0x34")]
		public static readonly int _AO_InvViewProjMatrixRight;

		// Token: 0x040004B1 RID: 1201
		[Token(Token = "0x40004B1")]
		[FieldOffset(Offset = "0x38")]
		public static readonly int _AO_PrevViewProjMatrixRight;

		// Token: 0x040004B2 RID: 1202
		[Token(Token = "0x40004B2")]
		[FieldOffset(Offset = "0x3C")]
		public static readonly int _AO_PrevInvViewProjMatrixRight;

		// Token: 0x040004B3 RID: 1203
		[Token(Token = "0x40004B3")]
		[FieldOffset(Offset = "0x40")]
		public static readonly int _AO_GBufferNormals;

		// Token: 0x040004B4 RID: 1204
		[Token(Token = "0x40004B4")]
		[FieldOffset(Offset = "0x44")]
		public static readonly int _AO_Target_TexelSize;

		// Token: 0x040004B5 RID: 1205
		[Token(Token = "0x40004B5")]
		[FieldOffset(Offset = "0x48")]
		public static readonly int _AO_TemporalCurveAdj;

		// Token: 0x040004B6 RID: 1206
		[Token(Token = "0x40004B6")]
		[FieldOffset(Offset = "0x4C")]
		public static readonly int _AO_TemporalMotionSensibility;

		// Token: 0x040004B7 RID: 1207
		[Token(Token = "0x40004B7")]
		[FieldOffset(Offset = "0x50")]
		public static readonly int _AO_CurrOcclusionDepth;

		// Token: 0x040004B8 RID: 1208
		[Token(Token = "0x40004B8")]
		[FieldOffset(Offset = "0x54")]
		public static readonly int _AO_TemporalAccumm;

		// Token: 0x040004B9 RID: 1209
		[Token(Token = "0x40004B9")]
		[FieldOffset(Offset = "0x58")]
		public static readonly int _AO_TemporalDirections;

		// Token: 0x040004BA RID: 1210
		[Token(Token = "0x40004BA")]
		[FieldOffset(Offset = "0x5C")]
		public static readonly int _AO_TemporalOffsets;

		// Token: 0x040004BB RID: 1211
		[Token(Token = "0x40004BB")]
		[FieldOffset(Offset = "0x60")]
		public static readonly int _AO_OcclusionTexture;

		// Token: 0x040004BC RID: 1212
		[Token(Token = "0x40004BC")]
		[FieldOffset(Offset = "0x64")]
		public static readonly int _AO_GBufferAlbedo;

		// Token: 0x040004BD RID: 1213
		[Token(Token = "0x40004BD")]
		[FieldOffset(Offset = "0x68")]
		public static readonly int _AO_GBufferEmission;

		// Token: 0x040004BE RID: 1214
		[Token(Token = "0x40004BE")]
		[FieldOffset(Offset = "0x6C")]
		public static readonly int _AO_UVToView;

		// Token: 0x040004BF RID: 1215
		[Token(Token = "0x40004BF")]
		[FieldOffset(Offset = "0x70")]
		public static readonly int _AO_HalfProjScale;

		// Token: 0x040004C0 RID: 1216
		[Token(Token = "0x40004C0")]
		[FieldOffset(Offset = "0x74")]
		public static readonly int _AO_FadeParams;

		// Token: 0x040004C1 RID: 1217
		[Token(Token = "0x40004C1")]
		[FieldOffset(Offset = "0x78")]
		public static readonly int _AO_FadeValues;

		// Token: 0x040004C2 RID: 1218
		[Token(Token = "0x40004C2")]
		[FieldOffset(Offset = "0x7C")]
		public static readonly int _AO_FadeToTint;

		// Token: 0x040004C3 RID: 1219
		[Token(Token = "0x40004C3")]
		[FieldOffset(Offset = "0x80")]
		public static readonly int _AO_Source_TexelSize;

		// Token: 0x040004C4 RID: 1220
		[Token(Token = "0x40004C4")]
		[FieldOffset(Offset = "0x84")]
		public static readonly int _AO_Source;
	}
}
