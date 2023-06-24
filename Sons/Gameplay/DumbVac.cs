using System;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000748 RID: 1864
	[Token(Token = "0x2000748")]
	[AddComponentMenu("Sons/Gameplay/DumbVac")]
	public class DumbVac : MonoBehaviour, IImpactReceiver, IMonoBehaviour
	{
		// Token: 0x0600322D RID: 12845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600322D")]
		[Address(RVA = "0x34994F0", Offset = "0x3497AF0", VA = "0x1834994F0")]
		private void OnDisable()
		{
		}

		// Token: 0x0600322E RID: 12846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600322E")]
		[Address(RVA = "0x3499550", Offset = "0x3497B50", VA = "0x183499550")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600322F RID: 12847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600322F")]
		[Address(RVA = "0x3499B70", Offset = "0x3498170", VA = "0x183499B70")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		// Token: 0x06003230 RID: 12848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003230")]
		[Address(RVA = "0x3499DC0", Offset = "0x34983C0", VA = "0x183499DC0", Slot = "4")]
		public void OnImpact(IImpactSender sender, IImpactData impactData)
		{
		}

		// Token: 0x06003231 RID: 12849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003231")]
		[Address(RVA = "0x349A230", Offset = "0x3498830", VA = "0x18349A230")]
		public DumbVac()
		{
		}

		// Token: 0x06003232 RID: 12850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003232")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "5")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x06003233 RID: 12851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003233")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "6")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06003234 RID: 12852 RVA: 0x0000F330 File Offset: 0x0000D530
		[Token(Token = "0x6003234")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x04002B42 RID: 11074
		[Token(Token = "0x4002B42")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _moveSpeed;

		// Token: 0x04002B43 RID: 11075
		[Token(Token = "0x4002B43")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _reverseTime;

		// Token: 0x04002B44 RID: 11076
		[Token(Token = "0x4002B44")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _pauseTime;

		// Token: 0x04002B45 RID: 11077
		[Token(Token = "0x4002B45")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _rotationAmount;

		// Token: 0x04002B46 RID: 11078
		[Token(Token = "0x4002B46")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _rotationTime;

		// Token: 0x04002B47 RID: 11079
		[Token(Token = "0x4002B47")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _hitForceStrength;

		// Token: 0x04002B48 RID: 11080
		[Token(Token = "0x4002B48")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _hitTorqueStrength;

		// Token: 0x04002B49 RID: 11081
		[Token(Token = "0x4002B49")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[EventRef]
		private string _activeAudioEvent;

		// Token: 0x04002B4A RID: 11082
		[Token(Token = "0x4002B4A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[EventRef]
		private string _hitAudioEvent;

		// Token: 0x04002B4B RID: 11083
		[Token(Token = "0x4002B4B")]
		[FieldOffset(Offset = "0x50")]
		private float _rotationTimeRemaining;

		// Token: 0x04002B4C RID: 11084
		[Token(Token = "0x4002B4C")]
		[FieldOffset(Offset = "0x54")]
		private float _reverseTimeRemaining;

		// Token: 0x04002B4D RID: 11085
		[Token(Token = "0x4002B4D")]
		[FieldOffset(Offset = "0x58")]
		private float _pauseTimeRemaining;

		// Token: 0x04002B4E RID: 11086
		[Token(Token = "0x4002B4E")]
		[FieldOffset(Offset = "0x60")]
		private EventInstance _eventInstance;
	}
}
