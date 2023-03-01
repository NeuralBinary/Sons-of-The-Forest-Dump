using System;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x0200062C RID: 1580
	[Token(Token = "0x200062C")]
	[AddComponentMenu("Sons/Gameplay/DumbVac")]
	public class DumbVac : MonoBehaviour, IImpactReceiver, IMonoBehaviour
	{
		// Token: 0x06002856 RID: 10326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002856")]
		[Address(RVA = "0x2DB71A0", Offset = "0x2DB61A0", VA = "0x182DB71A0")]
		private void OnDisable()
		{
		}

		// Token: 0x06002857 RID: 10327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002857")]
		[Address(RVA = "0x2DB6E10", Offset = "0x2DB5E10", VA = "0x182DB6E10")]
		private void LateUpdate()
		{
		}

		// Token: 0x06002858 RID: 10328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002858")]
		[Address(RVA = "0x2DB74B0", Offset = "0x2DB64B0", VA = "0x182DB74B0")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		// Token: 0x06002859 RID: 10329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002859")]
		[Address(RVA = "0x2DB7200", Offset = "0x2DB6200", VA = "0x182DB7200", Slot = "4")]
		public void OnImpact(IImpactSender sender, IImpactData impactData)
		{
		}

		// Token: 0x0600285A RID: 10330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600285A")]
		[Address(RVA = "0x2DB7570", Offset = "0x2DB6570", VA = "0x182DB7570")]
		public DumbVac()
		{
		}

		// Token: 0x0600285B RID: 10331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600285B")]
		[Address(RVA = "0x288E5E0", Offset = "0x288D5E0", VA = "0x18288E5E0", Slot = "5")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x0600285C RID: 10332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600285C")]
		[Address(RVA = "0x5E9620", Offset = "0x5E8620", VA = "0x1805E9620", Slot = "6")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x0600285D RID: 10333 RVA: 0x0000BC70 File Offset: 0x00009E70
		[Token(Token = "0x600285D")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x04002402 RID: 9218
		[Token(Token = "0x4002402")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _moveSpeed;

		// Token: 0x04002403 RID: 9219
		[Token(Token = "0x4002403")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _reverseTime;

		// Token: 0x04002404 RID: 9220
		[Token(Token = "0x4002404")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _pauseTime;

		// Token: 0x04002405 RID: 9221
		[Token(Token = "0x4002405")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _rotationAmount;

		// Token: 0x04002406 RID: 9222
		[Token(Token = "0x4002406")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _rotationTime;

		// Token: 0x04002407 RID: 9223
		[Token(Token = "0x4002407")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _hitForceStrength;

		// Token: 0x04002408 RID: 9224
		[Token(Token = "0x4002408")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _hitTorqueStrength;

		// Token: 0x04002409 RID: 9225
		[Token(Token = "0x4002409")]
		[FieldOffset(Offset = "0x40")]
		[EventRef]
		[SerializeField]
		private string _activeAudioEvent;

		// Token: 0x0400240A RID: 9226
		[Token(Token = "0x400240A")]
		[FieldOffset(Offset = "0x48")]
		[EventRef]
		[SerializeField]
		private string _hitAudioEvent;

		// Token: 0x0400240B RID: 9227
		[Token(Token = "0x400240B")]
		[FieldOffset(Offset = "0x50")]
		private float _rotationTimeRemaining;

		// Token: 0x0400240C RID: 9228
		[Token(Token = "0x400240C")]
		[FieldOffset(Offset = "0x54")]
		private float _reverseTimeRemaining;

		// Token: 0x0400240D RID: 9229
		[Token(Token = "0x400240D")]
		[FieldOffset(Offset = "0x58")]
		private float _pauseTimeRemaining;

		// Token: 0x0400240E RID: 9230
		[Token(Token = "0x400240E")]
		[FieldOffset(Offset = "0x60")]
		private EventInstance _eventInstance;
	}
}
