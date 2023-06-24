using System;
using System.Runtime.CompilerServices;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
public class CoopUnderfootSurface : EntityBehaviour<IPlayerState>
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000002 RID: 2 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x17000001")]
	public UnderfootSurfaceDetector.SurfaceType Surface
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000")]
		[CompilerGenerated]
		get
		{
			return UnderfootSurfaceDetector.SurfaceType.None;
		}
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x670F30", Offset = "0x66F530", VA = "0x180670F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000003 RID: 3 RVA: 0x00002068 File Offset: 0x00000268
	// (set) Token: 0x06000004 RID: 4 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x17000002")]
	public bool IsOnGore
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x9DD210", Offset = "0x9DB810", VA = "0x1809DD210")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x9DD220", Offset = "0x9DB820", VA = "0x1809DD220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x318E5F0", Offset = "0x318CBF0", VA = "0x18318E5F0")]
	private void OnValidate()
	{
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000006")]
	[Address(RVA = "0x318E720", Offset = "0x318CD20", VA = "0x18318E720")]
	private void Start()
	{
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000007")]
	[Address(RVA = "0x318E730", Offset = "0x318CD30", VA = "0x18318E730", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x318E8D0", Offset = "0x318CED0", VA = "0x18318E8D0")]
	private void OnUnderfootSurface()
	{
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x318E970", Offset = "0x318CF70", VA = "0x18318E970")]
	private void OnUnderfootGore()
	{
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x318EA10", Offset = "0x318D010", VA = "0x18318EA10")]
	private void Update()
	{
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x318ECE0", Offset = "0x318D2E0", VA = "0x18318ECE0")]
	public CoopUnderfootSurface()
	{
	}

	// Token: 0x04000003 RID: 3
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private UnderfootSurfaceDetector _surfaceDetector;
}
