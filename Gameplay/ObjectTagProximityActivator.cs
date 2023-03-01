using System;
using Il2CppDummyDll;
using Sons.Physics;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Gameplay
{
	// Token: 0x02000673 RID: 1651
	[Token(Token = "0x2000673")]
	[AddComponentMenu("Sons/Gameplay/ObjectTagProximityActivator")]
	public class ObjectTagProximityActivator : MonoBehaviour
	{
		// Token: 0x06002A31 RID: 10801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A31")]
		[Address(RVA = "0x2DD5370", Offset = "0x2DD4370", VA = "0x182DD5370")]
		private void OnEnable()
		{
		}

		// Token: 0x06002A32 RID: 10802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A32")]
		[Address(RVA = "0x2DD5270", Offset = "0x2DD4270", VA = "0x182DD5270")]
		private void OnDisable()
		{
		}

		// Token: 0x06002A33 RID: 10803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A33")]
		[Address(RVA = "0x2DD5470", Offset = "0x2DD4470", VA = "0x182DD5470")]
		private void OnTriggerStay(Collider other)
		{
		}

		// Token: 0x06002A34 RID: 10804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A34")]
		[Address(RVA = "0x2DD5170", Offset = "0x2DD4170", VA = "0x182DD5170")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06002A35 RID: 10805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A35")]
		[Address(RVA = "0x2DD54C0", Offset = "0x2DD44C0", VA = "0x182DD54C0")]
		public ObjectTagProximityActivator()
		{
		}

		// Token: 0x040025B8 RID: 9656
		[Token(Token = "0x40025B8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _tag;

		// Token: 0x040025B9 RID: 9657
		[Token(Token = "0x40025B9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private OnTriggerProxy _triggerProxy;

		// Token: 0x040025BA RID: 9658
		[Token(Token = "0x40025BA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _activationDelay;

		// Token: 0x040025BB RID: 9659
		[Token(Token = "0x40025BB")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _deactivationDelay;

		// Token: 0x040025BC RID: 9660
		[Token(Token = "0x40025BC")]
		[FieldOffset(Offset = "0x38")]
		private int _triggerCount;

		// Token: 0x040025BD RID: 9661
		[Token(Token = "0x40025BD")]
		[FieldOffset(Offset = "0x3C")]
		private bool _isActive;

		// Token: 0x040025BE RID: 9662
		[Token(Token = "0x40025BE")]
		[FieldOffset(Offset = "0x3D")]
		private bool _isActivating;

		// Token: 0x040025BF RID: 9663
		[Token(Token = "0x40025BF")]
		[FieldOffset(Offset = "0x3E")]
		private bool _isDeactivating;

		// Token: 0x040025C0 RID: 9664
		[Token(Token = "0x40025C0")]
		[FieldOffset(Offset = "0x40")]
		private float _timeUntilActivation;

		// Token: 0x040025C1 RID: 9665
		[Token(Token = "0x40025C1")]
		[FieldOffset(Offset = "0x44")]
		private float _timeUntilDeactivation;

		// Token: 0x040025C2 RID: 9666
		[Token(Token = "0x40025C2")]
		[FieldOffset(Offset = "0x48")]
		public UnityEvent OnActivated;

		// Token: 0x040025C3 RID: 9667
		[Token(Token = "0x40025C3")]
		[FieldOffset(Offset = "0x50")]
		public UnityEvent OnDeactivated;
	}
}
