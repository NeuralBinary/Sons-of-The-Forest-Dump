using System;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Construction.Traps
{
	// Token: 0x0200029D RID: 669
	[Token(Token = "0x200029D")]
	[AddComponentMenu("Sons/Construction/ReplaceByItemPickup")]
	public class ReplaceByItemPickup : MonoBehaviour
	{
		// Token: 0x0600144C RID: 5196 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600144C")]
		[Address(RVA = "0x2DEF2C0", Offset = "0x2DED8C0", VA = "0x182DEF2C0")]
		private void Start()
		{
		}

		// Token: 0x0600144D RID: 5197 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600144D")]
		[Address(RVA = "0x2DEF390", Offset = "0x2DED990", VA = "0x182DEF390")]
		private void OnCollisionEnter(Collision other)
		{
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600144E")]
		[Address(RVA = "0x2DEF7D0", Offset = "0x2DEDDD0", VA = "0x182DEF7D0")]
		public void PerformReplace()
		{
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600144F")]
		[Address(RVA = "0x2DEFD30", Offset = "0x2DEE330", VA = "0x182DEFD30")]
		public ReplaceByItemPickup()
		{
		}

		// Token: 0x040009DB RID: 2523
		[Token(Token = "0x40009DB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ReplaceByItemPickup.Target[] _targets;

		// Token: 0x040009DC RID: 2524
		[Token(Token = "0x40009DC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _autoPerformAfterDelay;

		// Token: 0x040009DD RID: 2525
		[Token(Token = "0x40009DD")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool _deleteParentStructure;

		// Token: 0x040009DE RID: 2526
		[Token(Token = "0x40009DE")]
		[FieldOffset(Offset = "0x2D")]
		[SerializeField]
		private bool _skipForClients;

		// Token: 0x040009DF RID: 2527
		[Token(Token = "0x40009DF")]
		[FieldOffset(Offset = "0x2E")]
		[SerializeField]
		private bool _enableOnCollision;

		// Token: 0x0200029E RID: 670
		[Token(Token = "0x200029E")]
		[Serializable]
		public class Target
		{
			// Token: 0x1700043D RID: 1085
			// (get) Token: 0x06001450 RID: 5200 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700043D")]
			public GameObject TargetGO
			{
				[Token(Token = "0x6001450")]
				[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700043E RID: 1086
			// (get) Token: 0x06001451 RID: 5201 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700043E")]
			public ItemData ReplaceWithItem
			{
				[Token(Token = "0x6001451")]
				[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
				get
				{
					return null;
				}
			}

			// Token: 0x06001452 RID: 5202 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6001452")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public Target()
			{
			}

			// Token: 0x040009E0 RID: 2528
			[Token(Token = "0x40009E0")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _targetGO;

			// Token: 0x040009E1 RID: 2529
			[Token(Token = "0x40009E1")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private ItemData _replaceWithItem;
		}
	}
}
