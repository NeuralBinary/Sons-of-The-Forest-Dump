using System;
using System.Net;
using System.Text;
using AOT;
using Il2CppDummyDll;
using Sons.Multiplayer;
using Steamworks;
using UnityEngine;

// Token: 0x020000F0 RID: 240
[Token(Token = "0x20000F0")]
public class CoopDedicatedServerStarter : MonoBehaviour
{
	// Token: 0x0600074D RID: 1869 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600074D")]
	[Address(RVA = "0x3673980", Offset = "0x3671F80", VA = "0x183673980")]
	private void Awake()
	{
	}

	// Token: 0x0600074E RID: 1870 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600074E")]
	[Address(RVA = "0x3673B50", Offset = "0x3672150", VA = "0x183673B50")]
	private void Start()
	{
	}

	// Token: 0x0600074F RID: 1871 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600074F")]
	[Address(RVA = "0x36742C0", Offset = "0x36728C0", VA = "0x1836742C0")]
	private static void ShutDown()
	{
	}

	// Token: 0x06000750 RID: 1872 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000750")]
	[Address(RVA = "0x36742E0", Offset = "0x36728E0", VA = "0x1836742E0")]
	[MonoPInvokeCallback(typeof(SteamAPIWarningMessageHook_t))]
	private static void SteamAPIDebugTextHook(int nSeverity, StringBuilder pchDebugText)
	{
	}

	// Token: 0x170000F1 RID: 241
	// (get) Token: 0x06000751 RID: 1873 RVA: 0x00004170 File Offset: 0x00002370
	[Token(Token = "0x170000F1")]
	private bool isMachineNetAvailable
	{
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x3674360", Offset = "0x3672960", VA = "0x183674360")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000752 RID: 1874 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000752")]
	[Address(RVA = "0x36743A0", Offset = "0x36729A0", VA = "0x1836743A0")]
	private string getMachineIp()
	{
		return null;
	}

	// Token: 0x06000753 RID: 1875 RVA: 0x00004188 File Offset: 0x00002388
	[Token(Token = "0x6000753")]
	[Address(RVA = "0x36746D0", Offset = "0x3672CD0", VA = "0x1836746D0")]
	private bool CheckPorts(IPAddress ip, int[] ports)
	{
		return default(bool);
	}

	// Token: 0x06000754 RID: 1876 RVA: 0x000041A0 File Offset: 0x000023A0
	[Token(Token = "0x6000754")]
	[Address(RVA = "0x3674B40", Offset = "0x3673140", VA = "0x183674B40")]
	private bool CheckNetworkConfiguration()
	{
		return default(bool);
	}

	// Token: 0x06000755 RID: 1877 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000755")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public CoopDedicatedServerStarter()
	{
	}

	// Token: 0x040005E6 RID: 1510
	[Token(Token = "0x40005E6")]
	[FieldOffset(Offset = "0x20")]
	public LoadAsync loadAsync;

	// Token: 0x040005E7 RID: 1511
	[Token(Token = "0x40005E7")]
	[FieldOffset(Offset = "0x0")]
	private static ServerStarterSteam serverStarter;
}
