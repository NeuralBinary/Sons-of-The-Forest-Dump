using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000009 RID: 9
[Token(Token = "0x2000009")]
public class BoltInit : MonoBehaviour
{
	// Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000028")]
	[Address(RVA = "0x7A5940", Offset = "0x7A3F40", VA = "0x1807A5940")]
	private void Awake()
	{
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000029")]
	[Address(RVA = "0x7A5970", Offset = "0x7A3F70", VA = "0x1807A5970")]
	private void OnGUI()
	{
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002A")]
	[Address(RVA = "0x7A5FE0", Offset = "0x7A45E0", VA = "0x1807A5FE0")]
	private void State_EnterServerIp()
	{
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002B")]
	[Address(RVA = "0x7A6140", Offset = "0x7A4740", VA = "0x1807A6140")]
	private void State_SelectMode()
	{
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002C")]
	[Address(RVA = "0x7A61C0", Offset = "0x7A47C0", VA = "0x1807A61C0")]
	private void State_SelectMap()
	{
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002D")]
	[Address(RVA = "0x7A6490", Offset = "0x7A4A90", VA = "0x1807A6490")]
	private void State_StartServer()
	{
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002E")]
	[Address(RVA = "0x7A6580", Offset = "0x7A4B80", VA = "0x1807A6580")]
	private void State_StartClient()
	{
	}

	// Token: 0x0600002F RID: 47 RVA: 0x000020D0 File Offset: 0x000002D0
	[Token(Token = "0x600002F")]
	[Address(RVA = "0x7A6690", Offset = "0x7A4C90", VA = "0x1807A6690")]
	private bool ExpandButton(string text)
	{
		return default(bool);
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000030")]
	[Address(RVA = "0x7A6720", Offset = "0x7A4D20", VA = "0x1807A6720")]
	public BoltInit()
	{
	}

	// Token: 0x04000021 RID: 33
	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x20")]
	private BoltInit.State state;

	// Token: 0x04000022 RID: 34
	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x28")]
	private string map;

	// Token: 0x04000023 RID: 35
	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x30")]
	private string serverAddress;

	// Token: 0x04000024 RID: 36
	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x38")]
	private int serverPort;

	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	private enum State
	{
		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		SelectMode,
		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		SelectMap,
		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		EnterServerIp,
		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		StartServer,
		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		StartClient,
		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		Started
	}
}
