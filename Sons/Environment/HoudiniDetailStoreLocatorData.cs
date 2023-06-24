using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Environment
{
	// Token: 0x0200064E RID: 1614
	[Token(Token = "0x200064E")]
	public class HoudiniDetailStoreLocatorData : MonoBehaviour
	{
		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x060029BA RID: 10682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000578")]
		public string WorldGroupId
		{
			[Token(Token = "0x60029BA")]
			[Address(RVA = "0x33F03D0", Offset = "0x33EE9D0", VA = "0x1833F03D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x060029BB RID: 10683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000579")]
		public string HLodId
		{
			[Token(Token = "0x60029BB")]
			[Address(RVA = "0x33F03E0", Offset = "0x33EE9E0", VA = "0x1833F03E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060029BC RID: 10684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029BC")]
		[Address(RVA = "0x33F03F0", Offset = "0x33EE9F0", VA = "0x1833F03F0")]
		public void PopulateLocatorData(ref string worldGroupId, ref string hLodId)
		{
		}

		// Token: 0x060029BD RID: 10685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029BD")]
		[Address(RVA = "0x33F04B0", Offset = "0x33EEAB0", VA = "0x1833F04B0")]
		public void SetHLodId(string hLodId)
		{
		}

		// Token: 0x060029BE RID: 10686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029BE")]
		[Address(RVA = "0x33F0520", Offset = "0x33EEB20", VA = "0x1833F0520")]
		public HoudiniDetailStoreLocatorData()
		{
		}

		// Token: 0x0400252B RID: 9515
		[Token(Token = "0x400252B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _overrideWorldGroupId;

		// Token: 0x0400252C RID: 9516
		[Token(Token = "0x400252C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _worldGroupId;

		// Token: 0x0400252D RID: 9517
		[Token(Token = "0x400252D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _overrideHLodId;

		// Token: 0x0400252E RID: 9518
		[Token(Token = "0x400252E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _hLodId;
	}
}
