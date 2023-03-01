using System;
using System.Net;
using System.Text;
using AOT;
using Il2CppDummyDll;
using Sons.Multiplayer;
using Steamworks;
using UnityEngine;

// Token: 0x020000F2 RID: 242
[Token(Token = "0x20000F2")]
public class CoopDedicatedServerStarter : MonoBehaviour
{
	// Token: 0x06000700 RID: 1792 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000700")]
	[Address(RVA = "0x2E74BE0", Offset = "0x2E73BE0", VA = "0x182E74BE0")]
	private void Awake()
	{
	}

	// Token: 0x06000701 RID: 1793 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000701")]
	[Address(RVA = "0x2E755E0", Offset = "0x2E745E0", VA = "0x182E755E0")]
	private void Start()
	{
	}

	// Token: 0x06000702 RID: 1794 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000702")]
	[Address(RVA = "0x2E755C0", Offset = "0x2E745C0", VA = "0x182E755C0")]
	private static void ShutDown()
	{
	}

	// Token: 0x06000703 RID: 1795 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000703")]
	[Address(RVA = "0x2E759D0", Offset = "0x2E749D0", VA = "0x182E759D0")]
	[MonoPInvokeCallback(typeof(SteamAPIWarningMessageHook_t))]
	private static void SteamAPIDebugTextHook(int nSeverity, StringBuilder pchDebugText)
	{
	}

	// Token: 0x170000E9 RID: 233
	// (get) Token: 0x06000704 RID: 1796 RVA: 0x00003F60 File Offset: 0x00002160
	[Token(Token = "0x170000E9")]
	private bool isMachineNetAvailable
	{
		[Token(Token = "0x6000704")]
		[Address(RVA = "0x2E75D40", Offset = "0x2E74D40", VA = "0x182E75D40")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000705 RID: 1797 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000705")]
	[Address(RVA = "0x2E75A50", Offset = "0x2E74A50", VA = "0x182E75A50")]
	private string getMachineIp()
	{
		return null;
	}

	// Token: 0x06000706 RID: 1798 RVA: 0x00003F78 File Offset: 0x00002178
	[Token(Token = "0x6000706")]
	[Address(RVA = "0x2E750D0", Offset = "0x2E740D0", VA = "0x182E750D0")]
	private bool CheckPorts(IPAddress ip, int[] ports)
	{
		return default(bool);
	}

	// Token: 0x06000707 RID: 1799 RVA: 0x00003F90 File Offset: 0x00002190
	[Token(Token = "0x6000707")]
	[Address(RVA = "0x2E74D30", Offset = "0x2E73D30", VA = "0x182E74D30")]
	private bool CheckNetworkConfiguration()
	{
		return default(bool);
	}

	// Token: 0x06000708 RID: 1800 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000708")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public CoopDedicatedServerStarter()
	{
	}

	// Token: 0x040005C7 RID: 1479
	[Token(Token = "0x40005C7")]
	[FieldOffset(Offset = "0x20")]
	public LoadAsync loadAsync;

	// Token: 0x040005C8 RID: 1480
	[Token(Token = "0x40005C8")]
	[FieldOffset(Offset = "0x0")]
	private static ServerStarterSteam serverStarter;
}
