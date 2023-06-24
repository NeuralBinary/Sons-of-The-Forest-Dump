using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001E1 RID: 481
[Token(Token = "0x20001E1")]
public class CullDistanceManager : MonoBehaviour
{
	// Token: 0x06000DBB RID: 3515 RVA: 0x00005610 File Offset: 0x00003810
	[Token(Token = "0x6000DBB")]
	[Address(RVA = "0x3709D00", Offset = "0x3708300", VA = "0x183709D00")]
	private bool HasOverrideSetting()
	{
		return default(bool);
	}

	// Token: 0x06000DBC RID: 3516 RVA: 0x00005628 File Offset: 0x00003828
	[Token(Token = "0x6000DBC")]
	[Address(RVA = "0x1F3D0A0", Offset = "0x1F3B6A0", VA = "0x181F3D0A0")]
	public float GetFinalBillboardShadowDist()
	{
		return 0f;
	}

	// Token: 0x06000DBD RID: 3517 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DBD")]
	[Address(RVA = "0x3709DC0", Offset = "0x37083C0", VA = "0x183709DC0")]
	private static void AddCullDistanceManager()
	{
	}

	// Token: 0x06000DBE RID: 3518 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DBE")]
	[Address(RVA = "0x3709F20", Offset = "0x3708520", VA = "0x183709F20")]
	private void Start()
	{
	}

	// Token: 0x06000DBF RID: 3519 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DBF")]
	[Address(RVA = "0x370A080", Offset = "0x3708680", VA = "0x18370A080")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000DC0 RID: 3520 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DC0")]
	[Address(RVA = "0x370A240", Offset = "0x3708840", VA = "0x18370A240")]
	private void OnEnable()
	{
	}

	// Token: 0x06000DC1 RID: 3521 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DC1")]
	[Address(RVA = "0x370A250", Offset = "0x3708850", VA = "0x18370A250")]
	private void Update()
	{
	}

	// Token: 0x06000DC2 RID: 3522 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DC2")]
	[Address(RVA = "0x370A260", Offset = "0x3708860", VA = "0x18370A260")]
	private void UpdateCullDistances()
	{
	}

	// Token: 0x06000DC3 RID: 3523 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DC3")]
	[Address(RVA = "0xA6A7F0", Offset = "0xA68DF0", VA = "0x180A6A7F0")]
	private Camera GetActiveCamera()
	{
		return null;
	}

	// Token: 0x06000DC4 RID: 3524 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DC4")]
	[Address(RVA = "0x370A7A0", Offset = "0x3708DA0", VA = "0x18370A7A0")]
	private float[] GetShadowCullDistances()
	{
		return null;
	}

	// Token: 0x06000DC5 RID: 3525 RVA: 0x00005640 File Offset: 0x00003840
	[Token(Token = "0x6000DC5")]
	[Address(RVA = "0x370A950", Offset = "0x3708F50", VA = "0x18370A950")]
	public float GetLayerCullDistance(int layerNum)
	{
		return 0f;
	}

	// Token: 0x06000DC6 RID: 3526 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DC6")]
	[Address(RVA = "0x370A9D0", Offset = "0x3708FD0", VA = "0x18370A9D0")]
	public void SetLayerCullDistance(int layerNum, int distance)
	{
	}

	// Token: 0x06000DC7 RID: 3527 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DC7")]
	[Address(RVA = "0x370AA70", Offset = "0x3709070", VA = "0x18370AA70")]
	public void ClearSettingsOverride()
	{
	}

	// Token: 0x06000DC8 RID: 3528 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DC8")]
	[Address(RVA = "0x370AAD0", Offset = "0x37090D0", VA = "0x18370AAD0")]
	public void SetSettingsOverride(CullDistanceSettings cullDistanceSettings)
	{
	}

	// Token: 0x06000DC9 RID: 3529 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DC9")]
	[Address(RVA = "0x370AB30", Offset = "0x3709130", VA = "0x18370AB30")]
	public CullDistanceManager()
	{
	}

	// Token: 0x04000CAD RID: 3245
	[Token(Token = "0x4000CAD")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _occlusionShadowDistanceMultiplier;

	// Token: 0x04000CAE RID: 3246
	[Token(Token = "0x4000CAE")]
	[FieldOffset(Offset = "0x24")]
	private bool _updateSceneCamera;

	// Token: 0x04000CAF RID: 3247
	[Token(Token = "0x4000CAF")]
	[FieldOffset(Offset = "0x28")]
	private float[] SceneCamLayerCullDistances;

	// Token: 0x04000CB0 RID: 3248
	[Token(Token = "0x4000CB0")]
	[FieldOffset(Offset = "0x30")]
	public bool useDrawDistanceSetting;

	// Token: 0x04000CB1 RID: 3249
	[Token(Token = "0x4000CB1")]
	[FieldOffset(Offset = "0x0")]
	public static CullDistanceManager Instance;

	// Token: 0x04000CB2 RID: 3250
	[Token(Token = "0x4000CB2")]
	[FieldOffset(Offset = "0x38")]
	public CullDistanceSettings _settingsAsset;

	// Token: 0x04000CB3 RID: 3251
	[Token(Token = "0x4000CB3")]
	[FieldOffset(Offset = "0x40")]
	private CullDistanceSettings _overrideSettings;

	// Token: 0x04000CB4 RID: 3252
	[Token(Token = "0x4000CB4")]
	[FieldOffset(Offset = "0x48")]
	private float[] _layerCullDistances;

	// Token: 0x04000CB5 RID: 3253
	[Token(Token = "0x4000CB5")]
	[FieldOffset(Offset = "0x50")]
	public Light[] Lights;

	// Token: 0x04000CB6 RID: 3254
	[Token(Token = "0x4000CB6")]
	[FieldOffset(Offset = "0x58")]
	public bool Radial;

	// Token: 0x04000CB7 RID: 3255
	[Token(Token = "0x4000CB7")]
	[FieldOffset(Offset = "0x59")]
	public bool UpdateAtRuntime;

	// Token: 0x04000CB8 RID: 3256
	[Token(Token = "0x4000CB8")]
	[FieldOffset(Offset = "0x5C")]
	[Range(50f, 2000f)]
	public float BillboardShadowDist;

	// Token: 0x04000CB9 RID: 3257
	[Token(Token = "0x4000CB9")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int BillboardShadowDistPID;

	// Token: 0x04000CBA RID: 3258
	[Token(Token = "0x4000CBA")]
	[FieldOffset(Offset = "0x60")]
	private float _finalBillboardShadowDist;

	// Token: 0x04000CBB RID: 3259
	[Token(Token = "0x4000CBB")]
	[FieldOffset(Offset = "0x68")]
	private float[] _cachedShadowCullDistances;

	// Token: 0x04000CBC RID: 3260
	[Token(Token = "0x4000CBC")]
	[FieldOffset(Offset = "0x70")]
	private Camera _mainCam;
}
