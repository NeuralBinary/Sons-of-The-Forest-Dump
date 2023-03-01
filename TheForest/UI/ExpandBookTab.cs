using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x020003F2 RID: 1010
	[Token(Token = "0x20003F2")]
	public class ExpandBookTab : MonoBehaviour
	{
		// Token: 0x06001AB5 RID: 6837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AB5")]
		[Address(RVA = "0x2CE0B20", Offset = "0x2CDFB20", VA = "0x182CE0B20")]
		private void Awake()
		{
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AB6")]
		[Address(RVA = "0x2CE0D50", Offset = "0x2CDFD50", VA = "0x182CE0D50")]
		private void Update()
		{
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AB7")]
		[Address(RVA = "0x2CE0CD0", Offset = "0x2CDFCD0", VA = "0x182CE0CD0")]
		private void OnDisable()
		{
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AB8")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public ExpandBookTab()
		{
		}

		// Token: 0x040019F3 RID: 6643
		[Token(Token = "0x40019F3")]
		[FieldOffset(Offset = "0x20")]
		public GameObject _tabNum;

		// Token: 0x040019F4 RID: 6644
		[Token(Token = "0x40019F4")]
		[FieldOffset(Offset = "0x28")]
		public GameObject _tabNum2;

		// Token: 0x040019F5 RID: 6645
		[Token(Token = "0x40019F5")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 _expandedPos;

		// Token: 0x040019F6 RID: 6646
		[Token(Token = "0x40019F6")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 _velocity;

		// Token: 0x040019F7 RID: 6647
		[Token(Token = "0x40019F7")]
		[FieldOffset(Offset = "0x48")]
		private SelectPageNumber _holder;

		// Token: 0x040019F8 RID: 6648
		[Token(Token = "0x40019F8")]
		[FieldOffset(Offset = "0x50")]
		private SelectPageNumber _self;

		// Token: 0x040019F9 RID: 6649
		[Token(Token = "0x40019F9")]
		[FieldOffset(Offset = "0x58")]
		private bool _registered;
	}
}
