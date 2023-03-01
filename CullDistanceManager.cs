using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001E2 RID: 482
[Token(Token = "0x20001E2")]
public class CullDistanceManager : MonoBehaviour
{
	// Token: 0x06000D60 RID: 3424 RVA: 0x000053D0 File Offset: 0x000035D0
	[Token(Token = "0x6000D60")]
	[Address(RVA = "0x2F838C0", Offset = "0x2F828C0", VA = "0x182F838C0")]
	private bool HasOverrideSetting()
	{
		return default(bool);
	}

	// Token: 0x06000D61 RID: 3425 RVA: 0x000053E8 File Offset: 0x000035E8
	[Token(Token = "0x6000D61")]
	[Address(RVA = "0x1C71DD0", Offset = "0x1C70DD0", VA = "0x181C71DD0")]
	public float GetFinalBillboardShadowDist()
	{
		return default(float);
	}

	// Token: 0x06000D62 RID: 3426 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D62")]
	[Address(RVA = "0x2F835D0", Offset = "0x2F825D0", VA = "0x182F835D0")]
	private static void AddCullDistanceManager()
	{
	}

	// Token: 0x06000D63 RID: 3427 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D63")]
	[Address(RVA = "0x2F83AB0", Offset = "0x2F82AB0", VA = "0x182F83AB0")]
	private void Start()
	{
	}

	// Token: 0x06000D64 RID: 3428 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D64")]
	[Address(RVA = "0x2F83910", Offset = "0x2F82910", VA = "0x182F83910")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000D65 RID: 3429 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D65")]
	[Address(RVA = "0x2F839F0", Offset = "0x2F829F0", VA = "0x182F839F0")]
	private void OnEnable()
	{
	}

	// Token: 0x06000D66 RID: 3430 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D66")]
	[Address(RVA = "0x2F83F50", Offset = "0x2F82F50", VA = "0x182F83F50")]
	private void Update()
	{
	}

	// Token: 0x06000D67 RID: 3431 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D67")]
	[Address(RVA = "0x2F83B80", Offset = "0x2F82B80", VA = "0x182F83B80")]
	private void UpdateCullDistances()
	{
	}

	// Token: 0x06000D68 RID: 3432 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D68")]
	[Address(RVA = "0x2F836D0", Offset = "0x2F826D0", VA = "0x182F836D0")]
	private Camera GetActiveCamera()
	{
		return null;
	}

	// Token: 0x06000D69 RID: 3433 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D69")]
	[Address(RVA = "0x2F83750", Offset = "0x2F82750", VA = "0x182F83750")]
	private float[] GetShadowCullDistances()
	{
		return null;
	}

	// Token: 0x06000D6A RID: 3434 RVA: 0x00005400 File Offset: 0x00003600
	[Token(Token = "0x6000D6A")]
	[Address(RVA = "0x2F836E0", Offset = "0x2F826E0", VA = "0x182F836E0")]
	public float GetLayerCullDistance(int layerNum)
	{
		return default(float);
	}

	// Token: 0x06000D6B RID: 3435 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D6B")]
	[Address(RVA = "0x2F83A00", Offset = "0x2F82A00", VA = "0x182F83A00")]
	public void SetLayerCullDistance(int layerNum, int distance)
	{
	}

	// Token: 0x06000D6C RID: 3436 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D6C")]
	[Address(RVA = "0x2F836A0", Offset = "0x2F826A0", VA = "0x182F836A0")]
	public void ClearSettingsOverride()
	{
	}

	// Token: 0x06000D6D RID: 3437 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D6D")]
	[Address(RVA = "0x2F83A80", Offset = "0x2F82A80", VA = "0x182F83A80")]
	public void SetSettingsOverride(CullDistanceSettings cullDistanceSettings)
	{
	}

	// Token: 0x06000D6E RID: 3438 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D6E")]
	[Address(RVA = "0x2F83FB0", Offset = "0x2F82FB0", VA = "0x182F83FB0")]
	public CullDistanceManager()
	{
	}

	// Token: 0x04000C7E RID: 3198
	[Token(Token = "0x4000C7E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _occlusionShadowDistanceMultiplier;

	// Token: 0x04000C7F RID: 3199
	[Token(Token = "0x4000C7F")]
	[FieldOffset(Offset = "0x24")]
	private bool _updateSceneCamera;

	// Token: 0x04000C80 RID: 3200
	[Token(Token = "0x4000C80")]
	[FieldOffset(Offset = "0x28")]
	private float[] SceneCamLayerCullDistances;

	// Token: 0x04000C81 RID: 3201
	[Token(Token = "0x4000C81")]
	[FieldOffset(Offset = "0x30")]
	public bool useDrawDistanceSetting;

	// Token: 0x04000C82 RID: 3202
	[Token(Token = "0x4000C82")]
	[FieldOffset(Offset = "0x0")]
	public static CullDistanceManager Instance;

	// Token: 0x04000C83 RID: 3203
	[Token(Token = "0x4000C83")]
	[FieldOffset(Offset = "0x38")]
	public CullDistanceSettings _settingsAsset;

	// Token: 0x04000C84 RID: 3204
	[Token(Token = "0x4000C84")]
	[FieldOffset(Offset = "0x40")]
	private CullDistanceSettings _overrideSettings;

	// Token: 0x04000C85 RID: 3205
	[Token(Token = "0x4000C85")]
	[FieldOffset(Offset = "0x48")]
	private float[] _layerCullDistances;

	// Token: 0x04000C86 RID: 3206
	[Token(Token = "0x4000C86")]
	[FieldOffset(Offset = "0x50")]
	public Light[] Lights;

	// Token: 0x04000C87 RID: 3207
	[Token(Token = "0x4000C87")]
	[FieldOffset(Offset = "0x58")]
	public bool Radial;

	// Token: 0x04000C88 RID: 3208
	[Token(Token = "0x4000C88")]
	[FieldOffset(Offset = "0x59")]
	public bool UpdateAtRuntime;

	// Token: 0x04000C89 RID: 3209
	[Token(Token = "0x4000C89")]
	[FieldOffset(Offset = "0x5C")]
	[Range(50f, 2000f)]
	public float BillboardShadowDist;

	// Token: 0x04000C8A RID: 3210
	[Token(Token = "0x4000C8A")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int BillboardShadowDistPID;

	// Token: 0x04000C8B RID: 3211
	[Token(Token = "0x4000C8B")]
	[FieldOffset(Offset = "0x60")]
	private float _finalBillboardShadowDist;

	// Token: 0x04000C8C RID: 3212
	[Token(Token = "0x4000C8C")]
	[FieldOffset(Offset = "0x68")]
	private float[] _cachedShadowCullDistances;

	// Token: 0x04000C8D RID: 3213
	[Token(Token = "0x4000C8D")]
	[FieldOffset(Offset = "0x70")]
	private Camera _mainCam;
}
