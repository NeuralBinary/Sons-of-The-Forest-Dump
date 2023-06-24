using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Multiplayer.Dedicated
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public class DedicatedServerBoostrap : MonoBehaviour
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2455740", Offset = "0x2453D40", VA = "0x182455740")]
		private void Start()
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x24557A0", Offset = "0x2453DA0", VA = "0x1824557A0")]
		private void OnGUI()
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2455840", Offset = "0x2453E40", VA = "0x182455840")]
		public void CreateDedicated()
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2455C10", Offset = "0x2454210", VA = "0x182455C10")]
		private static void SetupGameSaveAndMode()
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2455F60", Offset = "0x2454560", VA = "0x182455F60")]
		private static void SetupGameSettings()
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x2456190", Offset = "0x2454790", VA = "0x182456190")]
		private static void SetupCustomGameModeSettings()
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000009")]
		private static void EvalSafe<T>(string key, Action<T> ifSuccess, Func<T> eval)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000A")]
		private static void EvalSafe<T>(string key, Action<string, T> ifSuccess, Func<T> eval)
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2456EB0", Offset = "0x24554B0", VA = "0x182456EB0")]
		private void SuccessCallback()
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2456F50", Offset = "0x2455550", VA = "0x182456F50")]
		private void FailureCallback(string obj)
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2456FC0", Offset = "0x24555C0", VA = "0x182456FC0")]
		public void StartDedicated()
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public DedicatedServerBoostrap()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x20")]
		public SonsServerMono _sonsServer;
	}
}
