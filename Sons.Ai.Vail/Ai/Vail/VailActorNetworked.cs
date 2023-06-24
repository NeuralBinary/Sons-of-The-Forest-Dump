using System;
using Bolt;
using Il2CppDummyDll;
using Sons.Ragdoll;
using Sons.Weapon;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x0200008F RID: 143
	[Token(Token = "0x200008F")]
	public class VailActorNetworked : EntityEventListener<IMecanimVailActorState>, IPriorityCalculator
	{
		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x000047A0 File Offset: 0x000029A0
		[Token(Token = "0x17000066")]
		public int PlayerSentimentLevel
		{
			[Token(Token = "0x60005A9")]
			[Address(RVA = "0xAFF270", Offset = "0xAFD870", VA = "0x180AFF270")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x2B29B80", Offset = "0x2B28180", VA = "0x182B29B80")]
		private void OnValidate()
		{
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x2B2A110", Offset = "0x2B28710", VA = "0x182B2A110", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x2B2AE70", Offset = "0x2B29470", VA = "0x182B2AE70")]
		private void SendActivateEvent(bool active)
		{
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x2B2AF50", Offset = "0x2B29550", VA = "0x182B2AF50")]
		public void OnActivateClient(ActivateVailActor evt)
		{
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x2B2B0E0", Offset = "0x2B296E0", VA = "0x182B2B0E0")]
		public void Deactivate()
		{
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x2B2B240", Offset = "0x2B29840", VA = "0x182B2B240")]
		public void Activate()
		{
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x000047B8 File Offset: 0x000029B8
		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x2B2B480", Offset = "0x2B29A80", VA = "0x182B2B480")]
		public bool IsFrozen()
		{
			return default(bool);
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void OnFrozen()
		{
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void OnUnfrozen()
		{
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x000047D0 File Offset: 0x000029D0
		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x2B2B590", Offset = "0x2B29B90", VA = "0x182B2B590")]
		private bool IsValidNetworkEntity()
		{
			return default(bool);
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x2B2B7F0", Offset = "0x2B29DF0", VA = "0x182B2B7F0")]
		public void TickClient()
		{
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x2B2B880", Offset = "0x2B29E80", VA = "0x182B2B880")]
		public void TickServer()
		{
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x2B2B910", Offset = "0x2B29F10", VA = "0x182B2B910")]
		private void OwnerUpdateStateVars()
		{
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x2B2C640", Offset = "0x2B2AC40", VA = "0x182B2C640")]
		private void ClientApplyStateVars()
		{
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x2B2CE70", Offset = "0x2B2B470", VA = "0x182B2CE70")]
		private void HandleRagdollChanged()
		{
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x2B2D540", Offset = "0x2B2BB40", VA = "0x182B2D540")]
		private void OnRagdoll()
		{
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x2B2D550", Offset = "0x2B2BB50", VA = "0x182B2D550")]
		private void OnApplyBlood()
		{
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x2B2D6A0", Offset = "0x2B2BCA0", VA = "0x182B2D6A0")]
		private void OnSetInCave()
		{
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x2B2D7F0", Offset = "0x2B2BDF0", VA = "0x182B2D7F0")]
		private void OnApplyDismember()
		{
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x2B2D940", Offset = "0x2B2BF40", VA = "0x182B2D940")]
		private void OnVailState()
		{
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x2B2DA40", Offset = "0x2B2C040", VA = "0x182B2DA40")]
		private void OnExpression()
		{
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x2B2DC40", Offset = "0x2B2C240", VA = "0x182B2DC40")]
		private void OnEquippedChanged()
		{
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x2B2DDA0", Offset = "0x2B2C3A0", VA = "0x182B2DDA0")]
		private void OnHelicopterHeld()
		{
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x2B2DE50", Offset = "0x2B2C450", VA = "0x182B2DE50")]
		private void OnGpsLocatorId()
		{
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x2B2DFD0", Offset = "0x2B2C5D0", VA = "0x182B2DFD0")]
		private void OnItemCarryTypeCount()
		{
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x28FFB30", Offset = "0x28FE130", VA = "0x1828FFB30")]
		private void OnVariationChanged()
		{
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x2B2E090", Offset = "0x2B2C690", VA = "0x182B2E090")]
		private void OnOutfit()
		{
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x2B2E140", Offset = "0x2B2C740", VA = "0x182B2E140")]
		private void OnBurning()
		{
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x2B2E250", Offset = "0x2B2C850", VA = "0x182B2E250")]
		public void SetBurningBodyState()
		{
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x2B2E310", Offset = "0x2B2C910", VA = "0x182B2E310")]
		private void OnBodyBurning()
		{
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x2B2E3F0", Offset = "0x2B2C9F0", VA = "0x182B2E3F0")]
		private void OnSkinned()
		{
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x2B2E4A0", Offset = "0x2B2CAA0", VA = "0x182B2E4A0")]
		private void OnSetScale()
		{
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x000047E8 File Offset: 0x000029E8
		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x2B2E550", Offset = "0x2B2CB50", VA = "0x182B2E550")]
		private bool CheckActor()
		{
			return default(bool);
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x2B2E6C0", Offset = "0x2B2CCC0", VA = "0x182B2E6C0")]
		public void SendSkinnedEventToServer()
		{
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060005CC RID: 1484 RVA: 0x00004800 File Offset: 0x00002A00
		[Token(Token = "0x17000067")]
		private bool Always
		{
			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "324")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00004818 File Offset: 0x00002A18
		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x2B2E7E0", Offset = "0x2B2CDE0", VA = "0x182B2E7E0", Slot = "323")]
		private float CalculateEventPriority(BoltConnection connection, Bolt.Event evnt)
		{
			return 0f;
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00004830 File Offset: 0x00002A30
		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x2B2E810", Offset = "0x2B2CE10", VA = "0x182B2E810", Slot = "322")]
		private float CalculateStatePriority(BoltConnection connection, int skipped)
		{
			return 0f;
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00004848 File Offset: 0x00002A48
		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x2B2E830", Offset = "0x2B2CE30", VA = "0x182B2E830")]
		private float CalculatePriority(BoltConnection connection, float multiplier, int skipped)
		{
			return 0f;
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x2B2EB60", Offset = "0x2B2D160", VA = "0x182B2EB60")]
		public VailActorNetworked()
		{
		}

		// Token: 0x04000499 RID: 1177
		[Token(Token = "0x4000499")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CharacterBloodRevealProxy _bloodRevealProxy;

		// Token: 0x0400049A RID: 1178
		[Token(Token = "0x400049A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private VailActor _vailActor;

		// Token: 0x0400049B RID: 1179
		[Token(Token = "0x400049B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x0400049C RID: 1180
		[Token(Token = "0x400049C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RagdollManager _ragdollManager;

		// Token: 0x0400049D RID: 1181
		[Token(Token = "0x400049D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private DismembermentController _dismemberController;

		// Token: 0x0400049E RID: 1182
		[Token(Token = "0x400049E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _multiplayerPriorityMult;

		// Token: 0x0400049F RID: 1183
		[Token(Token = "0x400049F")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float _fullPriorityDistance;

		// Token: 0x040004A0 RID: 1184
		[Token(Token = "0x40004A0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool _freezeOnDisable;

		// Token: 0x040004A1 RID: 1185
		[Token(Token = "0x40004A1")]
		[FieldOffset(Offset = "0x5C")]
		private VailActor.AnimParam _directionParam;

		// Token: 0x040004A2 RID: 1186
		[Token(Token = "0x40004A2")]
		[FieldOffset(Offset = "0x64")]
		private VailActor.AnimParam _directionXParam;

		// Token: 0x040004A3 RID: 1187
		[Token(Token = "0x40004A3")]
		[FieldOffset(Offset = "0x6C")]
		private VailActor.AnimParam _directionZParam;

		// Token: 0x040004A4 RID: 1188
		[Token(Token = "0x40004A4")]
		[FieldOffset(Offset = "0x74")]
		private bool _variationChanged;

		// Token: 0x040004A5 RID: 1189
		[Token(Token = "0x40004A5")]
		[FieldOffset(Offset = "0x75")]
		private bool _ragdollChanged;

		// Token: 0x040004A6 RID: 1190
		[Token(Token = "0x40004A6")]
		[FieldOffset(Offset = "0x78")]
		private int _playerSentimentLevel;
	}
}
