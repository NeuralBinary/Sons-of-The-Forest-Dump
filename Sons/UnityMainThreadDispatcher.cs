using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000089 RID: 137
[Token(Token = "0x2000089")]
public class UnityMainThreadDispatcher : MonoBehaviour
{
	// Token: 0x170000C8 RID: 200
	// (get) Token: 0x060004E3 RID: 1251 RVA: 0x000039D8 File Offset: 0x00001BD8
	[Token(Token = "0x170000C8")]
	public static bool Exists
	{
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x3372460", Offset = "0x3370A60", VA = "0x183372460")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060004E4 RID: 1252 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004E4")]
	[Address(RVA = "0x3372550", Offset = "0x3370B50", VA = "0x183372550")]
	private void Awake()
	{
	}

	// Token: 0x060004E5 RID: 1253 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004E5")]
	[Address(RVA = "0x33727C0", Offset = "0x3370DC0", VA = "0x1833727C0")]
	private void Update()
	{
	}

	// Token: 0x060004E6 RID: 1254 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004E6")]
	[Address(RVA = "0x3372A10", Offset = "0x3371010", VA = "0x183372A10")]
	public void Enqueue(Action action)
	{
	}

	// Token: 0x060004E7 RID: 1255 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004E7")]
	[Address(RVA = "0x3372C00", Offset = "0x3371200", VA = "0x183372C00")]
	public static void VerifyInstance()
	{
	}

	// Token: 0x060004E8 RID: 1256 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004E8")]
	[Address(RVA = "0x3372C40", Offset = "0x3371240", VA = "0x183372C40")]
	public static UnityMainThreadDispatcher Instance()
	{
		return null;
	}

	// Token: 0x060004E9 RID: 1257 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004E9")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public UnityMainThreadDispatcher()
	{
	}

	// Token: 0x0400041E RID: 1054
	[Token(Token = "0x400041E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Queue<Action> actionQueue;

	// Token: 0x0400041F RID: 1055
	[Token(Token = "0x400041F")]
	[FieldOffset(Offset = "0x8")]
	private static UnityMainThreadDispatcher instance;
}
