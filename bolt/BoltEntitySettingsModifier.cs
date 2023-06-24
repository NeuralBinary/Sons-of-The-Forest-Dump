using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000034 RID: 52
[Token(Token = "0x2000034")]
[Documentation]
public class BoltEntitySettingsModifier : IDisposable
{
	// Token: 0x060001E4 RID: 484 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
	internal BoltEntitySettingsModifier(BoltEntity entity)
	{
	}

	// Token: 0x17000067 RID: 103
	// (get) Token: 0x060001E5 RID: 485 RVA: 0x00002940 File Offset: 0x00000B40
	// (set) Token: 0x060001E6 RID: 486 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000067")]
	public PrefabId prefabId
	{
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x79B930", Offset = "0x799F30", VA = "0x18079B930")]
		get
		{
			return default(PrefabId);
		}
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x79B950", Offset = "0x799F50", VA = "0x18079B950")]
		set
		{
		}
	}

	// Token: 0x17000068 RID: 104
	// (get) Token: 0x060001E7 RID: 487 RVA: 0x00002958 File Offset: 0x00000B58
	// (set) Token: 0x060001E8 RID: 488 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000068")]
	public UniqueId sceneId
	{
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x79B990", Offset = "0x799F90", VA = "0x18079B990")]
		get
		{
			return default(UniqueId);
		}
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x79B9D0", Offset = "0x799FD0", VA = "0x18079B9D0")]
		set
		{
		}
	}

	// Token: 0x17000069 RID: 105
	// (get) Token: 0x060001E9 RID: 489 RVA: 0x00002970 File Offset: 0x00000B70
	// (set) Token: 0x060001EA RID: 490 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000069")]
	public UniqueId serializerId
	{
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x79BAA0", Offset = "0x79A0A0", VA = "0x18079BAA0")]
		get
		{
			return default(UniqueId);
		}
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x79BAE0", Offset = "0x79A0E0", VA = "0x18079BAE0")]
		set
		{
		}
	}

	// Token: 0x1700006A RID: 106
	// (get) Token: 0x060001EB RID: 491 RVA: 0x00002988 File Offset: 0x00000B88
	// (set) Token: 0x060001EC RID: 492 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700006A")]
	public int updateRate
	{
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x79BBB0", Offset = "0x79A1B0", VA = "0x18079BBB0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x79BBD0", Offset = "0x79A1D0", VA = "0x18079BBD0")]
		set
		{
		}
	}

	// Token: 0x1700006B RID: 107
	// (get) Token: 0x060001ED RID: 493 RVA: 0x000029A0 File Offset: 0x00000BA0
	// (set) Token: 0x060001EE RID: 494 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700006B")]
	public int autoFreezeProxyFrames
	{
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x79BC10", Offset = "0x79A210", VA = "0x18079BC10")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x79BC30", Offset = "0x79A230", VA = "0x18079BC30")]
		set
		{
		}
	}

	// Token: 0x1700006C RID: 108
	// (get) Token: 0x060001EF RID: 495 RVA: 0x000029B8 File Offset: 0x00000BB8
	// (set) Token: 0x060001F0 RID: 496 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700006C")]
	public bool clientPredicted
	{
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x79BC70", Offset = "0x79A270", VA = "0x18079BC70")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x79BC90", Offset = "0x79A290", VA = "0x18079BC90")]
		set
		{
		}
	}

	// Token: 0x1700006D RID: 109
	// (get) Token: 0x060001F1 RID: 497 RVA: 0x000029D0 File Offset: 0x00000BD0
	// (set) Token: 0x060001F2 RID: 498 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700006D")]
	public bool allowInstantiateOnClient
	{
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x79BCD0", Offset = "0x79A2D0", VA = "0x18079BCD0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x79BCF0", Offset = "0x79A2F0", VA = "0x18079BCF0")]
		set
		{
		}
	}

	// Token: 0x1700006E RID: 110
	// (get) Token: 0x060001F3 RID: 499 RVA: 0x000029E8 File Offset: 0x00000BE8
	// (set) Token: 0x060001F4 RID: 500 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700006E")]
	public bool persistThroughSceneLoads
	{
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x79BD30", Offset = "0x79A330", VA = "0x18079BD30")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x79BD50", Offset = "0x79A350", VA = "0x18079BD50")]
		set
		{
		}
	}

	// Token: 0x1700006F RID: 111
	// (get) Token: 0x060001F5 RID: 501 RVA: 0x00002A00 File Offset: 0x00000C00
	// (set) Token: 0x060001F6 RID: 502 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700006F")]
	public bool sceneObjectDestroyOnDetach
	{
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x79BD90", Offset = "0x79A390", VA = "0x18079BD90")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x79BDB0", Offset = "0x79A3B0", VA = "0x18079BDB0")]
		set
		{
		}
	}

	// Token: 0x17000070 RID: 112
	// (get) Token: 0x060001F7 RID: 503 RVA: 0x00002A18 File Offset: 0x00000C18
	// (set) Token: 0x060001F8 RID: 504 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000070")]
	public bool sceneObjectAutoAttach
	{
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x79BDF0", Offset = "0x79A3F0", VA = "0x18079BDF0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x79BE10", Offset = "0x79A410", VA = "0x18079BE10")]
		set
		{
		}
	}

	// Token: 0x17000071 RID: 113
	// (get) Token: 0x060001F9 RID: 505 RVA: 0x00002A30 File Offset: 0x00000C30
	// (set) Token: 0x060001FA RID: 506 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000071")]
	public bool alwaysProxy
	{
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x79BE50", Offset = "0x79A450", VA = "0x18079BE50")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x79BE70", Offset = "0x79A470", VA = "0x18079BE70")]
		set
		{
		}
	}

	// Token: 0x17000072 RID: 114
	// (get) Token: 0x060001FB RID: 507 RVA: 0x00002A48 File Offset: 0x00000C48
	// (set) Token: 0x060001FC RID: 508 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000072")]
	public bool detachOnDisable
	{
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x79BEB0", Offset = "0x79A4B0", VA = "0x18079BEB0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x79BED0", Offset = "0x79A4D0", VA = "0x18079BED0")]
		set
		{
		}
	}

	// Token: 0x060001FD RID: 509 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	private void Dispose()
	{
	}

	// Token: 0x04000106 RID: 262
	[Token(Token = "0x4000106")]
	[FieldOffset(Offset = "0x10")]
	private BoltEntity _entity;
}
