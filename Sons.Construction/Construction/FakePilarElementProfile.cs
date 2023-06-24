using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020001CF RID: 463
	[Token(Token = "0x20001CF")]
	[CreateAssetMenu(menuName = "Sons/Construction/FakePilarElementProfile")]
	public class FakePilarElementProfile : ElementProfile
	{
		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000DB0 RID: 3504 RVA: 0x00008714 File Offset: 0x00006914
		[Token(Token = "0x1700033E")]
		public bool IsWaterBorne
		{
			[Token(Token = "0x6000DB0")]
			[Address(RVA = "0x2ED7630", Offset = "0x2ED5C30", VA = "0x182ED7630")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DB1")]
		[Address(RVA = "0x2ED7640", Offset = "0x2ED5C40", VA = "0x182ED7640")]
		public FakePilarElementProfile()
		{
		}

		// Token: 0x040007AE RID: 1966
		[Token(Token = "0x40007AE")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private bool _isWaterborne;
	}
}
