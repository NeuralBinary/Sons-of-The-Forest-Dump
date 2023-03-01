using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x020003F5 RID: 1013
	[Token(Token = "0x20003F5")]
	public class HostNotRespondingAlert : MonoBehaviour
	{
		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06001ABC RID: 6844 RVA: 0x00007EF0 File Offset: 0x000060F0
		// (set) Token: 0x06001ABD RID: 6845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003B4")]
		public static bool IsResponding
		{
			[Token(Token = "0x6001ABC")]
			[Address(RVA = "0x2CE1E40", Offset = "0x2CE0E40", VA = "0x182CE1E40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001ABD")]
			[Address(RVA = "0x2CE1E80", Offset = "0x2CE0E80", VA = "0x182CE1E80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001ABE RID: 6846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ABE")]
		[Address(RVA = "0x2CE18A0", Offset = "0x2CE08A0", VA = "0x182CE18A0")]
		private void Awake()
		{
		}

		// Token: 0x06001ABF RID: 6847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ABF")]
		[Address(RVA = "0x2CE1B70", Offset = "0x2CE0B70", VA = "0x182CE1B70")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001AC0 RID: 6848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AC0")]
		[Address(RVA = "0x2CE1D80", Offset = "0x2CE0D80", VA = "0x182CE1D80")]
		private void OnHostNotResponding()
		{
		}

		// Token: 0x06001AC1 RID: 6849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AC1")]
		[Address(RVA = "0x2CE1DE0", Offset = "0x2CE0DE0", VA = "0x182CE1DE0")]
		private void OnHostResponding()
		{
		}

		// Token: 0x06001AC2 RID: 6850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AC2")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public HostNotRespondingAlert()
		{
		}

		// Token: 0x040019FC RID: 6652
		[Token(Token = "0x40019FC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _ui;
	}
}
