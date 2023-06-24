using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000097 RID: 151
[Token(Token = "0x2000097")]
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
public class AtmospherePost : MonoBehaviour
{
	// Token: 0x0600053E RID: 1342 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600053E")]
	[Address(RVA = "0x35002E0", Offset = "0x34FE8E0", VA = "0x1835002E0")]
	private void Awake()
	{
	}

	// Token: 0x0600053F RID: 1343 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600053F")]
	[Address(RVA = "0x3500370", Offset = "0x34FE970", VA = "0x183500370")]
	private void Start()
	{
	}

	// Token: 0x06000540 RID: 1344 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000540")]
	[Address(RVA = "0x35005D0", Offset = "0x34FEBD0", VA = "0x1835005D0")]
	private void Update()
	{
	}

	// Token: 0x06000541 RID: 1345 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000541")]
	[Address(RVA = "0x3500660", Offset = "0x34FEC60", VA = "0x183500660")]
	public void SetAtmosphereProperties(float mieDirectionalG, float rayleighCoefficient, float mieCoefficient, float Molecules, float turbidity, float Exposure, Vector3 L, float sunE)
	{
	}

	// Token: 0x06000542 RID: 1346 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000542")]
	[Address(RVA = "0x3500780", Offset = "0x34FED80", VA = "0x183500780")]
	private void OnPreRender()
	{
	}

	// Token: 0x06000543 RID: 1347 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000543")]
	[Address(RVA = "0x35009C0", Offset = "0x34FEFC0", VA = "0x1835009C0")]
	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	// Token: 0x06000544 RID: 1348 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000544")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public AtmospherePost()
	{
	}

	// Token: 0x040004C9 RID: 1225
	[Token(Token = "0x40004C9")]
	[FieldOffset(Offset = "0x0")]
	public static AtmospherePost instance;

	// Token: 0x040004CA RID: 1226
	[Token(Token = "0x40004CA")]
	[FieldOffset(Offset = "0x20")]
	public Material material;

	// Token: 0x040004CB RID: 1227
	[Token(Token = "0x40004CB")]
	[FieldOffset(Offset = "0x28")]
	public Shader shader;

	// Token: 0x040004CC RID: 1228
	[Token(Token = "0x40004CC")]
	[FieldOffset(Offset = "0x30")]
	private bool goodToGo;

	// Token: 0x040004CD RID: 1229
	[Token(Token = "0x40004CD")]
	[FieldOffset(Offset = "0x8")]
	public static Vector3 L;

	// Token: 0x040004CE RID: 1230
	[Token(Token = "0x40004CE")]
	[FieldOffset(Offset = "0x34")]
	private float mieDirectionalG;

	// Token: 0x040004CF RID: 1231
	[Token(Token = "0x40004CF")]
	[FieldOffset(Offset = "0x38")]
	private float rayleighCoefficient;

	// Token: 0x040004D0 RID: 1232
	[Token(Token = "0x40004D0")]
	[FieldOffset(Offset = "0x3C")]
	private float mieCoefficient;

	// Token: 0x040004D1 RID: 1233
	[Token(Token = "0x40004D1")]
	[FieldOffset(Offset = "0x40")]
	private float Molecules;

	// Token: 0x040004D2 RID: 1234
	[Token(Token = "0x40004D2")]
	[FieldOffset(Offset = "0x44")]
	private float turbidity;

	// Token: 0x040004D3 RID: 1235
	[Token(Token = "0x40004D3")]
	[FieldOffset(Offset = "0x48")]
	private float Exposure;

	// Token: 0x040004D4 RID: 1236
	[Token(Token = "0x40004D4")]
	[FieldOffset(Offset = "0x4C")]
	private float sunE;
}
