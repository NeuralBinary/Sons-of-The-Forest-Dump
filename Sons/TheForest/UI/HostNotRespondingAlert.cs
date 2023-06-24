using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x020003E7 RID: 999
	[Token(Token = "0x20003E7")]
	public class HostNotRespondingAlert : MonoBehaviour
	{
		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06001AFA RID: 6906 RVA: 0x00008178 File Offset: 0x00006378
		// (set) Token: 0x06001AFB RID: 6907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003BE")]
		public static bool IsResponding
		{
			[Token(Token = "0x6001AFA")]
			[Address(RVA = "0x32AC2B0", Offset = "0x32AA8B0", VA = "0x1832AC2B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001AFB")]
			[Address(RVA = "0x32AC2F0", Offset = "0x32AA8F0", VA = "0x1832AC2F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AFC")]
		[Address(RVA = "0x32AC330", Offset = "0x32AA930", VA = "0x1832AC330")]
		private void Awake()
		{
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AFD")]
		[Address(RVA = "0x32AC700", Offset = "0x32AAD00", VA = "0x1832AC700")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AFE")]
		[Address(RVA = "0x32AC9B0", Offset = "0x32AAFB0", VA = "0x1832AC9B0")]
		private void OnHostNotResponding()
		{
		}

		// Token: 0x06001AFF RID: 6911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AFF")]
		[Address(RVA = "0x32ACA40", Offset = "0x32AB040", VA = "0x1832ACA40")]
		private void OnHostResponding()
		{
		}

		// Token: 0x06001B00 RID: 6912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B00")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public HostNotRespondingAlert()
		{
		}

		// Token: 0x04001A20 RID: 6688
		[Token(Token = "0x4001A20")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _ui;
	}
}
