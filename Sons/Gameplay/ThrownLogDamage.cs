using System;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000801 RID: 2049
	[Token(Token = "0x2000801")]
	public class ThrownLogDamage : MeleeWeapon
	{
		// Token: 0x06003748 RID: 14152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003748")]
		[Address(RVA = "0x671190", Offset = "0x66F790", VA = "0x180671190", Slot = "14")]
		public override MonoBehaviour GetSourceStimuli()
		{
			return null;
		}

		// Token: 0x06003749 RID: 14153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003749")]
		[Address(RVA = "0x728460", Offset = "0x726A60", VA = "0x180728460")]
		public void SetSourceStimuli(MonoBehaviourStimuli sourceStimuli)
		{
		}

		// Token: 0x0600374A RID: 14154 RVA: 0x000107B8 File Offset: 0x0000E9B8
		[Token(Token = "0x600374A")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "15")]
		public override bool IsThrownLog()
		{
			return default(bool);
		}

		// Token: 0x0600374B RID: 14155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600374B")]
		[Address(RVA = "0x353C0B0", Offset = "0x353A6B0", VA = "0x18353C0B0", Slot = "11")]
		protected override void OnValidate()
		{
		}

		// Token: 0x0600374C RID: 14156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600374C")]
		[Address(RVA = "0x353C3C0", Offset = "0x353A9C0", VA = "0x18353C3C0", Slot = "12")]
		protected override void OnEnable()
		{
		}

		// Token: 0x0600374D RID: 14157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600374D")]
		[Address(RVA = "0x353C480", Offset = "0x353AA80", VA = "0x18353C480", Slot = "13")]
		protected override void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x0600374E RID: 14158 RVA: 0x000107D0 File Offset: 0x0000E9D0
		[Token(Token = "0x600374E")]
		[Address(RVA = "0x353C4C0", Offset = "0x353AAC0", VA = "0x18353C4C0")]
		private bool CheckEnvironmentBreak(Collider other)
		{
			return default(bool);
		}

		// Token: 0x0600374F RID: 14159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600374F")]
		[Address(RVA = "0x353CA00", Offset = "0x353B000", VA = "0x18353CA00")]
		private void CheckHitPlayerOrCharacter(Collider other)
		{
		}

		// Token: 0x06003750 RID: 14160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003750")]
		[Address(RVA = "0x353D260", Offset = "0x353B860", VA = "0x18353D260")]
		private void Update()
		{
		}

		// Token: 0x06003751 RID: 14161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003751")]
		[Address(RVA = "0x353D4B0", Offset = "0x353BAB0", VA = "0x18353D4B0")]
		public ThrownLogDamage()
		{
		}

		// Token: 0x04002FBB RID: 12219
		[Token(Token = "0x4002FBB")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Rigidbody _rigidbody;

		// Token: 0x04002FBC RID: 12220
		[Token(Token = "0x4002FBC")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private bool _doNotBreakEnvironmentWhenStatic;

		// Token: 0x04002FBD RID: 12221
		[Token(Token = "0x4002FBD")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private float _minDamageSpeed;

		// Token: 0x04002FBE RID: 12222
		[Token(Token = "0x4002FBE")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[EventRef]
		private string _fleshHitEvent;

		// Token: 0x04002FBF RID: 12223
		[Token(Token = "0x4002FBF")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private float _impactCameraShakeRadius;

		// Token: 0x04002FC0 RID: 12224
		[Token(Token = "0x4002FC0")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private float _impactShakeMax;

		// Token: 0x04002FC1 RID: 12225
		[Token(Token = "0x4002FC1")]
		[FieldOffset(Offset = "0xA8")]
		private float _lastAudioTime;

		// Token: 0x04002FC2 RID: 12226
		[Token(Token = "0x4002FC2")]
		[FieldOffset(Offset = "0xAC")]
		private float _lastCameraShakeTime;

		// Token: 0x04002FC3 RID: 12227
		[Token(Token = "0x4002FC3")]
		[FieldOffset(Offset = "0xB0")]
		private float _enableTime;

		// Token: 0x04002FC4 RID: 12228
		[Token(Token = "0x4002FC4")]
		[FieldOffset(Offset = "0xB4")]
		private float _noDamageTime;

		// Token: 0x04002FC5 RID: 12229
		[Token(Token = "0x4002FC5")]
		[FieldOffset(Offset = "0xB8")]
		private MonoBehaviourStimuli _sourceStimuli;

		// Token: 0x04002FC6 RID: 12230
		[Token(Token = "0x4002FC6")]
		[FieldOffset(Offset = "0xC0")]
		private MeleeImpactData _cachedEnvironmentImpactData;
	}
}
