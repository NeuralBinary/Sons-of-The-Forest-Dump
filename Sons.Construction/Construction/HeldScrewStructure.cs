using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Crafting.Structures;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000126 RID: 294
	[Token(Token = "0x2000126")]
	[AddComponentMenu("Sons/Actions/HeldScrewStructure")]
	public class HeldScrewStructure : MonoBehaviour
	{
		// Token: 0x17000255 RID: 597
		// (get) Token: 0x0600080B RID: 2059 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x0600080C RID: 2060 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000255")]
		public HeldScrewStructureProxy Proxy
		{
			[Token(Token = "0x600080B")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600080C")]
			[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x0600080D RID: 2061 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x0600080E RID: 2062 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000256")]
		public StructureRecipe HeldStructureRecipe
		{
			[Token(Token = "0x600080D")]
			[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600080E")]
			[Address(RVA = "0x5B2F00", Offset = "0x5B1500", VA = "0x1805B2F00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000810 RID: 2064 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000257")]
		public GameObject HeldStructure
		{
			[Token(Token = "0x600080F")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000810")]
			[Address(RVA = "0x5B2560", Offset = "0x5B0B60", VA = "0x1805B2560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000811 RID: 2065 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000258")]
		public Transform HeldStructureBone
		{
			[Token(Token = "0x6000811")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000812")]
		[Address(RVA = "0x2E519C0", Offset = "0x2E4FFC0", VA = "0x182E519C0")]
		private IEnumerator Start()
		{
			return null;
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000813")]
		[Address(RVA = "0x2E51A50", Offset = "0x2E50050", VA = "0x182E51A50")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000814")]
		[Address(RVA = "0x2E51C30", Offset = "0x2E50230", VA = "0x182E51C30")]
		public void InitHeld(StructureRecipe recipe)
		{
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000815")]
		[Address(RVA = "0x2E521E0", Offset = "0x2E507E0", VA = "0x182E521E0")]
		public void CleanUpHeld()
		{
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000816")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public HeldScrewStructure()
		{
		}

		// Token: 0x040005FA RID: 1530
		[Token(Token = "0x40005FA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _heldStructureBone;

		// Token: 0x040005FB RID: 1531
		[Token(Token = "0x40005FB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private HeldScrewStructureProxy _proxyPrefab;
	}
}
