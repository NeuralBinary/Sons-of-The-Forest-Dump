using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000009 RID: 9
[Token(Token = "0x2000009")]
[AddComponentMenu("")]
public class ConstraintBaseClass : ConstraintFrameworkBaseClass
{
	// Token: 0x17000011 RID: 17
	// (get) Token: 0x0600004A RID: 74 RVA: 0x000020CA File Offset: 0x000002CA
	// (set) Token: 0x0600004B RID: 75 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000011")]
	public Transform target
	{
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x28B16B0", Offset = "0x28AFCB0", VA = "0x1828B16B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
		set
		{
		}
	}

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x0600004C RID: 76 RVA: 0x000020CA File Offset: 0x000002CA
	[Token(Token = "0x17000012")]
	protected virtual Transform internalTarget
	{
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x28B16D0", Offset = "0x28AFCD0", VA = "0x1828B16D0", Slot = "10")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x0600004D RID: 77 RVA: 0x000021D8 File Offset: 0x000003D8
	// (set) Token: 0x0600004E RID: 78 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000013")]
	public Vector3 position
	{
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x28B1B50", Offset = "0x28B0150", VA = "0x1828B1B50")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x28B1C00", Offset = "0x28B0200", VA = "0x1828B1C00")]
		set
		{
		}
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x0600004F RID: 79 RVA: 0x000021F0 File Offset: 0x000003F0
	// (set) Token: 0x06000050 RID: 80 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000014")]
	public Quaternion rotation
	{
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x28B1C90", Offset = "0x28B0290", VA = "0x1828B1C90")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x28B1D30", Offset = "0x28B0330", VA = "0x1828B1D30")]
		set
		{
		}
	}

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x06000051 RID: 81 RVA: 0x00002208 File Offset: 0x00000408
	// (set) Token: 0x06000052 RID: 82 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000015")]
	public Vector3 scale
	{
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x28B1DC0", Offset = "0x28B03C0", VA = "0x1828B1DC0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x28B1E70", Offset = "0x28B0470", VA = "0x1828B1E70")]
		set
		{
		}
	}

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x06000053 RID: 83 RVA: 0x00002220 File Offset: 0x00000420
	// (set) Token: 0x06000054 RID: 84 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000016")]
	public UnityConstraints.NO_TARGET_OPTIONS noTargetMode
	{
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x6E6C40", Offset = "0x6E5240", VA = "0x1806E6C40")]
		get
		{
			return UnityConstraints.NO_TARGET_OPTIONS.Error;
		}
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x993AE0", Offset = "0x9920E0", VA = "0x180993AE0")]
		set
		{
		}
	}

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x06000055 RID: 85 RVA: 0x00002238 File Offset: 0x00000438
	// (set) Token: 0x06000056 RID: 86 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000017")]
	public UnityConstraints.MODE_OPTIONS mode
	{
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x5FDAB0", Offset = "0x5FC0B0", VA = "0x1805FDAB0")]
		get
		{
			return UnityConstraints.MODE_OPTIONS.Align;
		}
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x28B1F00", Offset = "0x28B0500", VA = "0x1828B1F00")]
		set
		{
		}
	}

	// Token: 0x06000057 RID: 87 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000057")]
	[Address(RVA = "0x28B1F20", Offset = "0x28B0520", VA = "0x1828B1F20")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000058 RID: 88 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000058")]
	[Address(RVA = "0x28B2140", Offset = "0x28B0740", VA = "0x1828B2140", Slot = "7")]
	protected sealed override void InitConstraint()
	{
	}

	// Token: 0x06000059 RID: 89 RVA: 0x000020CA File Offset: 0x000002CA
	[Token(Token = "0x6000059")]
	[Address(RVA = "0x28B21B0", Offset = "0x28B07B0", VA = "0x1828B21B0", Slot = "8")]
	protected sealed override IEnumerator Constrain()
	{
		return null;
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005A")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "11")]
	protected virtual void NoTargetDefault()
	{
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005B")]
	[Address(RVA = "0x26E1890", Offset = "0x26DFE90", VA = "0x1826E1890")]
	private void OnOnce()
	{
	}

	// Token: 0x0600005C RID: 92 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005C")]
	[Address(RVA = "0x28B2240", Offset = "0x28B0840", VA = "0x1828B2240")]
	public ConstraintBaseClass()
	{
	}

	// Token: 0x0400001C RID: 28
	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x28")]
	public Transform _target;

	// Token: 0x0400001D RID: 29
	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x30")]
	protected Transform _internalTarget;

	// Token: 0x0400001E RID: 30
	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x38")]
	public UnityConstraints.NO_TARGET_OPTIONS _noTargetMode;

	// Token: 0x0400001F RID: 31
	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x3C")]
	public UnityConstraints.MODE_OPTIONS _mode;

	// Token: 0x04000020 RID: 32
	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x40")]
	protected Vector3 pos;

	// Token: 0x04000021 RID: 33
	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x4C")]
	protected Vector3 scl;

	// Token: 0x04000022 RID: 34
	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x58")]
	protected Quaternion rot;
}
