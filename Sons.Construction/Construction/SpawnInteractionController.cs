using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020000FD RID: 253
	[Token(Token = "0x20000FD")]
	public class SpawnInteractionController : MonoBehaviour
	{
		// Token: 0x1700023A RID: 570
		// (get) Token: 0x0600070F RID: 1807 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000710 RID: 1808 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700023A")]
		public BoltEntity Instance
		{
			[Token(Token = "0x600070F")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000710")]
			[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000711")]
		[Address(RVA = "0x2E389C0", Offset = "0x2E36FC0", VA = "0x182E389C0")]
		private void Awake()
		{
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000712")]
		[Address(RVA = "0x2E38E90", Offset = "0x2E37490", VA = "0x182E38E90")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000713")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SpawnInteractionController()
		{
		}

		// Token: 0x04000520 RID: 1312
		[Token(Token = "0x4000520")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BoltEntity _interactionPrefab;
	}
}
