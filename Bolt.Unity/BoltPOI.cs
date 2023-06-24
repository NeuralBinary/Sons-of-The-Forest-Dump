using System;
using System.Collections.Generic;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000003 RID: 3
[Token(Token = "0x2000003")]
[ExecuteInEditMode]
public class BoltPOI : EntityBehaviour
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000004 RID: 4 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000001")]
	public static Mesh Mesh
	{
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x7A2D00", Offset = "0x7A1300", VA = "0x1807A2D00")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000005 RID: 5 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000002")]
	public static Material MaterialPOI
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x7A2F50", Offset = "0x7A1550", VA = "0x1807A2F50")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000006 RID: 6 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000003")]
	public static Material MaterialAOIDetect
	{
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x7A30F0", Offset = "0x7A16F0", VA = "0x1807A30F0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000007 RID: 7 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000004")]
	public static Material MaterialAOIRelease
	{
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x7A3290", Offset = "0x7A1890", VA = "0x1807A3290")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x7A3430", Offset = "0x7A1A30", VA = "0x1807A3430")]
	private static Material CreateMaterial(Color c)
	{
		return null;
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x7A35E0", Offset = "0x7A1BE0", VA = "0x1807A35E0")]
	private void Update()
	{
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x7A39D0", Offset = "0x7A1FD0", VA = "0x1807A39D0")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x7A3A50", Offset = "0x7A2050", VA = "0x1807A3A50")]
	private void BoltSceneObject()
	{
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000C")]
	[Address(RVA = "0x7A3B40", Offset = "0x7A2140", VA = "0x1807A3B40", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000D")]
	[Address(RVA = "0x7A3C00", Offset = "0x7A2200", VA = "0x1807A3C00", Slot = "17")]
	public override void Detached()
	{
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x7A3C80", Offset = "0x7A2280", VA = "0x1807A3C80")]
	public static void UpdateScope(BoltAOI aoi, BoltConnection connection)
	{
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002058 File Offset: 0x00000258
	[Token(Token = "0x600000F")]
	[Address(RVA = "0x7A4080", Offset = "0x7A2680", VA = "0x1807A4080")]
	private static bool OverlapSphere(Vector3 a, Vector3 b, float aRadius, float bRadius)
	{
		return default(bool);
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x7A40F0", Offset = "0x7A26F0", VA = "0x1807A40F0")]
	public BoltPOI()
	{
	}

	// Token: 0x04000004 RID: 4
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x0")]
	private static Mesh mesh;

	// Token: 0x04000005 RID: 5
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x8")]
	private static Material poiMat;

	// Token: 0x04000006 RID: 6
	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x10")]
	private static Material aoiDetectMat;

	// Token: 0x04000007 RID: 7
	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x18")]
	private static Material aoiReleaseMat;

	// Token: 0x04000008 RID: 8
	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x20")]
	private static List<BoltPOI> availablePOIs;

	// Token: 0x04000009 RID: 9
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public float radius;
}
