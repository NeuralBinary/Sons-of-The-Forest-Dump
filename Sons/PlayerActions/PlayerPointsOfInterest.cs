using System;
using Il2CppDummyDll;
using Sons.Gameplay;
using UnityEngine;

namespace Sons.PlayerActions
{
	// Token: 0x020004FF RID: 1279
	[Token(Token = "0x20004FF")]
	[AddComponentMenu("Sons/Actions/PlayerPointsOfInterest")]
	public class PlayerPointsOfInterest : MonoBehaviour
	{
		// Token: 0x0600215F RID: 8543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600215F")]
		[Address(RVA = "0x3328280", Offset = "0x3326880", VA = "0x183328280")]
		private void OnEnable()
		{
		}

		// Token: 0x06002160 RID: 8544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002160")]
		[Address(RVA = "0x3328310", Offset = "0x3326910", VA = "0x183328310")]
		private void OnDisable()
		{
		}

		// Token: 0x06002161 RID: 8545 RVA: 0x00009C00 File Offset: 0x00007E00
		[Token(Token = "0x6002161")]
		[Address(RVA = "0x33283A0", Offset = "0x33269A0", VA = "0x1833283A0")]
		public bool HasPointOfInterestBeenDiscovered(string pointOfInterestName, out PointsOfInterestData.PointOfInterestData outPointOfInterest)
		{
			return default(bool);
		}

		// Token: 0x06002162 RID: 8546 RVA: 0x00009C18 File Offset: 0x00007E18
		[Token(Token = "0x6002162")]
		[Address(RVA = "0x33284A0", Offset = "0x3326AA0", VA = "0x1833284A0")]
		private bool IsADiscoverablePointOfInterest(string pointOfInterestName, out PointsOfInterestData.PointOfInterestData outPointOfInterest)
		{
			return default(bool);
		}

		// Token: 0x06002163 RID: 8547 RVA: 0x00009C30 File Offset: 0x00007E30
		[Token(Token = "0x6002163")]
		[Address(RVA = "0x3328640", Offset = "0x3326C40", VA = "0x183328640")]
		public bool TryDiscoverPointOfInterest(string pointOfInterestName, out PointsOfInterestData.PointOfInterestData pointOfInterest)
		{
			return default(bool);
		}

		// Token: 0x06002164 RID: 8548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002164")]
		[Address(RVA = "0x3328830", Offset = "0x3326E30", VA = "0x183328830")]
		private void UpdateAllDiscoveredPointsOfInterest()
		{
		}

		// Token: 0x06002165 RID: 8549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002165")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public PlayerPointsOfInterest()
		{
		}

		// Token: 0x04001EFE RID: 7934
		[Token(Token = "0x4001EFE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private PointsOfInterestData _pointsOfInterest;

		// Token: 0x04001EFF RID: 7935
		[Token(Token = "0x4001EFF")]
		private const string PointOfInterestFound = "PointOfInterestFound";
	}
}
