using System;
using FMOD.Studio;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Data;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000672 RID: 1650
	[Token(Token = "0x2000672")]
	[AddComponentMenu("Sons/Gameplay/ObjectPhysicsInteractionSfx")]
	public class ObjectPhysicsInteractionSfx : MonoBehaviour
	{
		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06002A23 RID: 10787 RVA: 0x0000C228 File Offset: 0x0000A428
		[Token(Token = "0x17000571")]
		private float RequiredVelocityToTriggerSfxSqr
		{
			[Token(Token = "0x6002A23")]
			[Address(RVA = "0x2DD5050", Offset = "0x2DD4050", VA = "0x182DD5050")]
			get
			{
				return default(float);
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06002A24 RID: 10788 RVA: 0x0000C240 File Offset: 0x0000A440
		[Token(Token = "0x17000572")]
		private bool InWater
		{
			[Token(Token = "0x6002A24")]
			[Address(RVA = "0x66C840", Offset = "0x66B840", VA = "0x18066C840")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06002A25 RID: 10789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000573")]
		private Rigidbody Rigidbody
		{
			[Token(Token = "0x6002A25")]
			[Address(RVA = "0x2DD5060", Offset = "0x2DD4060", VA = "0x182DD5060")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002A26 RID: 10790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A26")]
		[Address(RVA = "0x2DD4910", Offset = "0x2DD3910", VA = "0x182DD4910")]
		private void OnValidate()
		{
		}

		// Token: 0x06002A27 RID: 10791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A27")]
		[Address(RVA = "0x2DD5020", Offset = "0x2DD4020", VA = "0x182DD5020")]
		private void Update()
		{
		}

		// Token: 0x06002A28 RID: 10792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A28")]
		[Address(RVA = "0x2DD44B0", Offset = "0x2DD34B0", VA = "0x182DD44B0")]
		private void OnEnable()
		{
		}

		// Token: 0x06002A29 RID: 10793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A29")]
		[Address(RVA = "0x2DD4400", Offset = "0x2DD3400", VA = "0x182DD4400")]
		private void OnDisable()
		{
		}

		// Token: 0x06002A2A RID: 10794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A2A")]
		[Address(RVA = "0x2DD4110", Offset = "0x2DD3110", VA = "0x182DD4110")]
		public void OnCollisionEnter(Collision collision)
		{
		}

		// Token: 0x06002A2B RID: 10795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A2B")]
		[Address(RVA = "0x2DD4360", Offset = "0x2DD3360", VA = "0x182DD4360")]
		private void OnCollisionExit(Collision collision)
		{
		}

		// Token: 0x06002A2C RID: 10796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A2C")]
		[Address(RVA = "0x2DD4550", Offset = "0x2DD3550", VA = "0x182DD4550")]
		public void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06002A2D RID: 10797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A2D")]
		[Address(RVA = "0x2DD48B0", Offset = "0x2DD38B0", VA = "0x182DD48B0")]
		public void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x06002A2E RID: 10798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A2E")]
		[Address(RVA = "0x2DD4A30", Offset = "0x2DD3A30", VA = "0x182DD4A30")]
		private void PlayEvent(string eventName, Vector3 point)
		{
		}

		// Token: 0x06002A2F RID: 10799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A2F")]
		[Address(RVA = "0x2DD4CB0", Offset = "0x2DD3CB0", VA = "0x182DD4CB0")]
		private void UpdateSlide()
		{
		}

		// Token: 0x06002A30 RID: 10800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A30")]
		[Address(RVA = "0x2DD5030", Offset = "0x2DD4030", VA = "0x182DD5030")]
		public ObjectPhysicsInteractionSfx()
		{
		}

		// Token: 0x040025A7 RID: 9639
		[Token(Token = "0x40025A7")]
		private const string MouseoverEventPath = "event:/SotF Events/player sounds/Inv/MouseOvers/mouseover_";

		// Token: 0x040025A8 RID: 9640
		[Token(Token = "0x40025A8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _isAnItem;

		// Token: 0x040025A9 RID: 9641
		[Token(Token = "0x40025A9")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[ItemIdPicker(true)]
		private int _itemId;

		// Token: 0x040025AA RID: 9642
		[Token(Token = "0x40025AA")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		[SerializeField]
		private ItemData _itemData;

		// Token: 0x040025AB RID: 9643
		[Token(Token = "0x40025AB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private VailAudioManager.Noise _impactNoiseStimuli;

		// Token: 0x040025AC RID: 9644
		[Token(Token = "0x40025AC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private PhysicsSfxData _physicsSfxData;

		// Token: 0x040025AD RID: 9645
		[Token(Token = "0x40025AD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _maximumVelocity;

		// Token: 0x040025AE RID: 9646
		[Token(Token = "0x40025AE")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _requiredVelocityToTriggerSfx;

		// Token: 0x040025AF RID: 9647
		[Token(Token = "0x40025AF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _waterSplashAsset;

		// Token: 0x040025B0 RID: 9648
		[Token(Token = "0x40025B0")]
		[FieldOffset(Offset = "0x50")]
		private EventInstance _eventInstance;

		// Token: 0x040025B1 RID: 9649
		[Token(Token = "0x40025B1")]
		[FieldOffset(Offset = "0x58")]
		private int _inWaterCount;

		// Token: 0x040025B2 RID: 9650
		[Token(Token = "0x40025B2")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody _rigidBody;

		// Token: 0x040025B3 RID: 9651
		[Token(Token = "0x40025B3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _slideSpeedThreshold;

		// Token: 0x040025B4 RID: 9652
		[Token(Token = "0x40025B4")]
		[FieldOffset(Offset = "0x6C")]
		private int _contactPointCount;

		// Token: 0x040025B5 RID: 9653
		[Token(Token = "0x40025B5")]
		[FieldOffset(Offset = "0x70")]
		private EventInstance _slideEventInstance;

		// Token: 0x040025B6 RID: 9654
		[Token(Token = "0x40025B6")]
		[FieldOffset(Offset = "0x78")]
		private float _slideSpeedThresholdSqr;

		// Token: 0x040025B7 RID: 9655
		[Token(Token = "0x40025B7")]
		[FieldOffset(Offset = "0x7C")]
		private bool _firstPlay;
	}
}
