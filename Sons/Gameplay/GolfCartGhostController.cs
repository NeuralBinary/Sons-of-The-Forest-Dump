using System;
using System.Collections.Generic;
using Bolt;
using Il2CppDummyDll;
using Sons.Multiplayer;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Gameplay
{
	// Token: 0x0200080E RID: 2062
	[Token(Token = "0x200080E")]
	public class GolfCartGhostController : BoltEntityListenerBehaviourWrapper<IGolfCartState>, IPriorityCalculator
	{
		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06003825 RID: 14373 RVA: 0x00010BF0 File Offset: 0x0000EDF0
		[Token(Token = "0x170006DF")]
		public bool Always
		{
			[Token(Token = "0x6003825")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "324")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06003826 RID: 14374 RVA: 0x00010C08 File Offset: 0x0000EE08
		[Token(Token = "0x170006E0")]
		public bool IsAttached
		{
			[Token(Token = "0x6003826")]
			[Address(RVA = "0x3550EC0", Offset = "0x354F4C0", VA = "0x183550EC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003827 RID: 14375 RVA: 0x00010C20 File Offset: 0x0000EE20
		[Token(Token = "0x6003827")]
		[Address(RVA = "0x35019B0", Offset = "0x34FFFB0", VA = "0x1835019B0", Slot = "323")]
		private float CalculateEventPriority(BoltConnection connection, Bolt.Event evnt)
		{
			return 0f;
		}

		// Token: 0x06003828 RID: 14376 RVA: 0x00010C38 File Offset: 0x0000EE38
		[Token(Token = "0x6003828")]
		[Address(RVA = "0x35019F0", Offset = "0x34FFFF0", VA = "0x1835019F0", Slot = "322")]
		private float CalculateStatePriority(BoltConnection connection, int skipped)
		{
			return 0f;
		}

		// Token: 0x06003829 RID: 14377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003829")]
		[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
		public List<Transform> GetLocalDynamicTransforms()
		{
			return null;
		}

		// Token: 0x0600382A RID: 14378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600382A")]
		[Address(RVA = "0x3550F00", Offset = "0x354F500", VA = "0x183550F00")]
		private void Awake()
		{
		}

		// Token: 0x0600382B RID: 14379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600382B")]
		[Address(RVA = "0x3550F50", Offset = "0x354F550", VA = "0x183550F50")]
		private void Update()
		{
		}

		// Token: 0x0600382C RID: 14380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600382C")]
		[Address(RVA = "0x3550FB0", Offset = "0x354F5B0", VA = "0x183550FB0", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x0600382D RID: 14381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600382D")]
		[Address(RVA = "0x3551430", Offset = "0x354FA30", VA = "0x183551430")]
		private void NonOwnerOnlyAttach()
		{
		}

		// Token: 0x0600382E RID: 14382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600382E")]
		[Address(RVA = "0x3551520", Offset = "0x354FB20", VA = "0x183551520")]
		private void OnSteeringWheelRotationChanged()
		{
		}

		// Token: 0x0600382F RID: 14383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600382F")]
		[Address(RVA = "0x35516F0", Offset = "0x354FCF0", VA = "0x1835516F0")]
		private void SetSteeringWheelRotation(float stateSteeringWheelRotation)
		{
		}

		// Token: 0x06003830 RID: 14384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003830")]
		[Address(RVA = "0x3551840", Offset = "0x354FE40", VA = "0x183551840")]
		public void UpdateTransforms(Transform baseTransform, List<Transform> wheelRendererTransforms)
		{
		}

		// Token: 0x06003831 RID: 14385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003831")]
		[Address(RVA = "0x3551C40", Offset = "0x3550240", VA = "0x183551C40")]
		private static void ApplyWorldPositionRotationFrom(Transform fromTransform, Transform toTransform)
		{
		}

		// Token: 0x06003832 RID: 14386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003832")]
		[Address(RVA = "0x3551D40", Offset = "0x3550340", VA = "0x183551D40")]
		private static void ApplyLocalPositionRotationFrom(Transform fromTransform, Transform toTransform)
		{
		}

		// Token: 0x06003833 RID: 14387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003833")]
		[Address(RVA = "0x3551E40", Offset = "0x3550440", VA = "0x183551E40")]
		public void SetDriverEntity(BoltEntity boltEntity)
		{
		}

		// Token: 0x06003834 RID: 14388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003834")]
		[Address(RVA = "0x3551F70", Offset = "0x3550570", VA = "0x183551F70")]
		public void UpdatePower(float currentPower)
		{
		}

		// Token: 0x06003835 RID: 14389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003835")]
		[Address(RVA = "0x3552090", Offset = "0x3550690", VA = "0x183552090")]
		public void UpdateVelocity(Vector3 velocity)
		{
		}

		// Token: 0x06003836 RID: 14390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003836")]
		[Address(RVA = "0x35521C0", Offset = "0x35507C0", VA = "0x1835521C0")]
		public static void SetDebugRenderers(bool value)
		{
		}

		// Token: 0x06003837 RID: 14391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003837")]
		[Address(RVA = "0x3550F50", Offset = "0x354F550", VA = "0x183550F50")]
		private void UpdateDebugRenderers()
		{
		}

		// Token: 0x06003838 RID: 14392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003838")]
		[Address(RVA = "0x3552200", Offset = "0x3550800", VA = "0x183552200")]
		private void ShowDebugRenderers(bool showDebugRenderers)
		{
		}

		// Token: 0x06003839 RID: 14393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003839")]
		[Address(RVA = "0x3552430", Offset = "0x3550A30", VA = "0x183552430")]
		private void ShowDebugRenderers()
		{
		}

		// Token: 0x0600383A RID: 14394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600383A")]
		[Address(RVA = "0x3552440", Offset = "0x3550A40", VA = "0x183552440")]
		private void HideDebugRenderers()
		{
		}

		// Token: 0x0600383B RID: 14395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600383B")]
		[Address(RVA = "0x3552450", Offset = "0x3550A50", VA = "0x183552450")]
		private void ShowDebugRenderer(Renderer eachItem, bool showDebugRenderers)
		{
		}

		// Token: 0x0600383C RID: 14396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600383C")]
		[Address(RVA = "0x3552550", Offset = "0x3550B50", VA = "0x183552550")]
		public GolfCartGhostController()
		{
		}

		// Token: 0x0400309D RID: 12445
		[Token(Token = "0x400309D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[FormerlySerializedAs("_wheelRendererTransforms")]
		private List<Transform> _localDynamicTransforms;

		// Token: 0x0400309E RID: 12446
		[Token(Token = "0x400309E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<Renderer> _debugRenderers;

		// Token: 0x0400309F RID: 12447
		[Token(Token = "0x400309F")]
		[FieldOffset(Offset = "0x40")]
		private bool _currentShowDebugRenderers;

		// Token: 0x040030A0 RID: 12448
		[Token(Token = "0x40030A0")]
		[FieldOffset(Offset = "0x0")]
		private static bool _showDebugRenderers;
	}
}
