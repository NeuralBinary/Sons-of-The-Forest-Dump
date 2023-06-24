using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200016E RID: 366
[Token(Token = "0x200016E")]
public class AdminAuthed : Event
{
	// Token: 0x060010BB RID: 4283 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010BB")]
	[Address(RVA = "0x87F940", Offset = "0x87DF40", VA = "0x18087F940")]
	public AdminAuthed()
	{
	}

	// Token: 0x170005DB RID: 1499
	// (get) Token: 0x060010BC RID: 4284 RVA: 0x00006630 File Offset: 0x00004830
	// (set) Token: 0x060010BD RID: 4285 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170005DB")]
	public bool IsAdmin
	{
		[Token(Token = "0x60010BC")]
		[Address(RVA = "0x7B4A10", Offset = "0x7B3010", VA = "0x1807B4A10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60010BD")]
		[Address(RVA = "0x7DB320", Offset = "0x7D9920", VA = "0x1807DB320")]
		set
		{
		}
	}

	// Token: 0x060010BE RID: 4286 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010BE")]
	[Address(RVA = "0x87F9A0", Offset = "0x87DFA0", VA = "0x18087F9A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x060010BF RID: 4287 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010BF")]
	[Address(RVA = "0x87FA50", Offset = "0x87E050", VA = "0x18087FA50")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AdminAuthed Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060010C0 RID: 4288 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010C0")]
	[Address(RVA = "0x87FA60", Offset = "0x87E060", VA = "0x18087FA60")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AdminAuthed Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x060010C1 RID: 4289 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010C1")]
	[Address(RVA = "0x87FC60", Offset = "0x87E260", VA = "0x18087FC60")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	private static AdminAuthed Raise(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060010C2 RID: 4290 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010C2")]
	[Address(RVA = "0x87FD80", Offset = "0x87E380", VA = "0x18087FD80")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AdminAuthed Raise(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060010C3 RID: 4291 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010C3")]
	[Address(RVA = "0x87FD90", Offset = "0x87E390", VA = "0x18087FD90")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AdminAuthed Raise(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060010C4 RID: 4292 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010C4")]
	[Address(RVA = "0x87FDA0", Offset = "0x87E3A0", VA = "0x18087FDA0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AdminAuthed Raise(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060010C5 RID: 4293 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010C5")]
	[Address(RVA = "0x87FDB0", Offset = "0x87E3B0", VA = "0x18087FDB0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AdminAuthed Raise(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060010C6 RID: 4294 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010C6")]
	[Address(RVA = "0x87FDD0", Offset = "0x87E3D0", VA = "0x18087FDD0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AdminAuthed Raise()
	{
		return null;
	}

	// Token: 0x060010C7 RID: 4295 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010C7")]
	[Address(RVA = "0x87FDF0", Offset = "0x87E3F0", VA = "0x18087FDF0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static AdminAuthed Raise(ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060010C8 RID: 4296 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010C8")]
	[Address(RVA = "0x87FA50", Offset = "0x87E050", VA = "0x18087FA50")]
	public static AdminAuthed Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x060010C9 RID: 4297 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010C9")]
	[Address(RVA = "0x87FE00", Offset = "0x87E400", VA = "0x18087FE00")]
	public static AdminAuthed Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x060010CA RID: 4298 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010CA")]
	[Address(RVA = "0x880000", Offset = "0x87E600", VA = "0x180880000")]
	private static AdminAuthed Create(byte targets, BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060010CB RID: 4299 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010CB")]
	[Address(RVA = "0x87FD80", Offset = "0x87E380", VA = "0x18087FD80")]
	public static AdminAuthed Create(GlobalTargets targets)
	{
		return null;
	}

	// Token: 0x060010CC RID: 4300 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010CC")]
	[Address(RVA = "0x87FD90", Offset = "0x87E390", VA = "0x18087FD90")]
	public static AdminAuthed Create(GlobalTargets targets, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060010CD RID: 4301 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010CD")]
	[Address(RVA = "0x87FDA0", Offset = "0x87E3A0", VA = "0x18087FDA0")]
	public static AdminAuthed Create(BoltConnection connection)
	{
		return null;
	}

	// Token: 0x060010CE RID: 4302 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010CE")]
	[Address(RVA = "0x87FDB0", Offset = "0x87E3B0", VA = "0x18087FDB0")]
	public static AdminAuthed Create(BoltConnection connection, ReliabilityModes reliability)
	{
		return null;
	}

	// Token: 0x060010CF RID: 4303 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010CF")]
	[Address(RVA = "0x87FDD0", Offset = "0x87E3D0", VA = "0x18087FDD0")]
	public static AdminAuthed Create()
	{
		return null;
	}

	// Token: 0x060010D0 RID: 4304 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010D0")]
	[Address(RVA = "0x87FDF0", Offset = "0x87E3F0", VA = "0x18087FDF0")]
	public static AdminAuthed Create(ReliabilityModes reliability)
	{
		return null;
	}
}
