using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Sons.Wearable.Race
{
	// Token: 0x020005C0 RID: 1472
	[Token(Token = "0x20005C0")]
	[CreateAssetMenu(fileName = "NewPlayerRace", menuName = "Sons/Data/PlayerRace/PlayerRace", order = 0)]
	public class PlayerRace : ScriptableObject
	{
		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x0600266C RID: 9836 RVA: 0x0000B640 File Offset: 0x00009840
		[Token(Token = "0x1700051C")]
		public PlayerRace.Race GetRace
		{
			[Token(Token = "0x600266C")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
			get
			{
				return PlayerRace.Race.White;
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x0600266D RID: 9837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700051D")]
		public AssetReference HeadAsset
		{
			[Token(Token = "0x600266D")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x0600266E RID: 9838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700051E")]
		public AssetReference ArmsAsset
		{
			[Token(Token = "0x600266E")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600266F RID: 9839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600266F")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public PlayerRace()
		{
		}

		// Token: 0x040022B2 RID: 8882
		[Token(Token = "0x40022B2")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int RaceCount;

		// Token: 0x040022B3 RID: 8883
		[Token(Token = "0x40022B3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private PlayerRace.Race _race;

		// Token: 0x040022B4 RID: 8884
		[Token(Token = "0x40022B4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AssetReference _headAsset;

		// Token: 0x040022B5 RID: 8885
		[Token(Token = "0x40022B5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AssetReference _armsAsset;

		// Token: 0x020005C1 RID: 1473
		[Token(Token = "0x20005C1")]
		public enum Race
		{
			// Token: 0x040022B7 RID: 8887
			[Token(Token = "0x40022B7")]
			White,
			// Token: 0x040022B8 RID: 8888
			[Token(Token = "0x40022B8")]
			Black,
			// Token: 0x040022B9 RID: 8889
			[Token(Token = "0x40022B9")]
			Latin,
			// Token: 0x040022BA RID: 8890
			[Token(Token = "0x40022BA")]
			Asian,
			// Token: 0x040022BB RID: 8891
			[Token(Token = "0x40022BB")]
			BlackA,
			// Token: 0x040022BC RID: 8892
			[Token(Token = "0x40022BC")]
			WhiteA,
			// Token: 0x040022BD RID: 8893
			[Token(Token = "0x40022BD")]
			BlackB,
			// Token: 0x040022BE RID: 8894
			[Token(Token = "0x40022BE")]
			LatinA
		}
	}
}
