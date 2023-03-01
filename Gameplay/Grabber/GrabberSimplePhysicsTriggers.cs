using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay.Grabber
{
	// Token: 0x020006F7 RID: 1783
	[Token(Token = "0x20006F7")]
	[AddComponentMenu("Sons/TheForest/GrabberSimplePhysicsTriggers")]
	[RequireComponent(typeof(Collider))]
	public class GrabberSimplePhysicsTriggers : MonoBehaviour, IGrabberTargetProvider
	{
		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06002E0D RID: 11789 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002E0E RID: 11790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B9")]
		public Collider FocusedCollider
		{
			[Token(Token = "0x6002E0D")]
			[Address(RVA = "0x541230", Offset = "0x540230", VA = "0x180541230", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E0E")]
			[Address(RVA = "0x541270", Offset = "0x540270", VA = "0x180541270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06002E0F RID: 11791 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002E10 RID: 11792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005BA")]
		public Transform FocusedTransform
		{
			[Token(Token = "0x6002E0F")]
			[Address(RVA = "0x541210", Offset = "0x540210", VA = "0x180541210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E10")]
			[Address(RVA = "0x541250", Offset = "0x540250", VA = "0x180541250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06002E11 RID: 11793 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002E12 RID: 11794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005BB")]
		public GameObject FocusedItemGO
		{
			[Token(Token = "0x6002E11")]
			[Address(RVA = "0x541220", Offset = "0x540220", VA = "0x180541220", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E12")]
			[Address(RVA = "0x541260", Offset = "0x540260", VA = "0x180541260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06002E13 RID: 11795 RVA: 0x0000D170 File Offset: 0x0000B370
		[Token(Token = "0x170005BC")]
		public bool IsFocused
		{
			[Token(Token = "0x6002E13")]
			[Address(RVA = "0x2E13120", Offset = "0x2E12120", VA = "0x182E13120", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06002E14 RID: 11796 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002E15 RID: 11797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005BD")]
		public static GameObject Filter
		{
			[Token(Token = "0x6002E14")]
			[Address(RVA = "0x2E13030", Offset = "0x2E12030", VA = "0x182E13030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E15")]
			[Address(RVA = "0x2E131C0", Offset = "0x2E121C0", VA = "0x182E131C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06002E16 RID: 11798 RVA: 0x0000D188 File Offset: 0x0000B388
		[Token(Token = "0x170005BE")]
		private Vector3 GrabberPos
		{
			[Token(Token = "0x6002E16")]
			[Address(RVA = "0x2E13070", Offset = "0x2E12070", VA = "0x182E13070")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06002E17 RID: 11799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E17")]
		[Address(RVA = "0x2E11DC0", Offset = "0x2E10DC0", VA = "0x182E11DC0")]
		private void Awake()
		{
		}

		// Token: 0x06002E18 RID: 11800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E18")]
		[Address(RVA = "0x2E125C0", Offset = "0x2E115C0", VA = "0x182E125C0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002E19 RID: 11801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E19")]
		[Address(RVA = "0x2E12310", Offset = "0x2E11310", VA = "0x182E12310")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06002E1A RID: 11802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E1A")]
		[Address(RVA = "0x2E12CE0", Offset = "0x2E11CE0", VA = "0x182E12CE0")]
		private void Update()
		{
		}

		// Token: 0x06002E1B RID: 11803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E1B")]
		[Address(RVA = "0x2E12670", Offset = "0x2E11670", VA = "0x182E12670")]
		private void OnTriggerStay(Collider other)
		{
		}

		// Token: 0x06002E1C RID: 11804 RVA: 0x0000D1A0 File Offset: 0x0000B3A0
		[Token(Token = "0x6002E1C")]
		[Address(RVA = "0x2E12470", Offset = "0x2E11470", VA = "0x182E12470")]
		private bool IsValid(Collider other)
		{
			return default(bool);
		}

		// Token: 0x06002E1D RID: 11805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E1D")]
		[Address(RVA = "0x2E121B0", Offset = "0x2E111B0", VA = "0x182E121B0")]
		public void EnterMessage()
		{
		}

		// Token: 0x06002E1E RID: 11806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E1E")]
		[Address(RVA = "0x2E12C30", Offset = "0x2E11C30", VA = "0x182E12C30")]
		public void StayMessage()
		{
		}

		// Token: 0x06002E1F RID: 11807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E1F")]
		[Address(RVA = "0x2E12260", Offset = "0x2E11260", VA = "0x182E12260")]
		public void ExitMessage()
		{
		}

		// Token: 0x06002E20 RID: 11808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E20")]
		[Address(RVA = "0x2E12160", Offset = "0x2E11160", VA = "0x182E12160")]
		private void ClearFocus()
		{
		}

		// Token: 0x06002E21 RID: 11809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E21")]
		[Address(RVA = "0x2E12900", Offset = "0x2E11900", VA = "0x182E12900")]
		public void RefreshCollider()
		{
		}

		// Token: 0x06002E22 RID: 11810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E22")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		private void DrawTriggerDebug(Transform newTransform)
		{
		}

		// Token: 0x06002E23 RID: 11811 RVA: 0x0000D1B8 File Offset: 0x0000B3B8
		[Token(Token = "0x6002E23")]
		[Address(RVA = "0x2E12420", Offset = "0x2E11420", VA = "0x182E12420")]
		private bool IsHigherPriority(Transform newTransform, Transform currentTransform)
		{
			return default(bool);
		}

		// Token: 0x06002E24 RID: 11812 RVA: 0x0000D1D0 File Offset: 0x0000B3D0
		[Token(Token = "0x6002E24")]
		[Address(RVA = "0x2E11FD0", Offset = "0x2E10FD0", VA = "0x182E11FD0")]
		private float CalculateTargetScore(Transform targetTr)
		{
			return default(float);
		}

		// Token: 0x06002E25 RID: 11813 RVA: 0x0000D1E8 File Offset: 0x0000B3E8
		[Token(Token = "0x6002E25")]
		[Address(RVA = "0x2E12B80", Offset = "0x2E11B80", VA = "0x182E12B80", Slot = "4")]
		private bool TryGetTargetScore(out float targetScore)
		{
			return default(bool);
		}

		// Token: 0x06002E26 RID: 11814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E26")]
		[Address(RVA = "0x2E129A0", Offset = "0x2E119A0", VA = "0x182E129A0", Slot = "5")]
		private void SelectTarget()
		{
		}

		// Token: 0x06002E27 RID: 11815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E27")]
		[Address(RVA = "0x2E12950", Offset = "0x2E11950", VA = "0x182E12950", Slot = "6")]
		private void DeselectTarget()
		{
		}

		// Token: 0x06002E28 RID: 11816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E28")]
		[Address(RVA = "0x2E12320", Offset = "0x2E11320", VA = "0x182E12320")]
		private void FocusOnCollider(Collider c)
		{
		}

		// Token: 0x06002E29 RID: 11817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E29")]
		[Address(RVA = "0x2E13020", Offset = "0x2E12020", VA = "0x182E13020")]
		public GrabberSimplePhysicsTriggers()
		{
		}

		// Token: 0x040028EF RID: 10479
		[Token(Token = "0x40028EF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _distanceCheckTransform;

		// Token: 0x040028F4 RID: 10484
		[Token(Token = "0x40028F4")]
		[FieldOffset(Offset = "0x40")]
		private bool _wasFocused;

		// Token: 0x040028F5 RID: 10485
		[Token(Token = "0x40028F5")]
		[FieldOffset(Offset = "0x44")]
		private int _pickupLayer;

		// Token: 0x040028F6 RID: 10486
		[Token(Token = "0x40028F6")]
		[FieldOffset(Offset = "0x48")]
		private bool _busyLock;

		// Token: 0x040028F7 RID: 10487
		[Token(Token = "0x40028F7")]
		[FieldOffset(Offset = "0x49")]
		private bool _colliderWasRefreshed;

		// Token: 0x040028F8 RID: 10488
		[Token(Token = "0x40028F8")]
		[FieldOffset(Offset = "0x4A")]
		private bool _readyToResetColliderWasRefreshed;

		// Token: 0x040028F9 RID: 10489
		[Token(Token = "0x40028F9")]
		[FieldOffset(Offset = "0x50")]
		private Collider _collider;

		// Token: 0x040028FA RID: 10490
		[Token(Token = "0x40028FA")]
		[FieldOffset(Offset = "0x58")]
		private bool _physicsUpdate;

		// Token: 0x040028FB RID: 10491
		[Token(Token = "0x40028FB")]
		[FieldOffset(Offset = "0x59")]
		private bool _triggerStayUpdate;

		// Token: 0x040028FC RID: 10492
		[Token(Token = "0x40028FC")]
		[FieldOffset(Offset = "0x60")]
		private Collider _highestScoreCollider;
	}
}
