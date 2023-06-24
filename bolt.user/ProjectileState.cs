using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000AC RID: 172
[Token(Token = "0x20000AC")]
internal class ProjectileState : NetworkState, IProjectileState, IRigidbodyState, IState, IDisposable
{
	// Token: 0x060007C2 RID: 1986 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007C2")]
	[Address(RVA = "0x831460", Offset = "0x82FA60", VA = "0x180831460")]
	public ProjectileState()
	{
	}

	// Token: 0x17000447 RID: 1095
	// (get) Token: 0x060007C3 RID: 1987 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000447")]
	public NetworkTransform Transform
	{
		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x7BACE0", Offset = "0x7B92E0", VA = "0x1807BACE0", Slot = "40")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000448 RID: 1096
	// (get) Token: 0x060007C4 RID: 1988 RVA: 0x00004EA8 File Offset: 0x000030A8
	// (set) Token: 0x060007C5 RID: 1989 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000448")]
	public bool StickToTarget
	{
		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x7BB3B0", Offset = "0x7B99B0", VA = "0x1807BB3B0", Slot = "31")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x7BB410", Offset = "0x7B9A10", VA = "0x1807BB410", Slot = "32")]
		set
		{
		}
	}

	// Token: 0x17000449 RID: 1097
	// (get) Token: 0x060007C6 RID: 1990 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060007C7 RID: 1991 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000449")]
	public BoltEntity ParentEntity
	{
		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x8314C0", Offset = "0x82FAC0", VA = "0x1808314C0", Slot = "33")]
		get
		{
			return null;
		}
		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x831560", Offset = "0x82FB60", VA = "0x180831560", Slot = "34")]
		set
		{
		}
	}

	// Token: 0x1700044A RID: 1098
	// (get) Token: 0x060007C8 RID: 1992 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700044A")]
	public NetworkArray_Integer ChildIndexTraversal
	{
		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x8317C0", Offset = "0x82FDC0", VA = "0x1808317C0", Slot = "35")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700044B RID: 1099
	// (get) Token: 0x060007C9 RID: 1993 RVA: 0x00004EC0 File Offset: 0x000030C0
	// (set) Token: 0x060007CA RID: 1994 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700044B")]
	public Quaternion ParentOffsetRot
	{
		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x831880", Offset = "0x82FE80", VA = "0x180831880", Slot = "36")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x8318F0", Offset = "0x82FEF0", VA = "0x1808318F0", Slot = "37")]
		set
		{
		}
	}

	// Token: 0x1700044C RID: 1100
	// (get) Token: 0x060007CB RID: 1995 RVA: 0x00004ED8 File Offset: 0x000030D8
	// (set) Token: 0x060007CC RID: 1996 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700044C")]
	public Vector3 ParentOffsetPos
	{
		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x831A20", Offset = "0x830020", VA = "0x180831A20", Slot = "38")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x831AA0", Offset = "0x8300A0", VA = "0x180831AA0", Slot = "39")]
		set
		{
		}
	}
}
