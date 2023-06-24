using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200019A RID: 410
[Token(Token = "0x200019A")]
public class WorldHeightmap : MonoBehaviour
{
	// Token: 0x1700017C RID: 380
	// (get) Token: 0x06000C3A RID: 3130 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700017C")]
	public static WorldHeightmap Instance
	{
		[Token(Token = "0x6000C3A")]
		[Address(RVA = "0x36E2A40", Offset = "0x36E1040", VA = "0x1836E2A40")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000C3B RID: 3131 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C3B")]
	[Address(RVA = "0x36E2B60", Offset = "0x36E1160", VA = "0x1836E2B60")]
	private static void AddWorldHeightmap()
	{
	}

	// Token: 0x06000C3C RID: 3132 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C3C")]
	[Address(RVA = "0x36E2D80", Offset = "0x36E1380", VA = "0x1836E2D80")]
	public static void Initialize()
	{
	}

	// Token: 0x1700017D RID: 381
	// (get) Token: 0x06000C3D RID: 3133 RVA: 0x00004FB0 File Offset: 0x000031B0
	[Token(Token = "0x1700017D")]
	public Bounds Bounds
	{
		[Token(Token = "0x6000C3D")]
		[Address(RVA = "0x36E2E60", Offset = "0x36E1460", VA = "0x1836E2E60")]
		get
		{
			return default(Bounds);
		}
	}

	// Token: 0x06000C3E RID: 3134 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C3E")]
	[Address(RVA = "0x36E2EF0", Offset = "0x36E14F0", VA = "0x1836E2EF0")]
	private void Awake()
	{
	}

	// Token: 0x06000C3F RID: 3135 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C3F")]
	[Address(RVA = "0x36E3050", Offset = "0x36E1650", VA = "0x1836E3050")]
	private void Start()
	{
	}

	// Token: 0x06000C40 RID: 3136 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C40")]
	[Address(RVA = "0x36E3170", Offset = "0x36E1770", VA = "0x1836E3170")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000C41 RID: 3137 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C41")]
	[Address(RVA = "0x36E32D0", Offset = "0x36E18D0", VA = "0x1836E32D0")]
	private void InitHeightmap()
	{
	}

	// Token: 0x06000C42 RID: 3138 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C42")]
	[Address(RVA = "0x36E37F0", Offset = "0x36E1DF0", VA = "0x1836E37F0")]
	private void OnApplicationFocus(bool hasFocus)
	{
	}

	// Token: 0x06000C43 RID: 3139 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C43")]
	[Address(RVA = "0x36E3940", Offset = "0x36E1F40", VA = "0x1836E3940")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000C44 RID: 3140 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C44")]
	[Address(RVA = "0x36E3A70", Offset = "0x36E2070", VA = "0x1836E3A70")]
	public void UpdateHeightmap()
	{
	}

	// Token: 0x06000C45 RID: 3141 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C45")]
	[Address(RVA = "0x36E42A0", Offset = "0x36E28A0", VA = "0x1836E42A0")]
	public WorldHeightmap()
	{
	}

	// Token: 0x04000AD2 RID: 2770
	[Token(Token = "0x4000AD2")]
	[FieldOffset(Offset = "0x0")]
	private static WorldHeightmap instance;

	// Token: 0x04000AD3 RID: 2771
	[Token(Token = "0x4000AD3")]
	[FieldOffset(Offset = "0x20")]
	public RenderTexture Heightmap;

	// Token: 0x04000AD4 RID: 2772
	[Token(Token = "0x4000AD4")]
	[FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public Camera HeightmapCamera;

	// Token: 0x04000AD5 RID: 2773
	[Token(Token = "0x4000AD5")]
	[FieldOffset(Offset = "0x30")]
	public Shader DepthShader;

	// Token: 0x04000AD6 RID: 2774
	[Token(Token = "0x4000AD6")]
	[FieldOffset(Offset = "0x38")]
	public LayerMask OccluderMask;

	// Token: 0x04000AD7 RID: 2775
	[Token(Token = "0x4000AD7")]
	[FieldOffset(Offset = "0x3C")]
	public int Resolution;

	// Token: 0x04000AD8 RID: 2776
	[Token(Token = "0x4000AD8")]
	[FieldOffset(Offset = "0x40")]
	public float PhysicalSize;

	// Token: 0x04000AD9 RID: 2777
	[Token(Token = "0x4000AD9")]
	[FieldOffset(Offset = "0x44")]
	[Range(0f, 25f)]
	public float HeightBias;
}
