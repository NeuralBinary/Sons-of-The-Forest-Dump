using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200005F RID: 95
	[Token(Token = "0x200005F")]
	[CreateAssetMenu(menuName = "Sons/Construction/Element Profile Database", fileName = "ElementProfileDatabase")]
	public class ElementProfileDatabase : ScriptableObject
	{
		// Token: 0x0600025E RID: 606 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x2D76350", Offset = "0x2D74950", VA = "0x182D76350")]
		private void OnEnable()
		{
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x2D76440", Offset = "0x2D74A40", VA = "0x182D76440")]
		public static ElementProfile GetProfile(uint profileId)
		{
			return null;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000302C File Offset: 0x0000122C
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x2D76680", Offset = "0x2D74C80", VA = "0x182D76680")]
		public static ushort RegisterProfile(ElementProfile profile)
		{
			return 0;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00003044 File Offset: 0x00001244
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x2D767C0", Offset = "0x2D74DC0", VA = "0x182D767C0")]
		private ushort RegisterProfileInternal(ElementProfile profile)
		{
			return 0;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000305C File Offset: 0x0000125C
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x2D76BD0", Offset = "0x2D751D0", VA = "0x182D76BD0")]
		public static bool TryGetOrLocateInstance(out ElementProfileDatabase instance)
		{
			return default(bool);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x2D76FB0", Offset = "0x2D755B0", VA = "0x182D76FB0")]
		private static void ProfileDelayedRegistration(ElementProfile profile)
		{
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public ElementProfileDatabase()
		{
		}

		// Token: 0x04000270 RID: 624
		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<ElementProfile> _profiles;

		// Token: 0x04000271 RID: 625
		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0x0")]
		private static bool _triedLookingUpAsset;

		// Token: 0x04000272 RID: 626
		[Token(Token = "0x4000272")]
		[FieldOffset(Offset = "0x8")]
		private static ElementProfileDatabase _instance;

		// Token: 0x04000273 RID: 627
		[Token(Token = "0x4000273")]
		[FieldOffset(Offset = "0x10")]
		private static List<ElementProfile> _profilesPendingRegistration;
	}
}
