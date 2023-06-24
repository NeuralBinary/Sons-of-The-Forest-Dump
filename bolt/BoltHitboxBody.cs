using System;
using System.Runtime.CompilerServices;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200001B RID: 27
[Token(Token = "0x200001B")]
[Documentation]
public class BoltHitboxBody : MonoBehaviour, IBoltListNode
{
	// Token: 0x17000024 RID: 36
	// (get) Token: 0x060000D8 RID: 216 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060000D9 RID: 217 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000024")]
	private object prev
	{
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000025 RID: 37
	// (get) Token: 0x060000DA RID: 218 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060000DB RID: 219 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000025")]
	private object next
	{
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x5B2F00", Offset = "0x5B1500", VA = "0x1805B2F00", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000026 RID: 38
	// (get) Token: 0x060000DC RID: 220 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060000DD RID: 221 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000026")]
	private object list
	{
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x5B2560", Offset = "0x5B0B60", VA = "0x1805B2560", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x060000DE RID: 222 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060000DF RID: 223 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000027")]
	public BoltHitbox proximity
	{
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
		set
		{
		}
	}

	// Token: 0x17000028 RID: 40
	// (get) Token: 0x060000E0 RID: 224 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060000E1 RID: 225 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000028")]
	public BoltHitbox[] hitboxes
	{
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
		set
		{
		}
	}

	// Token: 0x060000E2 RID: 226 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x783AF0", Offset = "0x7820F0", VA = "0x180783AF0")]
	private void OnEnable()
	{
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x783BA0", Offset = "0x7821A0", VA = "0x180783BA0")]
	private void OnDisable()
	{
	}

	// Token: 0x060000E4 RID: 228 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x783C50", Offset = "0x782250", VA = "0x180783C50")]
	public BoltHitboxBody()
	{
	}

	// Token: 0x04000061 RID: 97
	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	internal BoltHitbox _proximity;

	// Token: 0x04000062 RID: 98
	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	internal BoltHitbox[] _hitboxes;
}
