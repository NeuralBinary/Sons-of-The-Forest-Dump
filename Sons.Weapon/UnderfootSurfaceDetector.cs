using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000012 RID: 18
[Token(Token = "0x2000012")]
public class UnderfootSurfaceDetector : MonoBehaviour
{
	// Token: 0x17000021 RID: 33
	// (get) Token: 0x0600005E RID: 94 RVA: 0x0000215C File Offset: 0x0000035C
	// (set) Token: 0x0600005F RID: 95 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x17000021")]
	public UnderfootSurfaceDetector.SurfaceType Surface
	{
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
		[CompilerGenerated]
		get
		{
			return UnderfootSurfaceDetector.SurfaceType.None;
		}
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x5FD590", Offset = "0x5FBB90", VA = "0x1805FD590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000022 RID: 34
	// (get) Token: 0x06000060 RID: 96 RVA: 0x00002174 File Offset: 0x00000374
	[Token(Token = "0x17000022")]
	public bool IsOnGore
	{
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x3192770", Offset = "0x3190D70", VA = "0x183192770")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000061 RID: 97 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000061")]
	[Address(RVA = "0x31927C0", Offset = "0x3190DC0", VA = "0x1831927C0")]
	private void Start()
	{
	}

	// Token: 0x06000062 RID: 98 RVA: 0x0000213E File Offset: 0x0000033E
	[Token(Token = "0x6000062")]
	[Address(RVA = "0x3192990", Offset = "0x3190F90", VA = "0x183192990")]
	public static Dictionary<string, UnderfootSurfaceDetector.SurfaceType> GetSurfaceTags()
	{
		return null;
	}

	// Token: 0x06000063 RID: 99 RVA: 0x0000218C File Offset: 0x0000038C
	[Token(Token = "0x6000063")]
	[Address(RVA = "0x31929E0", Offset = "0x3190FE0", VA = "0x1831929E0")]
	public static UnderfootSurfaceDetector.SurfaceType GetSurfaceType(Component collisionComp)
	{
		return UnderfootSurfaceDetector.SurfaceType.None;
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000064")]
	[Address(RVA = "0x3192BC0", Offset = "0x31911C0", VA = "0x183192BC0")]
	private void UpdateSurface()
	{
	}

	// Token: 0x06000065 RID: 101 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000065")]
	[Address(RVA = "0x3192C90", Offset = "0x3191290", VA = "0x183192C90")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06000066 RID: 102 RVA: 0x000021A4 File Offset: 0x000003A4
	[Token(Token = "0x6000066")]
	[Address(RVA = "0x3193020", Offset = "0x3191620", VA = "0x183193020")]
	private static bool RemoveIfPresent(List<Collider> list, Collider entry)
	{
		return default(bool);
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000067")]
	[Address(RVA = "0x3193280", Offset = "0x3191880", VA = "0x183193280")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x06000068 RID: 104 RVA: 0x000021BC File Offset: 0x000003BC
	[Token(Token = "0x6000068")]
	[Address(RVA = "0x3193310", Offset = "0x3191910", VA = "0x183193310")]
	private static bool RemoveNonIntersecting(List<Collider> list, Collider collider)
	{
		return default(bool);
	}

	// Token: 0x06000069 RID: 105 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000069")]
	[Address(RVA = "0x31935C0", Offset = "0x3191BC0", VA = "0x1831935C0")]
	private void ValidateColliders()
	{
	}

	// Token: 0x0600006A RID: 106 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600006A")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public UnderfootSurfaceDetector()
	{
	}

	// Token: 0x0400002B RID: 43
	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x28")]
	private Collider _collider;

	// Token: 0x0400002C RID: 44
	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x30")]
	private List<Collider> _overlappingColliders;

	// Token: 0x0400002D RID: 45
	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x38")]
	private List<Collider> _goreColliders;

	// Token: 0x0400002E RID: 46
	[Token(Token = "0x400002E")]
	private const string GoreTag = "UnderfootGore";

	// Token: 0x0400002F RID: 47
	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, UnderfootSurfaceDetector.SurfaceType> SurfaceTags;

	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	public enum SurfaceType
	{
		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		None,
		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		Wood,
		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		Rock,
		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		Carpet,
		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		Dirt,
		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		Metal,
		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		Plastic,
		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		PlasticBed,
		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		MetalGrate,
		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		BrokenGlass,
		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		Water,
		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		Snow,
		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		Ice,
		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		Grass,
		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		Leaves,
		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		Sand,
		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		Mud,
		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		Default,
		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		Gravel,
		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		Epoxy,
		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		Spittle
	}
}
