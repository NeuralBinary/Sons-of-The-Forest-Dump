using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000025 RID: 37
[Token(Token = "0x2000025")]
internal class WeaponFire : NetworkState, IWeaponFire, IState, IDisposable
{
	// Token: 0x060000C7 RID: 199 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x7BC890", Offset = "0x7BAE90", VA = "0x1807BC890")]
	public WeaponFire()
	{
	}

	// Token: 0x17000051 RID: 81
	// (get) Token: 0x060000C8 RID: 200 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060000C9 RID: 201 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000051")]
	public BoltEntity TargetPlayer
	{
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0", Slot = "31")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x7BC980", Offset = "0x7BAF80", VA = "0x1807BC980", Slot = "32")]
		set
		{
		}
	}

	// Token: 0x17000052 RID: 82
	// (get) Token: 0x060000CA RID: 202 RVA: 0x00002538 File Offset: 0x00000738
	// (set) Token: 0x060000CB RID: 203 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000052")]
	public Vector3 Position
	{
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x7BCBD0", Offset = "0x7BB1D0", VA = "0x1807BCBD0", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x7BCC50", Offset = "0x7BB250", VA = "0x1807BCC50", Slot = "34")]
		set
		{
		}
	}

	// Token: 0x17000053 RID: 83
	// (get) Token: 0x060000CC RID: 204 RVA: 0x00002550 File Offset: 0x00000750
	// (set) Token: 0x060000CD RID: 205 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000053")]
	public Quaternion Rotation
	{
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x7BCDA0", Offset = "0x7BB3A0", VA = "0x1807BCDA0", Slot = "35")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x7BCE10", Offset = "0x7BB410", VA = "0x1807BCE10", Slot = "36")]
		set
		{
		}
	}
}
