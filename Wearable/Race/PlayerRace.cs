using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Sons.Wearable.Race
{
	// Token: 0x020005B0 RID: 1456
	[Token(Token = "0x20005B0")]
	[CreateAssetMenu(fileName = "NewPlayerRace", menuName = "Sons/Data/PlayerRace/PlayerRace", order = 0)]
	public class PlayerRace : ScriptableObject
	{
		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x0600256D RID: 9581 RVA: 0x0000AF80 File Offset: 0x00009180
		[Token(Token = "0x17000508")]
		public PlayerRace.Race GetRace
		{
			[Token(Token = "0x600256D")]
			[Address(RVA = "0x5D9500", Offset = "0x5D8500", VA = "0x1805D9500")]
			get
			{
				return PlayerRace.Race.White;
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x0600256E RID: 9582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000509")]
		public AssetReference HeadAsset
		{
			[Token(Token = "0x600256E")]
			[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x0600256F RID: 9583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700050A")]
		public AssetReference ArmsAsset
		{
			[Token(Token = "0x600256F")]
			[Address(RVA = "0x541230", Offset = "0x540230", VA = "0x180541230")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002570 RID: 9584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002570")]
		[Address(RVA = "0x539C30", Offset = "0x538C30", VA = "0x180539C30")]
		public PlayerRace()
		{
		}

		// Token: 0x040021DE RID: 8670
		[Token(Token = "0x40021DE")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int RaceCount;

		// Token: 0x040021DF RID: 8671
		[Token(Token = "0x40021DF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private PlayerRace.Race _race;

		// Token: 0x040021E0 RID: 8672
		[Token(Token = "0x40021E0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AssetReference _headAsset;

		// Token: 0x040021E1 RID: 8673
		[Token(Token = "0x40021E1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AssetReference _armsAsset;

		// Token: 0x020005B1 RID: 1457
		[Token(Token = "0x20005B1")]
		public enum Race
		{
			// Token: 0x040021E3 RID: 8675
			[Token(Token = "0x40021E3")]
			White,
			// Token: 0x040021E4 RID: 8676
			[Token(Token = "0x40021E4")]
			Black,
			// Token: 0x040021E5 RID: 8677
			[Token(Token = "0x40021E5")]
			Latin,
			// Token: 0x040021E6 RID: 8678
			[Token(Token = "0x40021E6")]
			Asian,
			// Token: 0x040021E7 RID: 8679
			[Token(Token = "0x40021E7")]
			BlackA,
			// Token: 0x040021E8 RID: 8680
			[Token(Token = "0x40021E8")]
			WhiteA,
			// Token: 0x040021E9 RID: 8681
			[Token(Token = "0x40021E9")]
			BlackB,
			// Token: 0x040021EA RID: 8682
			[Token(Token = "0x40021EA")]
			LatinA
		}
	}
}
