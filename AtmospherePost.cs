using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000097 RID: 151
[Token(Token = "0x2000097")]
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
public class AtmospherePost : MonoBehaviour
{
	// Token: 0x06000514 RID: 1300 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000514")]
	[Address(RVA = "0x2D491A0", Offset = "0x2D481A0", VA = "0x182D491A0")]
	private void Awake()
	{
	}

	// Token: 0x06000515 RID: 1301 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000515")]
	[Address(RVA = "0x2D495C0", Offset = "0x2D485C0", VA = "0x182D495C0")]
	private void Start()
	{
	}

	// Token: 0x06000516 RID: 1302 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000516")]
	[Address(RVA = "0x2D496F0", Offset = "0x2D486F0", VA = "0x182D496F0")]
	private void Update()
	{
	}

	// Token: 0x06000517 RID: 1303 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000517")]
	[Address(RVA = "0x2D494A0", Offset = "0x2D484A0", VA = "0x182D494A0")]
	public void SetAtmosphereProperties(float mieDirectionalG, float rayleighCoefficient, float mieCoefficient, float Molecules, float turbidity, float Exposure, Vector3 L, float sunE)
	{
	}

	// Token: 0x06000518 RID: 1304 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000518")]
	[Address(RVA = "0x2D49200", Offset = "0x2D48200", VA = "0x182D49200")]
	private void OnPreRender()
	{
	}

	// Token: 0x06000519 RID: 1305 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000519")]
	[Address(RVA = "0x2D49350", Offset = "0x2D48350", VA = "0x182D49350")]
	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	// Token: 0x0600051A RID: 1306 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600051A")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public AtmospherePost()
	{
	}

	// Token: 0x040004AC RID: 1196
	[Token(Token = "0x40004AC")]
	[FieldOffset(Offset = "0x0")]
	public static AtmospherePost instance;

	// Token: 0x040004AD RID: 1197
	[Token(Token = "0x40004AD")]
	[FieldOffset(Offset = "0x20")]
	public Material material;

	// Token: 0x040004AE RID: 1198
	[Token(Token = "0x40004AE")]
	[FieldOffset(Offset = "0x28")]
	public Shader shader;

	// Token: 0x040004AF RID: 1199
	[Token(Token = "0x40004AF")]
	[FieldOffset(Offset = "0x30")]
	private bool goodToGo;

	// Token: 0x040004B0 RID: 1200
	[Token(Token = "0x40004B0")]
	[FieldOffset(Offset = "0x8")]
	public static Vector3 L;

	// Token: 0x040004B1 RID: 1201
	[Token(Token = "0x40004B1")]
	[FieldOffset(Offset = "0x34")]
	private float mieDirectionalG;

	// Token: 0x040004B2 RID: 1202
	[Token(Token = "0x40004B2")]
	[FieldOffset(Offset = "0x38")]
	private float rayleighCoefficient;

	// Token: 0x040004B3 RID: 1203
	[Token(Token = "0x40004B3")]
	[FieldOffset(Offset = "0x3C")]
	private float mieCoefficient;

	// Token: 0x040004B4 RID: 1204
	[Token(Token = "0x40004B4")]
	[FieldOffset(Offset = "0x40")]
	private float Molecules;

	// Token: 0x040004B5 RID: 1205
	[Token(Token = "0x40004B5")]
	[FieldOffset(Offset = "0x44")]
	private float turbidity;

	// Token: 0x040004B6 RID: 1206
	[Token(Token = "0x40004B6")]
	[FieldOffset(Offset = "0x48")]
	private float Exposure;

	// Token: 0x040004B7 RID: 1207
	[Token(Token = "0x40004B7")]
	[FieldOffset(Offset = "0x4C")]
	private float sunE;
}
