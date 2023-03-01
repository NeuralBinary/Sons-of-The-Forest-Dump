using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200019B RID: 411
[Token(Token = "0x200019B")]
public class WorldHeightmap : MonoBehaviour
{
	// Token: 0x17000173 RID: 371
	// (get) Token: 0x06000BE0 RID: 3040 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000173")]
	public static WorldHeightmap Instance
	{
		[Token(Token = "0x6000BE0")]
		[Address(RVA = "0x2F747E0", Offset = "0x2F737E0", VA = "0x182F747E0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000BE1 RID: 3041 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BE1")]
	[Address(RVA = "0x2F73B20", Offset = "0x2F72B20", VA = "0x182F73B20")]
	private static void AddWorldHeightmap()
	{
	}

	// Token: 0x06000BE2 RID: 3042 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BE2")]
	[Address(RVA = "0x2F73F40", Offset = "0x2F72F40", VA = "0x182F73F40")]
	public static void Initialize()
	{
	}

	// Token: 0x17000174 RID: 372
	// (get) Token: 0x06000BE3 RID: 3043 RVA: 0x00004D88 File Offset: 0x00002F88
	[Token(Token = "0x17000174")]
	public Bounds Bounds
	{
		[Token(Token = "0x6000BE3")]
		[Address(RVA = "0x2F74750", Offset = "0x2F73750", VA = "0x182F74750")]
		get
		{
			return default(Bounds);
		}
	}

	// Token: 0x06000BE4 RID: 3044 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BE4")]
	[Address(RVA = "0x2F73C50", Offset = "0x2F72C50", VA = "0x182F73C50")]
	private void Awake()
	{
	}

	// Token: 0x06000BE5 RID: 3045 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BE5")]
	[Address(RVA = "0x2F74230", Offset = "0x2F73230", VA = "0x182F74230")]
	private void Start()
	{
	}

	// Token: 0x06000BE6 RID: 3046 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BE6")]
	[Address(RVA = "0x2F73FC0", Offset = "0x2F72FC0", VA = "0x182F73FC0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000BE7 RID: 3047 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BE7")]
	[Address(RVA = "0x2F73D20", Offset = "0x2F72D20", VA = "0x182F73D20")]
	private void InitHeightmap()
	{
	}

	// Token: 0x06000BE8 RID: 3048 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BE8")]
	[Address(RVA = "0x2F740E0", Offset = "0x2F730E0", VA = "0x182F740E0")]
	private void OnApplicationFocus(bool hasFocus)
	{
	}

	// Token: 0x06000BE9 RID: 3049 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BE9")]
	[Address(RVA = "0x2F74190", Offset = "0x2F73190", VA = "0x182F74190")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000BEA RID: 3050 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BEA")]
	[Address(RVA = "0x2F742E0", Offset = "0x2F732E0", VA = "0x182F742E0")]
	public void UpdateHeightmap()
	{
	}

	// Token: 0x06000BEB RID: 3051 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BEB")]
	[Address(RVA = "0x2F74710", Offset = "0x2F73710", VA = "0x182F74710")]
	public WorldHeightmap()
	{
	}

	// Token: 0x04000AA7 RID: 2727
	[Token(Token = "0x4000AA7")]
	[FieldOffset(Offset = "0x0")]
	private static WorldHeightmap instance;

	// Token: 0x04000AA8 RID: 2728
	[Token(Token = "0x4000AA8")]
	[FieldOffset(Offset = "0x20")]
	public RenderTexture Heightmap;

	// Token: 0x04000AA9 RID: 2729
	[Token(Token = "0x4000AA9")]
	[FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public Camera HeightmapCamera;

	// Token: 0x04000AAA RID: 2730
	[Token(Token = "0x4000AAA")]
	[FieldOffset(Offset = "0x30")]
	public Shader DepthShader;

	// Token: 0x04000AAB RID: 2731
	[Token(Token = "0x4000AAB")]
	[FieldOffset(Offset = "0x38")]
	public LayerMask OccluderMask;

	// Token: 0x04000AAC RID: 2732
	[Token(Token = "0x4000AAC")]
	[FieldOffset(Offset = "0x3C")]
	public int Resolution;

	// Token: 0x04000AAD RID: 2733
	[Token(Token = "0x4000AAD")]
	[FieldOffset(Offset = "0x40")]
	public float PhysicalSize;

	// Token: 0x04000AAE RID: 2734
	[Token(Token = "0x4000AAE")]
	[FieldOffset(Offset = "0x44")]
	[Range(0f, 25f)]
	public float HeightBias;
}
