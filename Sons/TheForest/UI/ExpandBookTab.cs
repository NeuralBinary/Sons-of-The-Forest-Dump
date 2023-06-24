using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x020003E4 RID: 996
	[Token(Token = "0x20003E4")]
	public class ExpandBookTab : MonoBehaviour
	{
		// Token: 0x06001AF3 RID: 6899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AF3")]
		[Address(RVA = "0x32AB3A0", Offset = "0x32A99A0", VA = "0x1832AB3A0")]
		private void Awake()
		{
		}

		// Token: 0x06001AF4 RID: 6900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AF4")]
		[Address(RVA = "0x32AB890", Offset = "0x32A9E90", VA = "0x1832AB890")]
		private void Update()
		{
		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AF5")]
		[Address(RVA = "0x32ABF30", Offset = "0x32AA530", VA = "0x1832ABF30")]
		private void OnDisable()
		{
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AF6")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ExpandBookTab()
		{
		}

		// Token: 0x04001A17 RID: 6679
		[Token(Token = "0x4001A17")]
		[FieldOffset(Offset = "0x20")]
		public GameObject _tabNum;

		// Token: 0x04001A18 RID: 6680
		[Token(Token = "0x4001A18")]
		[FieldOffset(Offset = "0x28")]
		public GameObject _tabNum2;

		// Token: 0x04001A19 RID: 6681
		[Token(Token = "0x4001A19")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 _expandedPos;

		// Token: 0x04001A1A RID: 6682
		[Token(Token = "0x4001A1A")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 _velocity;

		// Token: 0x04001A1B RID: 6683
		[Token(Token = "0x4001A1B")]
		[FieldOffset(Offset = "0x48")]
		private SelectPageNumber _holder;

		// Token: 0x04001A1C RID: 6684
		[Token(Token = "0x4001A1C")]
		[FieldOffset(Offset = "0x50")]
		private SelectPageNumber _self;

		// Token: 0x04001A1D RID: 6685
		[Token(Token = "0x4001A1D")]
		[FieldOffset(Offset = "0x58")]
		private bool _registered;
	}
}
