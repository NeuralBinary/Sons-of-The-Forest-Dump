using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay.Grabber
{
	// Token: 0x02000845 RID: 2117
	[Token(Token = "0x2000845")]
	[AddComponentMenu("Sons/TheForest/GrabberSimplePhysicsTriggers")]
	[RequireComponent(typeof(Collider))]
	public class GrabberSimplePhysicsTriggers : MonoBehaviour, IGrabberTargetProvider
	{
		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06003C01 RID: 15361 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003C02 RID: 15362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007BC")]
		public Collider FocusedCollider
		{
			[Token(Token = "0x6003C01")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003C02")]
			[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06003C03 RID: 15363 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003C04 RID: 15364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007BD")]
		public Transform FocusedTransform
		{
			[Token(Token = "0x6003C03")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003C04")]
			[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06003C05 RID: 15365 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003C06 RID: 15366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007BE")]
		public GameObject FocusedItemGO
		{
			[Token(Token = "0x6003C05")]
			[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003C06")]
			[Address(RVA = "0x5B2F00", Offset = "0x5B1500", VA = "0x1805B2F00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06003C07 RID: 15367 RVA: 0x00012408 File Offset: 0x00010608
		[Token(Token = "0x170007BF")]
		public bool IsFocused
		{
			[Token(Token = "0x6003C07")]
			[Address(RVA = "0x35984A0", Offset = "0x3596AA0", VA = "0x1835984A0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06003C08 RID: 15368 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003C09 RID: 15369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007C0")]
		public static GameObject Filter
		{
			[Token(Token = "0x6003C08")]
			[Address(RVA = "0x3598610", Offset = "0x3596C10", VA = "0x183598610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003C09")]
			[Address(RVA = "0x3598650", Offset = "0x3596C50", VA = "0x183598650")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06003C0A RID: 15370 RVA: 0x00012420 File Offset: 0x00010620
		[Token(Token = "0x170007C1")]
		private Vector3 GrabberPos
		{
			[Token(Token = "0x6003C0A")]
			[Address(RVA = "0x35986E0", Offset = "0x3596CE0", VA = "0x1835986E0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06003C0B RID: 15371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C0B")]
		[Address(RVA = "0x35988B0", Offset = "0x3596EB0", VA = "0x1835988B0")]
		private void Awake()
		{
		}

		// Token: 0x06003C0C RID: 15372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C0C")]
		[Address(RVA = "0x3598B00", Offset = "0x3597100", VA = "0x183598B00")]
		private void OnDisable()
		{
		}

		// Token: 0x06003C0D RID: 15373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C0D")]
		[Address(RVA = "0x3598B10", Offset = "0x3597110", VA = "0x183598B10")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003C0E RID: 15374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C0E")]
		[Address(RVA = "0x3598B60", Offset = "0x3597160", VA = "0x183598B60")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06003C0F RID: 15375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C0F")]
		[Address(RVA = "0x3598B70", Offset = "0x3597170", VA = "0x183598B70")]
		private void Update()
		{
		}

		// Token: 0x06003C10 RID: 15376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C10")]
		[Address(RVA = "0x3598D40", Offset = "0x3597340", VA = "0x183598D40")]
		private void OnTriggerStay(Collider other)
		{
		}

		// Token: 0x06003C11 RID: 15377 RVA: 0x00012438 File Offset: 0x00010638
		[Token(Token = "0x6003C11")]
		[Address(RVA = "0x3599050", Offset = "0x3597650", VA = "0x183599050")]
		private bool IsValid(Collider other)
		{
			return default(bool);
		}

		// Token: 0x06003C12 RID: 15378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C12")]
		[Address(RVA = "0x3599300", Offset = "0x3597900", VA = "0x183599300")]
		public void EnterMessage()
		{
		}

		// Token: 0x06003C13 RID: 15379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C13")]
		[Address(RVA = "0x3599560", Offset = "0x3597B60", VA = "0x183599560")]
		public void StayMessage()
		{
		}

		// Token: 0x06003C14 RID: 15380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C14")]
		[Address(RVA = "0x35997C0", Offset = "0x3597DC0", VA = "0x1835997C0")]
		public void ExitMessage()
		{
		}

		// Token: 0x06003C15 RID: 15381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C15")]
		[Address(RVA = "0x3599A20", Offset = "0x3598020", VA = "0x183599A20")]
		private void ClearFocus()
		{
		}

		// Token: 0x06003C16 RID: 15382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C16")]
		[Address(RVA = "0x3599B20", Offset = "0x3598120", VA = "0x183599B20")]
		public void RefreshCollider()
		{
		}

		// Token: 0x06003C17 RID: 15383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C17")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void DrawTriggerDebug(Transform newTransform)
		{
		}

		// Token: 0x06003C18 RID: 15384 RVA: 0x00012450 File Offset: 0x00010650
		[Token(Token = "0x6003C18")]
		[Address(RVA = "0x3599BE0", Offset = "0x35981E0", VA = "0x183599BE0")]
		private bool IsHigherPriority(Transform newTransform, Transform currentTransform)
		{
			return default(bool);
		}

		// Token: 0x06003C19 RID: 15385 RVA: 0x00012468 File Offset: 0x00010668
		[Token(Token = "0x6003C19")]
		[Address(RVA = "0x3599C30", Offset = "0x3598230", VA = "0x183599C30")]
		private float CalculateTargetScore(Transform targetTr)
		{
			return 0f;
		}

		// Token: 0x06003C1A RID: 15386 RVA: 0x00012480 File Offset: 0x00010680
		[Token(Token = "0x6003C1A")]
		[Address(RVA = "0x3599E40", Offset = "0x3598440", VA = "0x183599E40", Slot = "4")]
		private bool TryGetTargetScore(out float targetScore)
		{
			return default(bool);
		}

		// Token: 0x06003C1B RID: 15387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C1B")]
		[Address(RVA = "0x3599F90", Offset = "0x3598590", VA = "0x183599F90", Slot = "5")]
		private void SelectTarget()
		{
		}

		// Token: 0x06003C1C RID: 15388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C1C")]
		[Address(RVA = "0x359A0D0", Offset = "0x35986D0", VA = "0x18359A0D0", Slot = "6")]
		private void DeselectTarget()
		{
		}

		// Token: 0x06003C1D RID: 15389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C1D")]
		[Address(RVA = "0x359A0F0", Offset = "0x35986F0", VA = "0x18359A0F0")]
		private void FocusOnCollider(Collider c)
		{
		}

		// Token: 0x06003C1E RID: 15390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C1E")]
		[Address(RVA = "0x359A2D0", Offset = "0x35988D0", VA = "0x18359A2D0")]
		public GrabberSimplePhysicsTriggers()
		{
		}

		// Token: 0x040032D4 RID: 13012
		[Token(Token = "0x40032D4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _distanceCheckTransform;

		// Token: 0x040032D9 RID: 13017
		[Token(Token = "0x40032D9")]
		[FieldOffset(Offset = "0x40")]
		private bool _wasFocused;

		// Token: 0x040032DA RID: 13018
		[Token(Token = "0x40032DA")]
		[FieldOffset(Offset = "0x44")]
		private int _pickupLayer;

		// Token: 0x040032DB RID: 13019
		[Token(Token = "0x40032DB")]
		[FieldOffset(Offset = "0x48")]
		private bool _busyLock;

		// Token: 0x040032DC RID: 13020
		[Token(Token = "0x40032DC")]
		[FieldOffset(Offset = "0x49")]
		private bool _colliderWasRefreshed;

		// Token: 0x040032DD RID: 13021
		[Token(Token = "0x40032DD")]
		[FieldOffset(Offset = "0x4A")]
		private bool _readyToResetColliderWasRefreshed;

		// Token: 0x040032DE RID: 13022
		[Token(Token = "0x40032DE")]
		[FieldOffset(Offset = "0x50")]
		private Collider _collider;

		// Token: 0x040032DF RID: 13023
		[Token(Token = "0x40032DF")]
		[FieldOffset(Offset = "0x58")]
		private bool _physicsUpdate;

		// Token: 0x040032E0 RID: 13024
		[Token(Token = "0x40032E0")]
		[FieldOffset(Offset = "0x59")]
		private bool _triggerStayUpdate;

		// Token: 0x040032E1 RID: 13025
		[Token(Token = "0x40032E1")]
		[FieldOffset(Offset = "0x60")]
		private Collider _highestScoreCollider;
	}
}
