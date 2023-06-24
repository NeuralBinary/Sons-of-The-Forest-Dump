using System;
using Il2CppDummyDll;
using Sons.Physics;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Gameplay
{
	// Token: 0x02000792 RID: 1938
	[Token(Token = "0x2000792")]
	[AddComponentMenu("Sons/Gameplay/ObjectTagProximityActivator")]
	public class ObjectTagProximityActivator : MonoBehaviour
	{
		// Token: 0x06003432 RID: 13362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003432")]
		[Address(RVA = "0x34C7680", Offset = "0x34C5C80", VA = "0x1834C7680")]
		private void OnEnable()
		{
		}

		// Token: 0x06003433 RID: 13363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003433")]
		[Address(RVA = "0x34C77C0", Offset = "0x34C5DC0", VA = "0x1834C77C0")]
		private void OnDisable()
		{
		}

		// Token: 0x06003434 RID: 13364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003434")]
		[Address(RVA = "0x34C7900", Offset = "0x34C5F00", VA = "0x1834C7900")]
		private void OnTriggerStay(Collider other)
		{
		}

		// Token: 0x06003435 RID: 13365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003435")]
		[Address(RVA = "0x34C79D0", Offset = "0x34C5FD0", VA = "0x1834C79D0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06003436 RID: 13366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003436")]
		[Address(RVA = "0x34C7AD0", Offset = "0x34C60D0", VA = "0x1834C7AD0")]
		public ObjectTagProximityActivator()
		{
		}

		// Token: 0x04002D17 RID: 11543
		[Token(Token = "0x4002D17")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _tag;

		// Token: 0x04002D18 RID: 11544
		[Token(Token = "0x4002D18")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private OnTriggerProxy _triggerProxy;

		// Token: 0x04002D19 RID: 11545
		[Token(Token = "0x4002D19")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _activationDelay;

		// Token: 0x04002D1A RID: 11546
		[Token(Token = "0x4002D1A")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _deactivationDelay;

		// Token: 0x04002D1B RID: 11547
		[Token(Token = "0x4002D1B")]
		[FieldOffset(Offset = "0x38")]
		private int _triggerCount;

		// Token: 0x04002D1C RID: 11548
		[Token(Token = "0x4002D1C")]
		[FieldOffset(Offset = "0x3C")]
		private bool _isActive;

		// Token: 0x04002D1D RID: 11549
		[Token(Token = "0x4002D1D")]
		[FieldOffset(Offset = "0x3D")]
		private bool _isActivating;

		// Token: 0x04002D1E RID: 11550
		[Token(Token = "0x4002D1E")]
		[FieldOffset(Offset = "0x3E")]
		private bool _isDeactivating;

		// Token: 0x04002D1F RID: 11551
		[Token(Token = "0x4002D1F")]
		[FieldOffset(Offset = "0x40")]
		private float _timeUntilActivation;

		// Token: 0x04002D20 RID: 11552
		[Token(Token = "0x4002D20")]
		[FieldOffset(Offset = "0x44")]
		private float _timeUntilDeactivation;

		// Token: 0x04002D21 RID: 11553
		[Token(Token = "0x4002D21")]
		[FieldOffset(Offset = "0x48")]
		public UnityEvent OnActivated;

		// Token: 0x04002D22 RID: 11554
		[Token(Token = "0x4002D22")]
		[FieldOffset(Offset = "0x50")]
		public UnityEvent OnDeactivated;
	}
}
