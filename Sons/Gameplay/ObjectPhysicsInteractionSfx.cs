using System;
using FMOD.Studio;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Data;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000791 RID: 1937
	[Token(Token = "0x2000791")]
	[AddComponentMenu("Sons/Gameplay/ObjectPhysicsInteractionSfx")]
	public class ObjectPhysicsInteractionSfx : MonoBehaviour
	{
		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06003423 RID: 13347 RVA: 0x0000F990 File Offset: 0x0000DB90
		[Token(Token = "0x1700069E")]
		private float RequiredVelocityToTriggerSfxSqr
		{
			[Token(Token = "0x6003423")]
			[Address(RVA = "0x34C58E0", Offset = "0x34C3EE0", VA = "0x1834C58E0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06003424 RID: 13348 RVA: 0x0000F9A8 File Offset: 0x0000DBA8
		[Token(Token = "0x1700069F")]
		private bool InWater
		{
			[Token(Token = "0x6003424")]
			[Address(RVA = "0x70FE00", Offset = "0x70E400", VA = "0x18070FE00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003425 RID: 13349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003425")]
		[Address(RVA = "0x34C58F0", Offset = "0x34C3EF0", VA = "0x1834C58F0")]
		private void OnValidate()
		{
		}

		// Token: 0x06003426 RID: 13350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003426")]
		[Address(RVA = "0x34C59C0", Offset = "0x34C3FC0", VA = "0x1834C59C0")]
		private void ValidateRigidBody()
		{
		}

		// Token: 0x06003427 RID: 13351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003427")]
		[Address(RVA = "0x34C5AB0", Offset = "0x34C40B0", VA = "0x1834C5AB0")]
		private void Update()
		{
		}

		// Token: 0x06003428 RID: 13352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003428")]
		[Address(RVA = "0x34C5AC0", Offset = "0x34C40C0", VA = "0x1834C5AC0")]
		private void OnEnable()
		{
		}

		// Token: 0x06003429 RID: 13353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003429")]
		[Address(RVA = "0x34C5C90", Offset = "0x34C4290", VA = "0x1834C5C90")]
		private void OnDisable()
		{
		}

		// Token: 0x0600342A RID: 13354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600342A")]
		[Address(RVA = "0x34C5D40", Offset = "0x34C4340", VA = "0x1834C5D40")]
		public void OnCollisionEnter(Collision collision)
		{
		}

		// Token: 0x0600342B RID: 13355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600342B")]
		[Address(RVA = "0x34C62E0", Offset = "0x34C48E0", VA = "0x1834C62E0")]
		private ItemData GetItemData()
		{
			return null;
		}

		// Token: 0x0600342C RID: 13356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600342C")]
		[Address(RVA = "0x34C63F0", Offset = "0x34C49F0", VA = "0x1834C63F0")]
		private void OnCollisionExit(Collision collision)
		{
		}

		// Token: 0x0600342D RID: 13357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600342D")]
		[Address(RVA = "0x34C6520", Offset = "0x34C4B20", VA = "0x1834C6520")]
		public void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x0600342E RID: 13358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600342E")]
		[Address(RVA = "0x34C6C40", Offset = "0x34C5240", VA = "0x1834C6C40")]
		public void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x0600342F RID: 13359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600342F")]
		[Address(RVA = "0x34C6D20", Offset = "0x34C5320", VA = "0x1834C6D20")]
		private void PlayEvent(string eventName, Vector3 point)
		{
		}

		// Token: 0x06003430 RID: 13360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003430")]
		[Address(RVA = "0x34C7110", Offset = "0x34C5710", VA = "0x1834C7110")]
		private void UpdateSlide()
		{
		}

		// Token: 0x06003431 RID: 13361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003431")]
		[Address(RVA = "0x34C7630", Offset = "0x34C5C30", VA = "0x1834C7630")]
		public ObjectPhysicsInteractionSfx()
		{
		}

		// Token: 0x04002D06 RID: 11526
		[Token(Token = "0x4002D06")]
		private const string MouseoverEventPath = "event:/SotF Events/player sounds/Inv/MouseOvers/mouseover_";

		// Token: 0x04002D07 RID: 11527
		[Token(Token = "0x4002D07")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _isAnItem;

		// Token: 0x04002D08 RID: 11528
		[Token(Token = "0x4002D08")]
		[FieldOffset(Offset = "0x24")]
		[ItemIdPicker(true)]
		[SerializeField]
		private int _itemId;

		// Token: 0x04002D09 RID: 11529
		[Token(Token = "0x4002D09")]
		[FieldOffset(Offset = "0x28")]
		private ItemData _itemData;

		// Token: 0x04002D0A RID: 11530
		[Token(Token = "0x4002D0A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private VailAudioManager.Noise _impactNoiseStimuli;

		// Token: 0x04002D0B RID: 11531
		[Token(Token = "0x4002D0B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private PhysicsSfxData _physicsSfxData;

		// Token: 0x04002D0C RID: 11532
		[Token(Token = "0x4002D0C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _maximumVelocity;

		// Token: 0x04002D0D RID: 11533
		[Token(Token = "0x4002D0D")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _requiredVelocityToTriggerSfx;

		// Token: 0x04002D0E RID: 11534
		[Token(Token = "0x4002D0E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _waterSplashAsset;

		// Token: 0x04002D0F RID: 11535
		[Token(Token = "0x4002D0F")]
		[FieldOffset(Offset = "0x50")]
		private EventInstance _eventInstance;

		// Token: 0x04002D10 RID: 11536
		[Token(Token = "0x4002D10")]
		[FieldOffset(Offset = "0x58")]
		private int _inWaterCount;

		// Token: 0x04002D11 RID: 11537
		[Token(Token = "0x4002D11")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody _rigidBody;

		// Token: 0x04002D12 RID: 11538
		[Token(Token = "0x4002D12")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _slideSpeedThreshold;

		// Token: 0x04002D13 RID: 11539
		[Token(Token = "0x4002D13")]
		[FieldOffset(Offset = "0x6C")]
		private int _contactPointCount;

		// Token: 0x04002D14 RID: 11540
		[Token(Token = "0x4002D14")]
		[FieldOffset(Offset = "0x70")]
		private EventInstance _slideEventInstance;

		// Token: 0x04002D15 RID: 11541
		[Token(Token = "0x4002D15")]
		[FieldOffset(Offset = "0x78")]
		private float _slideSpeedThresholdSqr;

		// Token: 0x04002D16 RID: 11542
		[Token(Token = "0x4002D16")]
		[FieldOffset(Offset = "0x7C")]
		private bool _firstPlay;
	}
}
